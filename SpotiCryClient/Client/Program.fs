namespace Client

open System
open System.IO
open System.Net.Sockets
open System.Text
open System.Threading.Tasks
open NAudio.Wave

module clientActions =

    let client = new TcpClient("127.0.0.1", 8080)
    let stream = client.GetStream()
    let writer = new StreamWriter(stream, Encoding.ASCII)
    let reader = new StreamReader(stream, Encoding.ASCII)

    let waveOut = new WaveOutEvent()
    
    let mutable isPaused = false
    let mutable currentPosition = 0L
    let mutable currentSongPath = ""
    let mutable audioFileReader = null : AudioFileReader

    // Variable para saber si se esta reproduciendo canción
    let mutable isPlaying = false
    // Variable que indica cancion de la playlist
    let mutable currentIndex = 0
    // Variable para saber playlist actual
    let mutable currentPlaylist = []

    //---------------------LOGICA DE PLAYLISTS--------------------
    type Playlist = { Name: string; Songs: string list }

    // Referencia inmutable para la lista de reproducción actual
    let playlists : Playlist list ref = ref []

    // Función para crear una nueva lista de reproducción
    let createPlaylist (command: string, playlistName: string) :bool =
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        if List.exists (fun p -> p.Name = playlistName) !playlists then
            printfn "La lista de reproducción '%s' ya existe." playlistName
            false
        else
            let newPlaylist = { Name = playlistName; Songs = [] }
            playlists := newPlaylist :: !playlists
            printfn "Lista de reproducción '%s' creada con éxito." playlistName
            true

    // Función para agregar una canción a una lista de reproducción existente
    let addToPlaylist (playlistName: string) (songName: string) :bool=
        let command1 = sprintf "addToPlaylist %s" playlistName
        writer.WriteLine(command1)
        writer.Flush()
        let response = reader.ReadLine()
        let playlist = List.tryFind (fun p -> p.Name = playlistName) !playlists
        match playlist with
        | Some(p) ->
            // Verifica si la canción existe en la lista de reproducción antes de agregarla
            if List.exists (fun s -> s = songName) p.Songs then
                printfn "La canción '%s' ya está en la lista de reproducción '%s'." songName playlistName
                false
            else
                // Verifica si la canción existe en el servidor antes de agregarla
                let command = sprintf "checkSongExistence %s" songName
                writer.WriteLine(command)
                writer.Flush()

                let response = reader.ReadLine()

                match response with
                | "Cancion existente" ->
                    let updatedPlaylist = { p with Songs = songName :: p.Songs }
                    playlists := List.map (fun pl -> if pl.Name = playlistName then updatedPlaylist else pl) !playlists
                    printfn "Canción '%s' agregada a la lista de reproducción '%s'." songName playlistName
                    true
                | "Cancion no existe" ->
                    printfn "La canción '%s' no existe en el servidor." songName
                    false
                | _ ->
                    printfn "Respuesta inesperada del servidor: %s" response
                    false
        | None ->
            printfn "La lista de reproducción '%s' no existe." playlistName
            false

    // Función para eliminar una canción de una lista de reproducción existente
    let removeFromPlaylist (playlistName: string) (songName: string) =
        let command1 = sprintf "removeFromPlaylist %s %s" playlistName songName
        writer.WriteLine(command1)
        writer.Flush()
        let response = reader.ReadLine()

        let playlist = List.tryFind (fun p -> p.Name = playlistName) !playlists
        match playlist with
        | Some(p) ->
            if List.exists (fun s -> s = songName) p.Songs then
                let updatedSongs = List.filter (fun s -> s <> songName) p.Songs
                let updatedPlaylist = { p with Songs = updatedSongs }
                playlists := List.map (fun pl -> if pl.Name = playlistName then updatedPlaylist else pl) !playlists
                printfn "Canción '%s' eliminada de la lista de reproducción '%s'." songName playlistName
            else
                printfn "La canción '%s' no se encuentra en la lista de reproducción '%s'." songName playlistName
        | None ->
            printfn "La lista de reproducción '%s' no existe." playlistName

    // Función para listar todas las canciones de una lista de reproducción
    let listPlaylist (playlistName: string) =
        let command = sprintf "listPlaylist %s" playlistName
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        let playlist = List.tryFind (fun p -> p.Name = playlistName) !playlists
        match playlist with
        | Some(p) -> p.Songs
        | None -> []

    // Función para listar todos los nombres de los playlists
    let listAllPlaylists (command: string) =
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        let playlistNames = List.map (fun playlist -> playlist.Name) !playlists
        playlistNames

    // Función para actualizar lista de reproducción
    let updatePlaylist (playlistName: string) =
        let playlist = List.tryFind (fun p -> p.Name = playlistName) !playlists
        match playlist with
        | Some(p) ->
            let updatedSongs =
                List.filter (fun songName ->
                    let command = sprintf "checkSongExistence %s" songName
                    writer.WriteLine(command)
                    writer.Flush()

                    let response = reader.ReadLine()
                    response = "Cancion existente"
                ) p.Songs
            let updatedPlaylist = { p with Songs = updatedSongs }
            playlists := List.map (fun pl -> if pl.Name = playlistName then updatedPlaylist else pl) !playlists
            printfn "Lista de reproducción '%s' actualizada exitosamente." playlistName
        | None ->
            printfn "La lista de reproducción '%s' no existe." playlistName

    // Función para reproducir la canción actual en la lista de reproducción
    let playCurrentSong (currentIndex: int) (currentPlaylist: string list) =
        if currentIndex >= 0 && currentIndex < List.length currentPlaylist then
            let songName = List.nth currentPlaylist currentIndex
            let command = sprintf "play %s" songName
            writer.WriteLine(command)
            writer.Flush()

            let response = reader.ReadLine()
            if response.StartsWith("C:") then
                let location = response
                let songPath = if location.EndsWith(".mp3") then location else location + ".mp3"

                //En caso de que se esté reproduciendo una canción, detenerla
                if isPlaying then
                    waveOut.Stop()

                //Función para reproducir la canción en una tarea secundaria
                let playSongAsync (songPath: string) =
                    Task.Run(fun () ->
                        let audioFileReader = new AudioFileReader(songPath)
                        waveOut.Init(audioFileReader)
                        waveOut.Play()

                        while waveOut.PlaybackState = PlaybackState.Playing do
                            System.Threading.Thread.Sleep(100)
                    )

                //Iniciar la reproducción de la nueva canción
                playSongAsync songPath |> ignore
                isPlaying <- true
            else
                printfn "No se pudo obtener la ubicación de la canción '%s'." songName

    // Función para avanzar a la siguiente canción en la lista de reproducción
    let nextSong () =
        let command = "next "
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        if List.length currentPlaylist > 0 then
            currentIndex <- (currentIndex + 1) % List.length currentPlaylist
            playCurrentSong currentIndex currentPlaylist

    // Función para retroceder a la canción anterior en la lista de reproducción
    let prevSong () =
        let command = "prev"
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        if List.length currentPlaylist > 0 then
            currentIndex <- (currentIndex - 1 + List.length currentPlaylist) % List.length currentPlaylist
            playCurrentSong currentIndex currentPlaylist

    // Función para reproducir una lista de reproducción
    let playPlaylist (playlistName: string) :bool=
        let command = sprintf "playPlaylist %s" playlistName
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        let songs = listPlaylist playlistName

        if List.length songs = 0 then
            printfn "La lista de reproducción '%s' está vacía." playlistName
            false
        else
            printfn "Reproduciendo '%s'..." playlistName

            // Establece la lista de reproducción actual y el índice
            currentPlaylist <- songs
            currentIndex <- 0
            isPlaying <- true

            // Inicia la reproducción de la primera canción
            playCurrentSong currentIndex currentPlaylist

            // Espera a que la última canción termine de reproducirse antes de finalizar
            while waveOut.PlaybackState = PlaybackState.Playing do
                System.Threading.Thread.Sleep(100)

            printfn "Reproducción de '%s' finalizada." playlistName
            true

    // Función para obtener el nombre de la canción actual
    let getCurrentSongName () =
        if currentIndex >= 0 && currentIndex < List.length currentPlaylist then
            let songName = List.nth currentPlaylist currentIndex
            songName
        else
            ""
    //----------------------------------------------------------------


    //--------------------- REPRODUCCION DE CANCIONES --------------------
    // Función para reproducir la canción en una tarea secundaria
    let playSong (songPath: string) =
        Task.Run(fun () ->
            // Si hay una canción en reproducción, detenerla primero
            if waveOut.PlaybackState = PlaybackState.Playing then
                waveOut.Stop()

            // Guardar la ruta de la canción actual
            currentSongPath <- songPath

            audioFileReader <- new AudioFileReader(songPath)
            waveOut.Init(audioFileReader)
            waveOut.Play()
            while waveOut.PlaybackState = PlaybackState.Playing do
                System.Threading.Thread.Sleep(100)
        )

    let playSongCommandServer(command: string) =
        writer.WriteLine(command)
        writer.Flush()
        // Leer la respuesta de manera síncrona y devolver el resultado
        let response = reader.ReadLine()
        if response.StartsWith("C:") then
                let location = response
                let songPath = if location.EndsWith(".mp3") then location else location + ".mp3"
                Task.Run(fun () -> playSong songPath) |> ignore
   
   // Función para pausar la reproducción
    let pauseSong (command: string) =
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        if waveOut.PlaybackState = PlaybackState.Playing then
            waveOut.Pause()
            isPaused <- true

    // Función para reanudar la reproducción desde la posición de pausa
    let resumeSong (command: string) =
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        if isPaused && waveOut.PlaybackState = PlaybackState.Paused then
            waveOut.Play()
            isPaused <- false

    // Función para adelantar la canción en 10 segundos
    let forwardSong (command: string) =
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        if waveOut.PlaybackState = PlaybackState.Playing && currentSongPath <> "" then
            let currentPosition = audioFileReader.Position
            let newPosition = int64 (float currentPosition + TimeSpan.FromSeconds(120.0).TotalSeconds * float audioFileReader.WaveFormat.SampleRate)
        
            // Asegurarse de no exceder el final de la canción
            let maxPosition = audioFileReader.Length
            let adjustedPosition = min newPosition maxPosition

            // Detener la reproducción actual
            waveOut.Stop()

            // Inicializar el lector de archivos de audio con la nueva posición
            audioFileReader.Position <- adjustedPosition

            // Inicializar el reproductor de audio nuevamente
            waveOut.Init(audioFileReader)
            waveOut.Play()

    // Función para retroceder la canción en 10 segundos
    let backwardSong (command: string) =
        writer.WriteLine(command)
        writer.Flush()
        if waveOut.PlaybackState = PlaybackState.Playing && currentSongPath <> "" then
            let currentPosition = audioFileReader.Position
            let newPosition = int64 (float currentPosition - TimeSpan.FromSeconds(120.0).TotalSeconds * float audioFileReader.WaveFormat.SampleRate)

        
            // Asegurarse de no ir antes del inicio de la canción
            let adjustedPosition = max 0L newPosition

            // Detener la reproducción actual
            waveOut.Stop()

            // Inicializar el lector de archivos de audio con la nueva posición
            audioFileReader.Position <- adjustedPosition

            // Inicializar el reproductor de audio nuevamente
            waveOut.Init(audioFileReader)
            waveOut.Play()

    // Función para detener la reproducción de la canción actual
    let stopSong () =
        if waveOut.PlaybackState = PlaybackState.Playing then
            waveOut.Stop()
        currentSongPath <- ""
        audioFileReader <- null

    //-------------------------------------------------------------

    // Función para hacer las búsquedas
    let searchByCriteria (command: string) : string =
        writer.WriteLine(command)
        writer.Flush()
        let response = reader.ReadLine()
        response


    // Función para iniciar el cliente
    let connectToServer () =
        try
            Console.WriteLine("*** Cliente INICIADO ***")
        with
        | :? Exception as ex ->
            Console.WriteLine("Error: {0}", ex.Message)

        Console.WriteLine("Cerrando el cliente...")


    [<EntryPoint>]
    let main argv =
        connectToServer ()
        0

