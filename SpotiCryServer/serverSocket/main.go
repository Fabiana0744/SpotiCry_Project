package main

import (
	"bufio"
	"fmt"
	"github.com/hajimehoshi/go-mp3"
	"log"
	"math"
	"math/rand"
	"net"
	"os"
	"path/filepath"
	"strconv"
	"strings"
	"time"
)

type song struct {
	name              string
	artist            string
	genre             string
	location          string
	durationInSeconds int64
}

type songList []song

var songCollection songList

func searchSong(name string) bool {
	name = strings.ToLower(name)
	for _, s := range songCollection {
		if strings.ToLower(s.name) == name {
			return true
		}
	}
	return false
}

func addSong(name, artist, genre, location string) {
	if !searchSong(name) {
		duration, err := getSongDuration(location)
		if err != nil {
			fmt.Printf("Error al obtener la duración de la canción %s: %v\n", name, err)
			return
		}

		newSong := song{
			name:              name,
			artist:            artist,
			genre:             genre,
			location:          location,
			durationInSeconds: duration,
		}
		songCollection = append(songCollection, newSong)
	} else {
		fmt.Printf("Song with name '%s' already exists.\n", name)
	}
}

func removeSong(name string) {
	if !searchSong(name) {
		fmt.Printf("Song with name '%s' not found.\n", name)
		return
	}

	var newSongList songList
	for _, s := range songCollection {
		if s.name != name {
			newSongList = append(newSongList, s)
		}
	}
	songCollection = newSongList
	fmt.Printf("Song with name '%s' has been removed.\n", name)
}

func getSongLocation(songName string) (string, error) {
	// Obtener el directorio de trabajo actual
	currentDir, err := os.Getwd()
	if err != nil {
		return "", err
	}

	// Construir la ruta completa al archivo de música
	musicFilePath := filepath.Join(currentDir, "music", songName+".mp3")

	return musicFilePath, nil
}

func getSongDuration(location string) (int64, error) {
	file, err := os.Open(location)
	if err != nil {
		return 0, err
	}
	defer file.Close()

	decoder, err := mp3.NewDecoder(file)
	if err != nil {
		return 0, err
	}

	// Obtén el número de muestras y la frecuencia de muestreo
	numSamples := int64(decoder.Length())
	sampleRate := int64(decoder.SampleRate())

	// Calcula la duración en segundos
	durationInSeconds := numSamples / sampleRate / 4

	return durationInSeconds, nil
}

// Función para verificar si una canción existe en el servidor
func CheckIfSongExists(songName string) bool {
	songName = strings.ToLower(songName)
	for _, s := range songCollection {
		if strings.ToLower(s.name) == songName {
			return true
		}
	}
	return false
}

//----------------FUNCIONES DE BUSQUEDAS--------------------

// Busqueda por criterio (nombre, artista, género)
func searchByCriteria(criteria, searchTerm string) []song {
	matchingSongs := []song{}
	searchTerm = strings.ToLower(searchTerm)

	switch criteria {
	case "name":
		return filter2(songCollection, func(s song) bool {
			return strings.Contains(strings.ToLower(s.name), searchTerm)
		})
	case "artist":
		return filter2(songCollection, func(s song) bool {
			return strings.Contains(strings.ToLower(s.artist), searchTerm)
		})
	case "genre":
		return filter2(songCollection, func(s song) bool {
			return strings.Contains(strings.ToLower(s.genre), searchTerm)
		})
	default:
		return matchingSongs
	}
}

// Busqueda por duración en minutos
func searchByDuration(maxDurationInMinutes int64) []song {
	maxDurationInSeconds := maxDurationInMinutes * 60 // Convierte minutos a segundos
	return filter2(songCollection, func(s song) bool {
		return s.durationInSeconds <= maxDurationInSeconds
	})
}

// Busqueda por similitud de tiempo de una canción
func searchBySimilarity(referenceSongName string) []song {
	var referenceSong song
	matchingSongs := []song{}

	// Busca la canción de referencia por nombre
	for _, s := range songCollection {
		if strings.EqualFold(s.name, referenceSongName) {
			referenceSong = s
			break
		}
	}

	if referenceSong.name == "" {
		// Si no se encontró la canción de referencia, devuelve una lista vacía
		return matchingSongs
	}

	// Define el umbral máximo de diferencia de duración en segundos
	maxDurationDifference := int64(60) // Por ejemplo, 60 segundos de diferencia máxima

	// Compara la diferencia de duración con el umbral máximo para encontrar canciones similares
	for _, s := range songCollection {
		// Calcula la diferencia en la duración en segundos entre la canción de referencia y la canción actual
		durationDifference := int64(math.Abs(float64(referenceSong.durationInSeconds - s.durationInSeconds)))

		// Compara la diferencia de duración con el umbral máximo
		if durationDifference <= maxDurationDifference {
			matchingSongs = append(matchingSongs, s)
		}
	}

	return matchingSongs
}

func sendSearchResults(connection net.Conn, matchingSongs []song) {
	if len(matchingSongs) == 0 {
		connection.Write([]byte("No matching songs found.\n"))
		return
	}
	// Construye una cadena con la lista de canciones
	var result string
	for _, s := range matchingSongs {
		result += fmt.Sprintf("{%s; %s; %s; %s; %d}", s.name, s.artist, s.genre, s.location, s.durationInSeconds)
	}

	// Envía la lista de canciones al cliente
	connection.Write([]byte(result + "\n"))
}

func filter2[P1 any](list []P1, f func(P1) bool) []P1 {
	filtered := make([]P1, 0)

	for _, element := range list {
		if f(element) {
			filtered = append(filtered, element)
		}
	}
	return filtered
}

//-----------------------------------------------------------

func fillDefaultSongs() {
	addSong("Snow", "Red Hot Chili Peppers", "Rock", "music/Snow.mp3")
	addSong("Perfect", "Ed Sheeran", "Pop", "music/Perfect.mp3")
	addSong("Shape of you", "Ed Sheeran", "Pop", "music/Shape of you.mp3")
}

// ----------------FUNCIONES DE MANEJO DEL CLIENTE--------------------
func handleClient(connection net.Conn, connectionNumber int) {
	defer connection.Close()

	//fmt.Println("Connection#", connectionNumber, "started!")

	clientReader := bufio.NewReader(connection)

	for {
		clientRequest, err := clientReader.ReadString('\n')

		switch err {
		case nil:
			if clientRequest == "quit\n" {
				log.Println("client requested server to close the connection so closing")
				return
			} else {
				log.Println("CLIENT#", connectionNumber, " says: ", clientRequest)

				rand.Seed(time.Now().UnixNano())
				n := rand.Intn(5000)                            //Genera un número aleatorio entre 0 y 4999
				time.Sleep(time.Duration(n) * time.Millisecond) // Pausa la ejecución durante un tiempo aleatorio (n milisegundos)
				// para simular cierta actividad antes de responder al cliente.

				//Parsing del comando y criterio
				parts := strings.Fields(clientRequest)
				command := parts[0]

				if len(parts) == 1 {
					switch command {
					case "listAllPlaylists":
						fmt.Println("Client viendo los playlists existentes")
						connection.Write([]byte("Mostrando todos los playlists.\n"))
					case "pause":
						fmt.Println("Cancion pausada")
						connection.Write([]byte("Cancion pausada.\n"))
					case "resume":
						fmt.Println("Cancion reanudada")
						connection.Write([]byte("Cancion reanudada.\n"))
					case "next":
						fmt.Println("Siguiente cancion")
						connection.Write([]byte("Siguiente cancion\n"))
					case "prev":
						fmt.Println("Cancion anterior")
						connection.Write([]byte("Cancion anterior.\n"))
					case "forward":
						fmt.Println("Cancion pausada")
						connection.Write([]byte("Cancion adelantada 10 segundos.\n"))
					case "backward":
						fmt.Println("Cancion reanudada")
						connection.Write([]byte("Cancion atrasada 10 segundos.\n"))
					}
				}

				if len(parts) > 1 {
					//criteria := parts[1]
					//searchTerm := strings.Join(parts[2:], " ")

					switch command {
					case "play":
						songName := strings.TrimSpace(strings.TrimPrefix(clientRequest, "play "))
						ubicacion, err := getSongLocation(songName)
						if err != nil {
							connection.Write([]byte("Canción no encontrada o error en la respuesta.\n"))
						} else {
							// Envía la ubicación completa de la canción al cliente
							connection.Write([]byte(ubicacion + "\n"))
							//fmt.Println(ubicacion)
						}
					case "search":
						handleSearchCommand(connection, parts)
					case "add":
						if len(parts) < 5 {
							connection.Write([]byte("Usage: add songName artist genre location\n"))
							continue
						}
						name := parts[1]
						artist := parts[2]
						genre := parts[3]
						location := parts[4]
						addSong(name, artist, genre, location)
						connection.Write([]byte("Song added: " + name + "\n"))
					case "remove":
						if len(parts) < 2 {
							connection.Write([]byte("Usage: remove songName\n"))
							continue
						}
						songName := strings.Join(parts[1:], " ")
						removeSong(songName)
					case "createPlaylist":
						fmt.Println("Un cliente agregando Playlist")
						connection.Write([]byte("Cliente creando playlist.\n"))
					case "addToPlaylist":
						fmt.Println("Un cliente agregando cancion a Playlist")
						connection.Write([]byte("Cliente agregando cancion a playlist.\n"))
					case "removeFromPlaylist":
						fmt.Println("Un cliente eliminando cancion de Playlist")
						connection.Write([]byte("Cliente eliminando cancion de playlist.\n"))
					case "listPlaylist":
						fmt.Println("Un cliente listando cancion/es de Playlist")
						connection.Write([]byte("Cliente listando cancion/es de playlist.\n"))
					case "startPlaylist":
						fmt.Println("Un cliente reproduciendo Playlist")
						connection.Write([]byte("Cliente reproduciendo playlist.\n"))
					case "updatePlaylist":
						fmt.Println("Un cliente actualizando Playlist")
						connection.Write([]byte("Cliente actualizando playlist.\n"))
					case "checkSongExistence":
						if len(parts) < 2 {
							fmt.Println("Verificando que cancion existe\n")
							connection.Write([]byte("Verificando que cancion existe\n"))
							continue
						}
						//songName := parts[1]
						songName := strings.Join(parts[1:], " ") // Une los argumentos con espacios
						if CheckIfSongExists(songName) {
							fmt.Println("Cancion existente\n")
							connection.Write([]byte("Cancion existente\n"))
						} else {
							fmt.Println("Cancion no existe\n")
							connection.Write([]byte("Cancion no existe\n"))
						}

					default:
						connection.Write([]byte("Unknown command: " + command + "\n"))
					}
				}
			}
		}

	}
}

func handleSearchCommand(connection net.Conn, parts []string) {
	if len(parts) < 3 {
		connection.Write([]byte("Usage: search [criteria] [searchTerm]\n"))
		return
	}

	criteria := parts[1]
	searchTerm := strings.Join(parts[2:], " ")

	var matchingSongs []song

	switch criteria {
	case "name", "artist", "genre":
		matchingSongs = searchByCriteria(criteria, searchTerm)
		sendSearchResults(connection, matchingSongs)
		fmt.Println("Lista de canciones: ", matchingSongs)

	case "duration":
		maxDurationInMinutes, err := strconv.ParseInt(searchTerm, 10, 64)
		if err != nil {
			connection.Write([]byte("Invalid duration value.\n"))
			return
		}
		matchingSongs = searchByDuration(maxDurationInMinutes)
		sendSearchResults(connection, matchingSongs)
		fmt.Println("Lista de canciones: ", matchingSongs)

	case "similarity":
		matchingSongs = searchBySimilarity(searchTerm)
		sendSearchResults(connection, matchingSongs)
		fmt.Println("Lista de canciones similares: ", matchingSongs)
	default:
		connection.Write([]byte("Unknown search criteria: " + criteria + "\n"))
	}

}

//--------------------------------------------------------------------

func main() {
	// Inicializar canciones predeterminadas
	fillDefaultSongs()
	// Define the port on which the server will listen for requests
	port := "8080"

	// Create a TCP server on the specified port
	server, err := net.Listen("tcp", ":"+port)
	if err != nil {
		fmt.Println("*** Server STARTED ***")
		fmt.Println("Error creating the server:", err)
		return
	}
	defer server.Close()

	fmt.Println("*** Server STARTED ***")
	connectionNumber := 1

	for {
		fmt.Println("Waiting for connections...")
		connection, err := server.Accept()
		if err != nil {
			fmt.Println("Error accepting connection:", err)
			continue
		}

		fmt.Println("Connection#", connectionNumber, "started!")

		go handleClient(connection, connectionNumber)
		connectionNumber++
	}
}
