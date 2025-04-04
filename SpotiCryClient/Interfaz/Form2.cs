using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Interfaz
{
    public partial class Form2 : Form
    {
        public String name;
        public String playlistname;
        public String message;

        public Form2()
        {
            InitializeComponent();
            hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panelInicio.Visible = true;
            panelBuscarCriterio.Visible = false;

        }

        private void hide()
        {
            panelBuscar.Visible = false;

        }

        private void presently()
        {
            if (panelBuscar.Visible == false)
                panelBuscar.Visible = true;
        }

        public void setSongName(String name)
        {
            this.name = name;
        }

        public String getSongName()
        {
            return this.name;
        }

        public void setPlaylistName(String playlist)
        {
            this.playlistname = playlist;
        }

        public String getPlaylistName()
        {
            return this.playlistname;
        }

        public void setSongMessage(String message)
        {
            this.message = message;
        }

        public String getSongMessage()
        {
            return this.message;
        }

        public void showFormReproduccion()
        {
            formReproduccion form = new formReproduccion(this);
            form.Show();
        }

        private void showFormOpciones()
        {
            FormOpciones formO = new FormOpciones(this);
            formO.Show();
        }

        public void showFormPlaylists()
        {
            FormPlaylists formPlaylist = new FormPlaylists(this);
            formPlaylist.Show();
        }



        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            presently();

        }

        private void buttonCriterio_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelVerListas.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAñadirCancion.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelBuscarCriterio.Visible = true;
        }

        private void buttonDuracion_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelVerListas.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAñadirCancion.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelBuscarDuracion.Visible = true;
        }

        private void buttonSimilitud_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelVerListas.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAñadirCancion.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelBuscarSimilitud.Visible = true;
        }

        private void buttonListas_Click(object sender, EventArgs e)
        {
            hide();
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelCrearLista.Visible = false;
            panelVerListas.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAñadirCancion.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelListas.Visible = true;

        }

        private void buttonCrearListas_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelVerListas.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAñadirCancion.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelCrearLista.Visible = true;
        }

        private void buttonVerListas_Click(object sender, EventArgs e)
        {
            panelVerListas.Visible = true;
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelAñadirCancion.Visible = false;
            panelEliminarCancion.Visible = false;

            dataGridView6.ReadOnly = true;
            dataGridView6.Rows.Clear();

            string command = "listAllPlaylists";
            Microsoft.FSharp.Collections.FSharpList<string> playlistNames = Client.clientActions.listAllPlaylists(command);

            List<string> playlistNamesList = playlistNames.ToList();

            //Agrega cada nombre de lista de reproducción al DataGridView6
            foreach (string playlistName in playlistNames)
            {
                dataGridView6.Rows.Add(playlistName);
            }
        }


        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelReproduccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBuscarCriterio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // Obtén el texto ingresado por el usuario en el cuadro de búsqueda
            string consulta = textBox1.Text.Trim();
            string criterio = "name";
            //string terminoBusqueda = textBox1.Text;

            // Construye la cadena de comando para la búsqueda
            string comando = $"search {criterio} {consulta}";
            string resultadoCanciones = Client.clientActions.searchByCriteria(comando);

            // Divide el string en canciones individuales usando '}{' como separador
            string[] canciones = resultadoCanciones.Split(new string[] { "}{" }, StringSplitOptions.RemoveEmptyEntries);


            // Recorre la lista de canciones y agrega cada canción al ListView
            foreach (string cancion in canciones)
            {
                // Elimina los corchetes al principio y al final de cada canción
                string detallesCancion = cancion.Trim('{', '}');

                // Divide los detalles de la canción en partes utilizando ';' como separador
                string[] detalles = detallesCancion.Split(';');

                if (detalles.Length == 5)
                {
                    string nombreCancion = detalles[0];
                    string artista = detalles[1];
                    string genero = detalles[2];
                    //string ruta = detalles[3];
                    // string duracion = detalles[4];

                    dataGridView1.ReadOnly = true;
                    // Agrega una nueva fila al DataGridView con los datos de la canción
                    dataGridView1.Rows.Add(nombreCancion, artista, genero);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            string consulta = textBox2.Text.Trim();
            string criterio = "duration";

            string comando = $"search {criterio} {consulta}";
            string resultadoCanciones = Client.clientActions.searchByCriteria(comando);

            string[] canciones = resultadoCanciones.Split(new string[] { "}{" }, StringSplitOptions.RemoveEmptyEntries);


            foreach (string cancion in canciones)
            {
                string detallesCancion = cancion.Trim('{', '}');

                string[] detalles = detallesCancion.Split(';');

                if (detalles.Length == 5)
                {
                    string nombreCancion = detalles[0];
                    string artista = detalles[1];
                    string genero = detalles[2];
                    //string ruta = detalles[3];
                    string duracion = detalles[4];

                    dataGridView2.ReadOnly = true;
                    // Agrega una nueva fila al DataGridView con los datos de la canción
                    dataGridView2.Rows.Add(nombreCancion, artista, genero, duracion);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            string consulta = textBox3.Text.Trim();
            string criterio = "similarity";

            string comando = $"search {criterio} {consulta}";
            string resultadoCanciones = Client.clientActions.searchByCriteria(comando);

            string[] canciones = resultadoCanciones.Split(new string[] { "}{" }, StringSplitOptions.RemoveEmptyEntries);


            foreach (string cancion in canciones)
            {
                string detallesCancion = cancion.Trim('{', '}');

                string[] detalles = detallesCancion.Split(';');

                if (detalles.Length == 5)
                {
                    string nombreCancion = detalles[0];
                    string artista = detalles[1];
                    string genero = detalles[2];
                    string duracion = detalles[4];

                    dataGridView3.ReadOnly = true;
                    // Agrega una nueva fila al DataGridView con los datos de la canción
                    dataGridView3.Rows.Add(nombreCancion, artista, genero, duracion);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string consulta = textBox4.Text.Trim();
            string criterio = "artist";

            string comando = $"search {criterio} {consulta}";
            string resultadoCanciones = Client.clientActions.searchByCriteria(comando);

            string[] canciones = resultadoCanciones.Split(new string[] { "}{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string cancion in canciones)
            {
                string detallesCancion = cancion.Trim('{', '}');

                string[] detalles = detallesCancion.Split(';');

                if (detalles.Length == 5)
                {
                    string nombreCancion = detalles[0];
                    string artista = detalles[1];
                    string genero = detalles[2];
                    //string ruta = detalles[3];
                    // string duracion = detalles[4];

                    dataGridView1.ReadOnly = true;
                    dataGridView1.Rows.Add(nombreCancion, artista, genero);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string consulta = textBox5.Text.Trim();
            string criterio = "genre";

            string comando = $"search {criterio} {consulta}";
            string resultadoCanciones = Client.clientActions.searchByCriteria(comando);

            string[] canciones = resultadoCanciones.Split(new string[] { "}{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string cancion in canciones)
            {
                string detallesCancion = cancion.Trim('{', '}');

                string[] detalles = detallesCancion.Split(';');

                if (detalles.Length == 5)
                {
                    string nombreCancion = detalles[0];
                    string artista = detalles[1];
                    string genero = detalles[2];
                    //string ruta = detalles[3];
                    // string duracion = detalles[4];

                    dataGridView1.ReadOnly = true;
                    dataGridView1.Rows.Add(nombreCancion, artista, genero);
                }
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el índice de columna es válido (para evitar excepciones)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Accede a los datos de la fila seleccionada según las columnas
                string nombreCancion = selectedRow.Cells["colNombreCriterio"].Value.ToString();
                string artista = selectedRow.Cells["colArtistaCriterio"].Value.ToString();
                string genero = selectedRow.Cells["colGeneroCriterio"].Value.ToString();

                setSongName(nombreCancion);
                string message = $"Ha seleccionado la canción '{nombreCancion}'. ¿Qué desea hacer?";
                setSongMessage(message);

                showFormOpciones();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el índice de columna es válido (para evitar excepciones)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                // Accede a los datos de la fila seleccionada según las columnas
                string nombreCancion = selectedRow.Cells["colNombreDuracion"].Value.ToString();
                string artista = selectedRow.Cells["colArtistaDuracion"].Value.ToString();
                string genero = selectedRow.Cells["colGeneroDuracion"].Value.ToString();

                setSongName(nombreCancion);
                string message = $"Ha seleccionado la canción '{nombreCancion}'. ¿Qué desea hacer?";
                setSongMessage(message);

                showFormOpciones();
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];

                string nombreCancion = selectedRow.Cells["colNombreSimilitud"].Value.ToString();
                string artista = selectedRow.Cells["colArtistaSimilitud"].Value.ToString();
                string genero = selectedRow.Cells["colGeneroSimilitud"].Value.ToString();

                setSongName(nombreCancion);
                string message = $"Ha seleccionado la canción '{nombreCancion}'. ¿Qué desea hacer?";
                setSongMessage(message);

                showFormOpciones();
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            string playlistName = textBox6.Text.Trim();
            string command = $"createPlaylist {playlistName}";


            bool playlist = Client.clientActions.createPlaylist(command, playlistName);

            if (playlist == true)
            {
                MessageBox.Show($"Nueva Lista de Reproducción creada: {playlistName}");
            }
            else
            {
                MessageBox.Show($"Error al crear lista de reproducción {playlistName}. Lista de reproducción ya existe");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView6.Rows[e.RowIndex];

                string nombreLista = selectedRow.Cells[0].Value.ToString();

                string message = $"Repoduciendo Lista: {nombreLista}";
                setSongMessage(message);
                setPlaylistName(nombreLista);

                showFormPlaylists();
            }
        }


        private void showSongs(string playlistName)
        {
            try
            {
                // Configurar el DataGridView5
                dataGridView5.Rows.Clear();
                dataGridView5.ReadOnly = true;

                // Llamar a la función listPlaylist para obtener la lista de canciones
                string command = $"listPlaylist {playlistName}";
                Microsoft.FSharp.Collections.FSharpList<string> fsharpSongs = Client.clientActions.listPlaylist(playlistName);

                // Convierte FSharpList<string> en string[]
                string[] songs = fsharpSongs.ToArray();

                // Agregar las filas con los datos de las canciones
                foreach (string song in songs)
                {
                    dataGridView5.Rows.Add(song);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir, como lista de reproducción no encontrada o problemas de conexión
                MessageBox.Show("Error al cargar las canciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAñadirCancionLista_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelVerListas.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelEliminarCancion.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelAñadirCancion.Visible = true;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            string playlistName = textBox8.Text.Trim();
            string songName = textBox9.Text.Trim();

            dataGridView6.ReadOnly = true;
            dataGridView6.Rows.Clear();

            bool cancionAgregada = Client.clientActions.addToPlaylist(playlistName, songName);

            string command = $"listPlaylist {playlistName}";
            Microsoft.FSharp.Collections.FSharpList<string> playlistSongs = Client.clientActions.listPlaylist(playlistName);

            string[] songs = playlistSongs.ToArray();

            List<string> playlistNamesList = playlistSongs.ToList();

            foreach (string play in playlistSongs)
            {
                dataGridView6.Rows.Add(play);
            }


            if (cancionAgregada == true)
            {
                MessageBox.Show($"Canción '{songName}' añadida correctamente a '{playlistName}'.");
            }
            else
            {
                MessageBox.Show($"No se pudo agregar la canción '{songName}' a '{playlistName}'.");
            }


        }

        private void buttonVerCancionesListas_Click(object sender, EventArgs e)
        {
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelAñadirCancion.Visible = false;
            panelVerListas.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelEliminarCancion.Visible = false;
            panelVerCancionesListas.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string playlistName = textBox7.Text.Trim();

            string command = $"listPlaylist {playlistName}";

            Microsoft.FSharp.Collections.FSharpList<string> playlistSongs = Client.clientActions.listPlaylist(playlistName);

            dataGridView5.ReadOnly = true;
            dataGridView5.Rows.Clear();

            // Convierte FSharpList<string> en string[]
            string[] songs = playlistSongs.ToArray();

            foreach (string play in playlistSongs)
            {
                dataGridView5.Rows.Add(play);
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelVerListas.Visible = true;
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelAñadirCancion.Visible = false;
            panelEliminarCancion.Visible = false;

            dataGridView6.ReadOnly = true;
            dataGridView6.Rows.Clear();

            string command = "listAllPlaylists";
            Microsoft.FSharp.Collections.FSharpList<string> playlistNames = Client.clientActions.listAllPlaylists(command);

            List<string> playlistNamesList = playlistNames.ToList();

            //Agrega cada nombre de lista de reproducción al DataGridView6
            foreach (string playlistName in playlistNames)
            {
                dataGridView6.Rows.Add(playlistName);
            }
            //showFormPlaylists();
        }

        public Panel getPanelAddToPlaylist()
        {
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelAñadirCancion.Visible = false;
            panelVerListas.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelEliminarCancion.Visible = false;
            return panelAddToPlaylist;
        }


        public void setDataGridView()
        {
            string songName = getSongName();
            label12.Text = $"¿A cuál playlist deseas añadir la canción: {songName}?";
            dataGridView4.ReadOnly = true;
            dataGridView4.Rows.Clear();

            string command = "listAllPlaylists";
            Microsoft.FSharp.Collections.FSharpList<string> playlistNames = Client.clientActions.listAllPlaylists(command);

            List<string> playlistNamesList = playlistNames.ToList();

            // Agrega cada nombre de lista de reproducción al DataGridView6
            foreach (string playlistName in playlistNames)
            {
                dataGridView4.Rows.Add(playlistName);
            }

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView4.Rows[e.RowIndex];
                string playlistName = selectedRow.Cells[0].Value.ToString();


                string songName = getSongName();
                string comando = $"addToPlaylist {playlistName} {songName}";
                string resultadoCanciones = Client.clientActions.searchByCriteria(comando);

                bool cancionAgregada = Client.clientActions.addToPlaylist(playlistName, songName);

                //showSongs(nombreLista);
                panelVerListas.Visible = false;
                panelVerCancionesListas.Visible = true;

                if (cancionAgregada == true)
                {
                    MessageBox.Show($"Canción '{songName}' añadida correctamente a '{playlistName}'.");
                }
                else
                {
                    MessageBox.Show($"No se pudo agregar la canción '{songName}' a '{playlistName}'.");
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelVerListas.Visible = false;
            panelInicio.Visible = false;
            panelBuscarCriterio.Visible = false;
            panelBuscarDuracion.Visible = false;
            panelBuscarSimilitud.Visible = false;
            panelListas.Visible = false;
            panelCrearLista.Visible = false;
            panelVerCancionesListas.Visible = false;
            panelAddToPlaylist.Visible = false;
            panelAñadirCancion.Visible = false;
            panelEliminarCancion.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string playlistName = textBox10.Text.Trim();

            string command = $"listPlaylist {playlistName}";

            Microsoft.FSharp.Collections.FSharpList<string> playlistSongs = Client.clientActions.listPlaylist(playlistName);

            dataGridView7.ReadOnly = true;
            dataGridView7.Rows.Clear();

            // Convierte FSharpList<string> en string[]
            string[] songs = playlistSongs.ToArray();

            foreach (string play in playlistSongs)
            {
                dataGridView7.Rows.Add(play);
            }

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string playlistName = textBox10.Text.Trim();

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView7.Rows[e.RowIndex];
                string songName = selectedRow.Cells[0].Value.ToString();

                // Mostrar un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Seguro que desea eliminar la canción '{songName}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila si el usuario confirma
                    dataGridView7.Rows.RemoveAt(e.RowIndex);
                    Client.clientActions.removeFromPlaylist(playlistName, songName);
                }
                else
                {
                    // El usuario eligió no eliminar la canción, no hagas nada adicional.
                }

            }

        }
    }
}
