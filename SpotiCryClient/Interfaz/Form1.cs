
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Interfaz
{
    public partial class Form1 : Form
    {

        public Form1()

        {
            InitializeComponent();
            // Configura el ListView para mostrar detalles

            listView1.View = View.Details;
            listView1.Columns.Add("Nombre de la Canción", 200);
            listView1.Columns.Add("Artista", 150);
            listView1.Columns.Add("Género", 100);
            listView1.Columns.Add("Duración", 80);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelInicio.Visible = true;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buscarCancionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criterioToolStripMenuItem.Select();
        }

        private void listasReproduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Oculta todos los controles de otras secciones
            //panelListasReproduccion.Visible = false;
            PanelBusquedaNombre.Visible = false;

            // Muestra los controles de la sección de Inicio
            PanelInicio.Visible = true;
        }

        private void criterioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nombreToolStripMenuItem.Select();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBusquedaNombre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBusquedaDuracion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtén el texto ingresado por el usuario en el cuadro de búsqueda
            //string consulta = textBox1.Text.Trim();
            //string criterio = "name";
            //string terminoBusqueda = textBoxTerminoBusqueda.Text;

            // Construye la cadena de comando para la búsqueda
            //string comando = $"search {criterio} {consulta}";

            // Realiza la búsqueda de canciones por nombre, artista o género
            //List<Cancion> resultados = RealizarBusqueda(consulta);
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelInicio.Visible = false;

            PanelBusquedaNombre.Visible = true;
        }

        private void duracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelInicio.Visible = false;

            PanelBusquedaNombre.Visible = false;

            PanelBusquedaDuracion.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
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
                    string duracion = detalles[4];

                    dataGridView1.ReadOnly = true;
                    // Agrega una nueva fila al DataGridView con los datos de la canción
                    dataGridView1.Rows.Add(nombreCancion, artista, genero);

                    listView1.Items.Clear();
                    // Crea un nuevo elemento ListViewItem con los datos de la canción
                    ListViewItem item = new ListViewItem(nombreCancion);
                    item.SubItems.Add(artista);
                    item.SubItems.Add(genero);
                    item.SubItems.Add(duracion);
                    item.Tag = nombreCancion;
                    // Agrega el elemento ListViewItem al ListView
                    listView1.Items.Add(item);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Obtén el texto ingresado por el usuario en el cuadro de búsqueda
            string consulta = textBox2.Text.Trim();
            string criterio = "duration";
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
                    string duracion = detalles[4];

                    dataGridView2.ReadOnly = true;
                    // Agrega una nueva fila al DataGridView con los datos de la canción
                    dataGridView2.Rows.Add(nombreCancion, artista, genero, duracion);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.ItemSelectionChanged += (sender, e) =>
            {
                // Verificar si algún elemento está seleccionado
                if (listView1.SelectedItems.Count > 0)
                {
                    // Obtener el nombre de la canción del elemento seleccionado
                    string nombreCancion = listView1.SelectedItems[0].SubItems[0].Text;

                    // Construye la cadena de comando
                    string comando = $"play {nombreCancion}";

                    // Llamar a la función para reproducir la canción basada en el nombre
                    Client.clientActions.playSongCommandServer(comando);
                }

            };

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el índice de columna es válido (para evitar excepciones)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Accede a los datos de la fila seleccionada según las columnas
                string nombreCancion = selectedRow.Cells["colNombre"].Value.ToString();
                string artista = selectedRow.Cells["colArtista"].Value.ToString();
                string genero = selectedRow.Cells["colGenero"].Value.ToString();

                // Realiza la acción que deseas con los datos de la fila seleccionada
                // Por ejemplo, muestra los datos en un MessageBox
                MessageBox.Show($"Canción: {nombreCancion}, Artista: {artista}, Género: {genero}");

                // Construye la cadena de comando
                string comando = $"play {nombreCancion}";

                // Llamar a la función para reproducir la canción basada en el nombre
                Client.clientActions.playSongCommandServer(comando);
            }
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                string duracion = selectedRow.Cells["colDuracionDuracion"].Value.ToString();

                // Realiza la acción que deseas con los datos de la fila seleccionada
                // Por ejemplo, muestra los datos en un MessageBox
                MessageBox.Show($"Canción: {nombreCancion}, Artista: {artista}, Género: {genero}, Duracion: {duracion}");

                // Construye la cadena de comando
                string comando = $"play {nombreCancion}";

                // Llamar a la función para reproducir la canción basada en el nombre
                Client.clientActions.playSongCommandServer(comando);
            }

        }
    }
}