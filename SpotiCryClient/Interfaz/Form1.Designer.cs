using System;
using System.Windows.Forms;
using Client;

namespace Interfaz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            InicioMenuItem = new ToolStripMenuItem();
            BuscarMusicaMenuItem = new ToolStripMenuItem();
            criterioToolStripMenuItem = new ToolStripMenuItem();
            nombreToolStripMenuItem = new ToolStripMenuItem();
            generoToolStripMenuItem = new ToolStripMenuItem();
            artistaToolStripMenuItem = new ToolStripMenuItem();
            duracionToolStripMenuItem = new ToolStripMenuItem();
            similitudToolStripMenuItem = new ToolStripMenuItem();
            ListasReproduccionMenuItem = new ToolStripMenuItem();
            AcercaDeMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            PanelInicio = new Panel();
            label1 = new Label();
            PanelBusquedaNombre = new Panel();
            dataGridView1 = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colArtista = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            listView1 = new ListView();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            PanelBusquedaDuracion = new Panel();
            dataGridView2 = new DataGridView();
            colNombreDuracion = new DataGridViewTextBoxColumn();
            colArtistaDuracion = new DataGridViewTextBoxColumn();
            colGeneroDuracion = new DataGridViewTextBoxColumn();
            colDuracionDuracion = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            PanelInicio.SuspendLayout();
            PanelBusquedaNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            PanelBusquedaDuracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // InicioMenuItem
            // 
            InicioMenuItem.Name = "InicioMenuItem";
            InicioMenuItem.Size = new Size(59, 24);
            InicioMenuItem.Text = "Inicio";
            InicioMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // BuscarMusicaMenuItem
            // 
            BuscarMusicaMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criterioToolStripMenuItem, duracionToolStripMenuItem, similitudToolStripMenuItem });
            BuscarMusicaMenuItem.Name = "BuscarMusicaMenuItem";
            BuscarMusicaMenuItem.Size = new Size(116, 24);
            BuscarMusicaMenuItem.Text = "Buscar Musica";
            BuscarMusicaMenuItem.Click += buscarCancionToolStripMenuItem_Click;
            // 
            // criterioToolStripMenuItem
            // 
            criterioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nombreToolStripMenuItem, generoToolStripMenuItem, artistaToolStripMenuItem });
            criterioToolStripMenuItem.Name = "criterioToolStripMenuItem";
            criterioToolStripMenuItem.Size = new Size(152, 26);
            criterioToolStripMenuItem.Text = "Criterio";
            criterioToolStripMenuItem.Click += criterioToolStripMenuItem_Click;
            // 
            // nombreToolStripMenuItem
            // 
            nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            nombreToolStripMenuItem.Size = new Size(147, 26);
            nombreToolStripMenuItem.Text = "Nombre";
            nombreToolStripMenuItem.Click += nombreToolStripMenuItem_Click;
            // 
            // generoToolStripMenuItem
            // 
            generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            generoToolStripMenuItem.Size = new Size(147, 26);
            generoToolStripMenuItem.Text = "Genero";
            generoToolStripMenuItem.Click += generoToolStripMenuItem_Click;
            // 
            // artistaToolStripMenuItem
            // 
            artistaToolStripMenuItem.Name = "artistaToolStripMenuItem";
            artistaToolStripMenuItem.Size = new Size(147, 26);
            artistaToolStripMenuItem.Text = "Artista";
            // 
            // duracionToolStripMenuItem
            // 
            duracionToolStripMenuItem.Name = "duracionToolStripMenuItem";
            duracionToolStripMenuItem.Size = new Size(152, 26);
            duracionToolStripMenuItem.Text = "Duracion";
            duracionToolStripMenuItem.Click += duracionToolStripMenuItem_Click;
            // 
            // similitudToolStripMenuItem
            // 
            similitudToolStripMenuItem.Name = "similitudToolStripMenuItem";
            similitudToolStripMenuItem.Size = new Size(152, 26);
            similitudToolStripMenuItem.Text = "Similitud";
            // 
            // ListasReproduccionMenuItem
            // 
            ListasReproduccionMenuItem.Name = "ListasReproduccionMenuItem";
            ListasReproduccionMenuItem.Size = new Size(176, 24);
            ListasReproduccionMenuItem.Text = "Listas de Reproducción";
            ListasReproduccionMenuItem.Click += listasReproduccionToolStripMenuItem_Click;
            // 
            // AcercaDeMenuItem
            // 
            AcercaDeMenuItem.Name = "AcercaDeMenuItem";
            AcercaDeMenuItem.Size = new Size(89, 24);
            AcercaDeMenuItem.Text = "Acerca de";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { InicioMenuItem, BuscarMusicaMenuItem, ListasReproduccionMenuItem, AcercaDeMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // PanelInicio
            // 
            PanelInicio.BackColor = SystemColors.ActiveCaptionText;
            PanelInicio.Controls.Add(label1);
            PanelInicio.Location = new Point(0, 31);
            PanelInicio.Name = "PanelInicio";
            PanelInicio.Size = new Size(800, 419);
            PanelInicio.TabIndex = 2;
            PanelInicio.Visible = false;
            PanelInicio.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(158, 46);
            label1.TabIndex = 0;
            label1.Text = "SpotiCry";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // PanelBusquedaNombre
            // 
            PanelBusquedaNombre.BackColor = SystemColors.AppWorkspace;
            PanelBusquedaNombre.Controls.Add(dataGridView1);
            PanelBusquedaNombre.Controls.Add(listView1);
            PanelBusquedaNombre.Controls.Add(button1);
            PanelBusquedaNombre.Controls.Add(label2);
            PanelBusquedaNombre.Controls.Add(textBox1);
            PanelBusquedaNombre.Location = new Point(0, 31);
            PanelBusquedaNombre.Name = "PanelBusquedaNombre";
            PanelBusquedaNombre.Size = new Size(800, 419);
            PanelBusquedaNombre.TabIndex = 1;
            PanelBusquedaNombre.Visible = false;
            PanelBusquedaNombre.Paint += panelBusquedaNombre_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNombre, colArtista, colGenero });
            dataGridView1.Location = new Point(157, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(414, 139);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colNombre
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            colNombre.DefaultCellStyle = dataGridViewCellStyle1;
            colNombre.HeaderText = "Nombre de la Canción";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colArtista
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            colArtista.DefaultCellStyle = dataGridViewCellStyle2;
            colArtista.HeaderText = "Artista";
            colArtista.MinimumWidth = 6;
            colArtista.Name = "colArtista";
            colArtista.Width = 125;
            // 
            // colGenero
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            colGenero.DefaultCellStyle = dataGridViewCellStyle3;
            colGenero.HeaderText = "Genero";
            colGenero.MinimumWidth = 6;
            colGenero.Name = "colGenero";
            colGenero.Width = 125;
            // 
            // listView1
            // 
            listView1.Location = new Point(61, 235);
            listView1.Name = "listView1";
            listView1.Size = new Size(34, 94);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(322, 170);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 95);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 1;
            label2.Text = "Digite nombre de la canción:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // PanelBusquedaDuracion
            // 
            PanelBusquedaDuracion.BackColor = SystemColors.ActiveCaption;
            PanelBusquedaDuracion.Controls.Add(label4);
            PanelBusquedaDuracion.Controls.Add(dataGridView2);
            PanelBusquedaDuracion.Controls.Add(textBox2);
            PanelBusquedaDuracion.Controls.Add(label3);
            PanelBusquedaDuracion.Controls.Add(button2);
            PanelBusquedaDuracion.Location = new Point(0, 31);
            PanelBusquedaDuracion.Name = "PanelBusquedaDuracion";
            PanelBusquedaDuracion.Size = new Size(800, 419);
            PanelBusquedaDuracion.TabIndex = 6;
            PanelBusquedaDuracion.Visible = false;
            PanelBusquedaDuracion.Paint += panel1_Paint_2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colNombreDuracion, colArtistaDuracion, colGeneroDuracion, colDuracionDuracion });
            dataGridView2.Location = new Point(117, 196);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(553, 124);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // colNombreDuracion
            // 
            colNombreDuracion.HeaderText = "Nombre";
            colNombreDuracion.MinimumWidth = 6;
            colNombreDuracion.Name = "colNombreDuracion";
            colNombreDuracion.Width = 125;
            // 
            // colArtistaDuracion
            // 
            colArtistaDuracion.HeaderText = "Artista";
            colArtistaDuracion.MinimumWidth = 6;
            colArtistaDuracion.Name = "colArtistaDuracion";
            colArtistaDuracion.Width = 125;
            // 
            // colGeneroDuracion
            // 
            colGeneroDuracion.HeaderText = "Genero";
            colGeneroDuracion.MinimumWidth = 6;
            colGeneroDuracion.Name = "colGeneroDuracion";
            colGeneroDuracion.Width = 125;
            // 
            // colDuracionDuracion
            // 
            colDuracionDuracion.HeaderText = "Duracion";
            colDuracionDuracion.MinimumWidth = 6;
            colDuracionDuracion.Name = "colDuracionDuracion";
            colDuracionDuracion.Width = 125;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 26);
            label3.Name = "label3";
            label3.Size = new Size(222, 20);
            label3.TabIndex = 1;
            label3.Text = "Digite la duracion (en minutos): ";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(322, 86);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 335);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelBusquedaDuracion);
            Controls.Add(menuStrip1);
            Controls.Add(PanelBusquedaNombre);
            Controls.Add(PanelInicio);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            PanelInicio.ResumeLayout(false);
            PanelInicio.PerformLayout();
            PanelBusquedaNombre.ResumeLayout(false);
            PanelBusquedaNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            PanelBusquedaDuracion.ResumeLayout(false);
            PanelBusquedaDuracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private ToolStripMenuItem InicioMenuItem;
        private ToolStripMenuItem BuscarMusicaMenuItem;
        private ToolStripMenuItem criterioToolStripMenuItem;
        private ToolStripMenuItem duracionToolStripMenuItem;
        private ToolStripMenuItem similitudToolStripMenuItem;
        private ToolStripMenuItem ListasReproduccionMenuItem;
        private ToolStripMenuItem AcercaDeMenuItem;
        private MenuStrip menuStrip1;
        private Panel PanelInicio;
        private Label label1;
        private ToolStripMenuItem nombreToolStripMenuItem;
        private ToolStripMenuItem generoToolStripMenuItem;
        private ToolStripMenuItem artistaToolStripMenuItem;
        private Panel PanelBusquedaNombre;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private ListView listView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colArtista;
        private DataGridViewTextBoxColumn colGenero;
        private Panel PanelBusquedaDuracion;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colNombreDuracion;
        private DataGridViewTextBoxColumn colArtistaDuracion;
        private DataGridViewTextBoxColumn colGeneroDuracion;
        private DataGridViewTextBoxColumn colDuracionDuracion;
        private Label label4;
    }
}
