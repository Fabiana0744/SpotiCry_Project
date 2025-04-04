using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class formReproduccion : Form
    {
        private Form2 form2Instance;
        public formReproduccion(Form2 form2)
        {
            InitializeComponent();
            form2Instance = form2;
            labelCancion.Text = form2Instance.getSongName();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPausar_Click(object sender, EventArgs e)
        {
            string command = "pause";
            Client.clientActions.pauseSong(command);
        }
        private void buttonReanudar_Click(object sender, EventArgs e)
        {
            String command = "resume";
            Client.clientActions.resumeSong(command);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReproduccion_Click(object sender, EventArgs e)
        {
            String songName = form2Instance.getSongName();

            // Construye la cadena de comando
            string comando = $"play {songName}";

            // Llamar a la función para reproducir la canción basada en el nombre

            Client.clientActions.playSongCommandServer(comando);

        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            String command = "backward";
            Client.clientActions.backwardSong(command);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            String command = "forward";
            Client.clientActions.forwardSong(command);
        }

        private void formReproduccion_Load(object sender, EventArgs e)
        {

        }

        private void formReproduccion_FormClosing(object sender, FormClosingEventArgs e)
        {

            Client.clientActions.stopSong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
