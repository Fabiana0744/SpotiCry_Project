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
    public partial class FormOpciones : Form
    {
        private Form2 form2Instance;

        public FormOpciones(Form2 form2)
        {
            InitializeComponent();
            form2Instance = form2;
            label1.Text = form2Instance.getSongMessage();
        }

        private void showFormPlaylists()
        {
            // FormPlaylists form = new FormPlaylists(this);
            //form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2Instance.showFormReproduccion();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Panel panel = form2Instance.getPanelAddToPlaylist();
            panel.Visible = true;
            form2Instance.setDataGridView();


        }

        private void FormOpciones_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
