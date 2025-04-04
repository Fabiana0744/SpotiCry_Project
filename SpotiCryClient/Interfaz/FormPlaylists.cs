using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interfaz
{
    public partial class FormPlaylists : Form
    {
        private FormOpciones formOpcionesInstance;
        private Form2 form2Instance;

        public FormPlaylists(Form2 form2)
        {
            InitializeComponent();
            form2Instance = form2;
            //formOpcionesInstance.setDataGrid(dataGridListas);
            labelLista.Text = form2Instance.getSongMessage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client.clientActions.nextSong();
            string currentSong = Client.clientActions.getCurrentSongName();
            label2.Text = currentSong;
            
        }

        private void FormPlaylists_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string playlistName = form2Instance.getPlaylistName();
            bool cancionReproducida = Client.clientActions.playPlaylist(playlistName);
            
            if (cancionReproducida == true)
            {
                string currentSong = Client.clientActions.getCurrentSongName();
                label2.Text = currentSong;
            }
            else
            {
                MessageBox.Show($"No se pudo reproducir Playlist: '{playlistName}'. Playlist vacío");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string currentSong = Client.clientActions.getCurrentSongName();
            Client.clientActions.resumeSong(currentSong);
            label2.Text = currentSong;
            
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            Client.clientActions.prevSong();
            string currentSong = Client.clientActions.getCurrentSongName();
            label2.Text = currentSong;
            

        }

        private void buttonPausar_Click(object sender, EventArgs e)
        {
            string currentSong = Client.clientActions.getCurrentSongName();
            label2.Text = currentSong;
            Client.clientActions.pauseSong(currentSong);
        }
    }
}
