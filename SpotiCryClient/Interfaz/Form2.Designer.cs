namespace Interfaz
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            buttonAyuda = new Button();
            buttonListas = new Button();
            panelBuscar = new Panel();
            buttonSimilitud = new Button();
            buttonDuracion = new Button();
            buttonCriterio = new Button();
            buttonBuscar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panelInicio = new Panel();
            pictureBox1 = new PictureBox();
            panelBuscarCriterio = new Panel();
            label13 = new Label();
            button5 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            colNombreCriterio = new DataGridViewTextBoxColumn();
            colArtistaCriterio = new DataGridViewTextBoxColumn();
            colGeneroCriterio = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panelBuscarDuracion = new Panel();
            label15 = new Label();
            dataGridView2 = new DataGridView();
            colNombreDuracion = new DataGridViewTextBoxColumn();
            colArtistaDuracion = new DataGridViewTextBoxColumn();
            colGeneroDuracion = new DataGridViewTextBoxColumn();
            colDuracionDuracion = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            button2 = new Button();
            label3 = new Label();
            panelBuscarSimilitud = new Panel();
            label14 = new Label();
            dataGridView3 = new DataGridView();
            colNombreSimilitud = new DataGridViewTextBoxColumn();
            colArtistaSimilitud = new DataGridViewTextBoxColumn();
            colGeneroSimilitud = new DataGridViewTextBoxColumn();
            colDuracionSimilitud = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            panelListas = new Panel();
            button10 = new Button();
            button9 = new Button();
            buttonAñadirCancionLista = new Button();
            buttonVerCancionesListas = new Button();
            buttonVerListas = new Button();
            buttonCrearListas = new Button();
            panelCrearLista = new Panel();
            button6 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            panelVerListas = new Panel();
            label16 = new Label();
            dataGridView6 = new DataGridView();
            colNombreListasRepro = new DataGridViewTextBoxColumn();
            label8 = new Label();
            panelVerCancionesListas = new Panel();
            dataGridView5 = new DataGridView();
            colNombreCanciones = new DataGridViewTextBoxColumn();
            button7 = new Button();
            textBox7 = new TextBox();
            label9 = new Label();
            panelAñadirCancion = new Panel();
            button8 = new Button();
            label11 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label10 = new Label();
            panelAddToPlaylist = new Panel();
            label12 = new Label();
            dataGridView4 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            panelEliminarCancion = new Panel();
            dataGridView7 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            label18 = new Label();
            textBox10 = new TextBox();
            button11 = new Button();
            label17 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelBuscar.SuspendLayout();
            panel2.SuspendLayout();
            panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBuscarCriterio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelBuscarDuracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelBuscarSimilitud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panelListas.SuspendLayout();
            panelCrearLista.SuspendLayout();
            panelVerListas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            panelVerCancionesListas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            panelAñadirCancion.SuspendLayout();
            panelAddToPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panelEliminarCancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 64);
            panel3.Controls.Add(buttonAyuda);
            panel3.Controls.Add(buttonListas);
            panel3.Controls.Add(panelBuscar);
            panel3.Controls.Add(buttonBuscar);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 369);
            panel3.TabIndex = 1;
            // 
            // buttonAyuda
            // 
            buttonAyuda.Dock = DockStyle.Top;
            buttonAyuda.FlatStyle = FlatStyle.Flat;
            buttonAyuda.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAyuda.ForeColor = SystemColors.ButtonHighlight;
            buttonAyuda.Location = new Point(0, 151);
            buttonAyuda.Name = "buttonAyuda";
            buttonAyuda.Size = new Size(188, 29);
            buttonAyuda.TabIndex = 2;
            buttonAyuda.Text = "Ayuda";
            buttonAyuda.UseVisualStyleBackColor = true;
            buttonAyuda.Click += buttonAyuda_Click;
            // 
            // buttonListas
            // 
            buttonListas.Dock = DockStyle.Top;
            buttonListas.FlatStyle = FlatStyle.Flat;
            buttonListas.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListas.ForeColor = SystemColors.ButtonHighlight;
            buttonListas.Location = new Point(0, 119);
            buttonListas.Name = "buttonListas";
            buttonListas.Size = new Size(188, 32);
            buttonListas.TabIndex = 1;
            buttonListas.Text = "Playlists";
            buttonListas.UseVisualStyleBackColor = true;
            buttonListas.Click += buttonListas_Click;
            // 
            // panelBuscar
            // 
            panelBuscar.Controls.Add(buttonSimilitud);
            panelBuscar.Controls.Add(buttonDuracion);
            panelBuscar.Controls.Add(buttonCriterio);
            panelBuscar.Dock = DockStyle.Top;
            panelBuscar.Location = new Point(0, 32);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(188, 87);
            panelBuscar.TabIndex = 1;
            // 
            // buttonSimilitud
            // 
            buttonSimilitud.Dock = DockStyle.Top;
            buttonSimilitud.FlatStyle = FlatStyle.Flat;
            buttonSimilitud.ForeColor = SystemColors.ButtonHighlight;
            buttonSimilitud.Location = new Point(0, 58);
            buttonSimilitud.Name = "buttonSimilitud";
            buttonSimilitud.Size = new Size(188, 29);
            buttonSimilitud.TabIndex = 2;
            buttonSimilitud.Text = "Similitud";
            buttonSimilitud.UseVisualStyleBackColor = true;
            buttonSimilitud.Click += buttonSimilitud_Click;
            // 
            // buttonDuracion
            // 
            buttonDuracion.Dock = DockStyle.Top;
            buttonDuracion.FlatStyle = FlatStyle.Flat;
            buttonDuracion.ForeColor = SystemColors.ButtonHighlight;
            buttonDuracion.Location = new Point(0, 29);
            buttonDuracion.Name = "buttonDuracion";
            buttonDuracion.Size = new Size(188, 29);
            buttonDuracion.TabIndex = 1;
            buttonDuracion.Text = "Duración";
            buttonDuracion.UseVisualStyleBackColor = true;
            buttonDuracion.Click += buttonDuracion_Click;
            // 
            // buttonCriterio
            // 
            buttonCriterio.Dock = DockStyle.Top;
            buttonCriterio.FlatStyle = FlatStyle.Flat;
            buttonCriterio.ForeColor = SystemColors.ButtonHighlight;
            buttonCriterio.Location = new Point(0, 0);
            buttonCriterio.Name = "buttonCriterio";
            buttonCriterio.Size = new Size(188, 29);
            buttonCriterio.TabIndex = 0;
            buttonCriterio.Text = "Criterio";
            buttonCriterio.UseVisualStyleBackColor = true;
            buttonCriterio.Click += buttonCriterio_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Dock = DockStyle.Top;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBuscar.ForeColor = SystemColors.ButtonHighlight;
            buttonBuscar.Location = new Point(0, 0);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(188, 32);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 64);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 81);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(125, 29);
            label1.TabIndex = 0;
            label1.Text = "SpotiCry";
            // 
            // panelInicio
            // 
            panelInicio.BackColor = Color.Teal;
            panelInicio.Controls.Add(pictureBox1);
            panelInicio.Location = new Point(187, 0);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(613, 450);
            panelInicio.TabIndex = 1;
            panelInicio.Paint += panelReproduccion_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.musica2;
            pictureBox1.Location = new Point(187, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 205);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelBuscarCriterio
            // 
            panelBuscarCriterio.BackColor = Color.Teal;
            panelBuscarCriterio.Controls.Add(label13);
            panelBuscarCriterio.Controls.Add(button5);
            panelBuscarCriterio.Controls.Add(textBox5);
            panelBuscarCriterio.Controls.Add(label6);
            panelBuscarCriterio.Controls.Add(button4);
            panelBuscarCriterio.Controls.Add(textBox4);
            panelBuscarCriterio.Controls.Add(label5);
            panelBuscarCriterio.Controls.Add(dataGridView1);
            panelBuscarCriterio.Controls.Add(button1);
            panelBuscarCriterio.Controls.Add(textBox1);
            panelBuscarCriterio.Controls.Add(label2);
            panelBuscarCriterio.Location = new Point(187, 0);
            panelBuscarCriterio.Name = "panelBuscarCriterio";
            panelBuscarCriterio.Size = new Size(623, 450);
            panelBuscarCriterio.TabIndex = 1;
            panelBuscarCriterio.Paint += panelBuscarCriterio_Paint;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(111, 404);
            label13.Name = "label13";
            label13.Size = new Size(399, 20);
            label13.TabIndex = 10;
            label13.Text = "Sugerencia: Darle clic a una canción para ver más opciones";
            // 
            // button5
            // 
            button5.Location = new Point(244, 196);
            button5.Name = "button5";
            button5.Size = new Size(118, 30);
            button5.TabIndex = 9;
            button5.Text = "Buscar Género";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 27);
            textBox5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(233, 133);
            label6.Name = "label6";
            label6.Size = new Size(145, 23);
            label6.TabIndex = 7;
            label6.Text = "Digite el género:";
            // 
            // button4
            // 
            button4.Location = new Point(404, 91);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 6;
            button4.Text = "Buscar Artista";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(333, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 27);
            textBox4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(333, 20);
            label5.Name = "label5";
            label5.Size = new Size(238, 23);
            label5.TabIndex = 4;
            label5.Text = "Digite el nombre del artista:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNombreCriterio, colArtistaCriterio, colGeneroCriterio });
            dataGridView1.Location = new Point(90, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(429, 156);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colNombreCriterio
            // 
            colNombreCriterio.HeaderText = "Nombre";
            colNombreCriterio.MinimumWidth = 6;
            colNombreCriterio.Name = "colNombreCriterio";
            colNombreCriterio.Width = 125;
            // 
            // colArtistaCriterio
            // 
            colArtistaCriterio.HeaderText = "Artista";
            colArtistaCriterio.MinimumWidth = 6;
            colArtistaCriterio.Name = "colArtistaCriterio";
            colArtistaCriterio.Width = 125;
            // 
            // colGeneroCriterio
            // 
            colGeneroCriterio.HeaderText = "Genero";
            colGeneroCriterio.MinimumWidth = 6;
            colGeneroCriterio.Name = "colGeneroCriterio";
            colGeneroCriterio.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(86, 91);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar Canción";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(261, 23);
            label2.TabIndex = 0;
            label2.Text = "Digite el nombre de la cancion:";
            // 
            // panelBuscarDuracion
            // 
            panelBuscarDuracion.BackColor = Color.Teal;
            panelBuscarDuracion.Controls.Add(label15);
            panelBuscarDuracion.Controls.Add(dataGridView2);
            panelBuscarDuracion.Controls.Add(textBox2);
            panelBuscarDuracion.Controls.Add(button2);
            panelBuscarDuracion.Controls.Add(label3);
            panelBuscarDuracion.Location = new Point(187, -3);
            panelBuscarDuracion.Name = "panelBuscarDuracion";
            panelBuscarDuracion.Size = new Size(613, 453);
            panelBuscarDuracion.TabIndex = 2;
            panelBuscarDuracion.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(102, 404);
            label15.Name = "label15";
            label15.Size = new Size(399, 20);
            label15.TabIndex = 4;
            label15.Text = "Sugerencia: Darle clic a una canción para ver más opciones";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { colNombreDuracion, colArtistaDuracion, colGeneroDuracion, colDuracionDuracion });
            dataGridView2.Location = new Point(90, 210);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(425, 188);
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
            colGeneroDuracion.HeaderText = "Género";
            colGeneroDuracion.MinimumWidth = 6;
            colGeneroDuracion.Name = "colGeneroDuracion";
            colGeneroDuracion.Width = 125;
            // 
            // colDuracionDuracion
            // 
            colDuracionDuracion.HeaderText = "Duración";
            colDuracionDuracion.MinimumWidth = 6;
            colDuracionDuracion.Name = "colDuracionDuracion";
            colDuracionDuracion.Width = 125;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 27);
            textBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(244, 146);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(131, 42);
            label3.Name = "label3";
            label3.Size = new Size(334, 23);
            label3.TabIndex = 0;
            label3.Text = "Digite la duración máxima (en minutos):";
            label3.Click += label3_Click;
            // 
            // panelBuscarSimilitud
            // 
            panelBuscarSimilitud.BackColor = Color.Teal;
            panelBuscarSimilitud.Controls.Add(label14);
            panelBuscarSimilitud.Controls.Add(dataGridView3);
            panelBuscarSimilitud.Controls.Add(textBox3);
            panelBuscarSimilitud.Controls.Add(button3);
            panelBuscarSimilitud.Controls.Add(label4);
            panelBuscarSimilitud.Location = new Point(187, -3);
            panelBuscarSimilitud.Name = "panelBuscarSimilitud";
            panelBuscarSimilitud.Size = new Size(613, 453);
            panelBuscarSimilitud.TabIndex = 3;
            panelBuscarSimilitud.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(111, 392);
            label14.Name = "label14";
            label14.Size = new Size(399, 20);
            label14.TabIndex = 4;
            label14.Text = "Sugerencia: Darle clic a una canción para ver más opciones";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { colNombreSimilitud, colArtistaSimilitud, colGeneroSimilitud, colDuracionSimilitud });
            dataGridView3.Location = new Point(27, 199);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(555, 188);
            dataGridView3.TabIndex = 3;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // colNombreSimilitud
            // 
            colNombreSimilitud.HeaderText = "Nombre";
            colNombreSimilitud.MinimumWidth = 6;
            colNombreSimilitud.Name = "colNombreSimilitud";
            colNombreSimilitud.Width = 125;
            // 
            // colArtistaSimilitud
            // 
            colArtistaSimilitud.HeaderText = "Artista";
            colArtistaSimilitud.MinimumWidth = 6;
            colArtistaSimilitud.Name = "colArtistaSimilitud";
            colArtistaSimilitud.Width = 125;
            // 
            // colGeneroSimilitud
            // 
            colGeneroSimilitud.HeaderText = "Genero";
            colGeneroSimilitud.MinimumWidth = 6;
            colGeneroSimilitud.Name = "colGeneroSimilitud";
            colGeneroSimilitud.Width = 125;
            // 
            // colDuracionSimilitud
            // 
            colDuracionSimilitud.HeaderText = "Duración";
            colDuracionSimilitud.MinimumWidth = 6;
            colDuracionSimilitud.Name = "colDuracionSimilitud";
            colDuracionSimilitud.Width = 125;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 27);
            textBox3.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(253, 136);
            button3.Name = "button3";
            button3.Size = new Size(125, 32);
            button3.TabIndex = 1;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(187, 61);
            label4.Name = "label4";
            label4.Size = new Size(256, 23);
            label4.TabIndex = 0;
            label4.Text = "Digite el nombre de la canción";
            // 
            // panelListas
            // 
            panelListas.BackColor = Color.Teal;
            panelListas.Controls.Add(button10);
            panelListas.Controls.Add(button9);
            panelListas.Controls.Add(buttonAñadirCancionLista);
            panelListas.Controls.Add(buttonVerCancionesListas);
            panelListas.Controls.Add(buttonVerListas);
            panelListas.Controls.Add(buttonCrearListas);
            panelListas.Location = new Point(187, -3);
            panelListas.Name = "panelListas";
            panelListas.Size = new Size(613, 453);
            panelListas.TabIndex = 4;
            panelListas.Visible = false;
            // 
            // button10
            // 
            button10.Location = new Point(199, 372);
            button10.Name = "button10";
            button10.Size = new Size(210, 61);
            button10.TabIndex = 5;
            button10.Text = "Eliminar Canción de Lista";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(199, 301);
            button9.Name = "button9";
            button9.Size = new Size(210, 61);
            button9.TabIndex = 4;
            button9.Text = "Reproducir Lista";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonAñadirCancionLista
            // 
            buttonAñadirCancionLista.Location = new Point(199, 232);
            buttonAñadirCancionLista.Name = "buttonAñadirCancionLista";
            buttonAñadirCancionLista.Size = new Size(210, 61);
            buttonAñadirCancionLista.TabIndex = 3;
            buttonAñadirCancionLista.Text = "Añadir Canción a Lista";
            buttonAñadirCancionLista.UseVisualStyleBackColor = true;
            buttonAñadirCancionLista.Click += buttonAñadirCancionLista_Click;
            // 
            // buttonVerCancionesListas
            // 
            buttonVerCancionesListas.Location = new Point(199, 158);
            buttonVerCancionesListas.Name = "buttonVerCancionesListas";
            buttonVerCancionesListas.Size = new Size(210, 61);
            buttonVerCancionesListas.TabIndex = 2;
            buttonVerCancionesListas.Text = "Ver Canciones de Lista de Reproducción";
            buttonVerCancionesListas.UseVisualStyleBackColor = true;
            buttonVerCancionesListas.Click += buttonVerCancionesListas_Click;
            // 
            // buttonVerListas
            // 
            buttonVerListas.Location = new Point(199, 84);
            buttonVerListas.Name = "buttonVerListas";
            buttonVerListas.Size = new Size(210, 61);
            buttonVerListas.TabIndex = 1;
            buttonVerListas.Text = "Ver Listas de Reproducción";
            buttonVerListas.UseVisualStyleBackColor = true;
            buttonVerListas.Click += buttonVerListas_Click;
            // 
            // buttonCrearListas
            // 
            buttonCrearListas.BackColor = Color.White;
            buttonCrearListas.ForeColor = Color.Black;
            buttonCrearListas.Location = new Point(199, 13);
            buttonCrearListas.Name = "buttonCrearListas";
            buttonCrearListas.Size = new Size(210, 61);
            buttonCrearListas.TabIndex = 0;
            buttonCrearListas.Text = "Crear Lista de Reproducción";
            buttonCrearListas.UseVisualStyleBackColor = false;
            buttonCrearListas.Click += buttonCrearListas_Click;
            // 
            // panelCrearLista
            // 
            panelCrearLista.BackColor = Color.Teal;
            panelCrearLista.Controls.Add(button6);
            panelCrearLista.Controls.Add(textBox6);
            panelCrearLista.Controls.Add(label7);
            panelCrearLista.Location = new Point(187, -3);
            panelCrearLista.Name = "panelCrearLista";
            panelCrearLista.Size = new Size(613, 453);
            panelCrearLista.TabIndex = 5;
            panelCrearLista.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(244, 248);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 2;
            button6.Text = "Crear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(164, 181);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(267, 27);
            textBox6.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(77, 127);
            label7.Name = "label7";
            label7.Size = new Size(458, 25);
            label7.TabIndex = 0;
            label7.Text = "Ingrese el nombre de la nueva lista de reproducción:";
            // 
            // panelVerListas
            // 
            panelVerListas.BackColor = Color.Teal;
            panelVerListas.Controls.Add(label16);
            panelVerListas.Controls.Add(dataGridView6);
            panelVerListas.Controls.Add(label8);
            panelVerListas.Location = new Point(187, -3);
            panelVerListas.Name = "panelVerListas";
            panelVerListas.Size = new Size(613, 453);
            panelVerListas.TabIndex = 6;
            panelVerListas.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(115, 348);
            label16.Name = "label16";
            label16.Size = new Size(350, 20);
            label16.TabIndex = 3;
            label16.Text = "Sugerencia: Dar clic en un playlist para reproducirlo";
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Columns.AddRange(new DataGridViewColumn[] { colNombreListasRepro });
            dataGridView6.Location = new Point(138, 102);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.RowTemplate.Height = 29;
            dataGridView6.Size = new Size(305, 219);
            dataGridView6.TabIndex = 2;
            dataGridView6.CellContentClick += dataGridView6_CellContentClick;
            // 
            // colNombreListasRepro
            // 
            colNombreListasRepro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreListasRepro.HeaderText = "Nombre Lista de Reproduccion";
            colNombreListasRepro.MinimumWidth = 6;
            colNombreListasRepro.Name = "colNombreListasRepro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(111, 46);
            label8.Name = "label8";
            label8.Size = new Size(363, 28);
            label8.TabIndex = 0;
            label8.Text = "Estas son tus Listas de Reproducción:";
            // 
            // panelVerCancionesListas
            // 
            panelVerCancionesListas.BackColor = Color.Teal;
            panelVerCancionesListas.Controls.Add(dataGridView5);
            panelVerCancionesListas.Controls.Add(button7);
            panelVerCancionesListas.Controls.Add(textBox7);
            panelVerCancionesListas.Controls.Add(label9);
            panelVerCancionesListas.Location = new Point(187, -3);
            panelVerCancionesListas.Name = "panelVerCancionesListas";
            panelVerCancionesListas.Size = new Size(613, 453);
            panelVerCancionesListas.TabIndex = 7;
            panelVerCancionesListas.Visible = false;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { colNombreCanciones });
            dataGridView5.Location = new Point(143, 214);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.RowTemplate.Height = 29;
            dataGridView5.Size = new Size(300, 188);
            dataGridView5.TabIndex = 3;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
            // 
            // colNombreCanciones
            // 
            colNombreCanciones.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombreCanciones.HeaderText = "Nombre";
            colNombreCanciones.MinimumWidth = 6;
            colNombreCanciones.Name = "colNombreCanciones";
            // 
            // button7
            // 
            button7.Location = new Point(229, 151);
            button7.Name = "button7";
            button7.Size = new Size(149, 42);
            button7.TabIndex = 2;
            button7.Text = "Ver Canciones";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(181, 109);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(228, 27);
            textBox7.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(164, 61);
            label9.Name = "label9";
            label9.Size = new Size(256, 25);
            label9.TabIndex = 0;
            label9.Text = "Digite el nombre del playlist:";
            label9.Click += label9_Click;
            // 
            // panelAñadirCancion
            // 
            panelAñadirCancion.BackColor = Color.Teal;
            panelAñadirCancion.Controls.Add(button8);
            panelAñadirCancion.Controls.Add(label11);
            panelAñadirCancion.Controls.Add(textBox9);
            panelAñadirCancion.Controls.Add(textBox8);
            panelAñadirCancion.Controls.Add(label10);
            panelAñadirCancion.Location = new Point(187, -3);
            panelAñadirCancion.Name = "panelAñadirCancion";
            panelAñadirCancion.Size = new Size(620, 453);
            panelAñadirCancion.TabIndex = 8;
            panelAñadirCancion.Visible = false;
            // 
            // button8
            // 
            button8.Location = new Point(253, 251);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 4;
            button8.Text = "Agregar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(320, 111);
            label11.Name = "label11";
            label11.Size = new Size(281, 25);
            label11.TabIndex = 3;
            label11.Text = "Digite el nombre de la cancion: ";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(366, 152);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(205, 27);
            textBox9.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(42, 151);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(205, 27);
            textBox8.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(27, 111);
            label10.Name = "label10";
            label10.Size = new Size(245, 25);
            label10.TabIndex = 0;
            label10.Text = "Digite el nombre de la lista:";
            // 
            // panelAddToPlaylist
            // 
            panelAddToPlaylist.BackColor = Color.Teal;
            panelAddToPlaylist.Controls.Add(label12);
            panelAddToPlaylist.Controls.Add(dataGridView4);
            panelAddToPlaylist.Location = new Point(187, -3);
            panelAddToPlaylist.Name = "panelAddToPlaylist";
            panelAddToPlaylist.Size = new Size(617, 462);
            panelAddToPlaylist.TabIndex = 9;
            panelAddToPlaylist.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(134, 47);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 1;
            label12.Text = "label12";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView4.Location = new Point(123, 102);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(342, 193);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nombre Listas de Reproducción";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // panelEliminarCancion
            // 
            panelEliminarCancion.BackColor = Color.Teal;
            panelEliminarCancion.Controls.Add(dataGridView7);
            panelEliminarCancion.Controls.Add(label18);
            panelEliminarCancion.Controls.Add(textBox10);
            panelEliminarCancion.Controls.Add(button11);
            panelEliminarCancion.Controls.Add(label17);
            panelEliminarCancion.Location = new Point(187, 0);
            panelEliminarCancion.Name = "panelEliminarCancion";
            panelEliminarCancion.Size = new Size(613, 450);
            panelEliminarCancion.TabIndex = 10;
            panelEliminarCancion.Visible = false;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Columns.AddRange(new DataGridViewColumn[] { Column2 });
            dataGridView7.Location = new Point(163, 211);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.RowTemplate.Height = 29;
            dataGridView7.Size = new Size(300, 188);
            dataGridView7.TabIndex = 4;
            dataGridView7.CellContentClick += dataGridView7_CellContentClick;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nombre Canciones de Lista";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(131, 175);
            label18.Name = "label18";
            label18.Size = new Size(339, 23);
            label18.TabIndex = 3;
            label18.Text = "Seleccione la canción que desea eliminar:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(163, 87);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(280, 27);
            textBox10.TabIndex = 2;
            // 
            // button11
            // 
            button11.Location = new Point(253, 131);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 1;
            button11.Text = "Buscar Lista";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(111, 54);
            label17.Name = "label17";
            label17.Size = new Size(374, 23);
            label17.TabIndex = 0;
            label17.Text = "Digite el nombre de la Lista de reproducción:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelEliminarCancion);
            Controls.Add(panel1);
            Controls.Add(panelListas);
            Controls.Add(panelBuscarCriterio);
            Controls.Add(panelInicio);
            Controls.Add(panelBuscarSimilitud);
            Controls.Add(panelAddToPlaylist);
            Controls.Add(panelBuscarDuracion);
            Controls.Add(panelVerCancionesListas);
            Controls.Add(panelCrearLista);
            Controls.Add(panelVerListas);
            Controls.Add(panelAñadirCancion);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelBuscar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBuscarCriterio.ResumeLayout(false);
            panelBuscarCriterio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelBuscarDuracion.ResumeLayout(false);
            panelBuscarDuracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelBuscarSimilitud.ResumeLayout(false);
            panelBuscarSimilitud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panelListas.ResumeLayout(false);
            panelCrearLista.ResumeLayout(false);
            panelCrearLista.PerformLayout();
            panelVerListas.ResumeLayout(false);
            panelVerListas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            panelVerCancionesListas.ResumeLayout(false);
            panelVerCancionesListas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            panelAñadirCancion.ResumeLayout(false);
            panelAñadirCancion.PerformLayout();
            panelAddToPlaylist.ResumeLayout(false);
            panelAddToPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panelEliminarCancion.ResumeLayout(false);
            panelEliminarCancion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panelBuscar;
        private Button buttonSimilitud;
        private Button buttonDuracion;
        private Button buttonCriterio;
        private Button buttonBuscar;
        private Button buttonListas;
        private Button buttonAyuda;
        private Label label1;
        private Panel panelInicio;
        private PictureBox pictureBox1;
        private Panel panelVerListas;
        private Panel panelBuscarCriterio;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Panel panelBuscarDuracion;
        private Label label3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn colNombreDuracion;
        private DataGridViewTextBoxColumn colArtistaDuracion;
        private DataGridViewTextBoxColumn colGeneroDuracion;
        private DataGridViewTextBoxColumn colDuracionDuracion;
        private TextBox textBox2;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colNombreNombre;
        private DataGridViewTextBoxColumn colArtistaNombre;
        private DataGridViewTextBoxColumn colGeneroNombre;
        private Panel panelBuscarSimilitud;
        private DataGridView dataGridView3;
        private TextBox textBox3;
        private Button button3;
        private Label label4;
        private DataGridViewTextBoxColumn colNombreSimilitud;
        private DataGridViewTextBoxColumn colArtistaSimilitud;
        private DataGridViewTextBoxColumn colGeneroSimilitud;
        private DataGridViewTextBoxColumn colDuracionSimilitud;
        private Button button4;
        private TextBox textBox4;
        private Label label5;
        private Button button5;
        private TextBox textBox5;
        private Label label6;
        private Panel panelListas;
        private Button buttonVerCancionesListas;
        private Button buttonVerListas;
        private Button buttonCrearListas;
        private Panel panelCrearLista;
        private Button button6;
        private TextBox textBox6;
        private Label label7;
        private DataGridViewTextBoxColumn colNombreCriterio;
        private DataGridViewTextBoxColumn colArtistaCriterio;
        private DataGridViewTextBoxColumn colGeneroCriterio;
        private Label label8;
        private Panel panelVerCancionesListas;
        private DataGridView dataGridView5;
        private Button button7;
        private TextBox textBox7;
        private Label label9;
        private DataGridView dataGridView6;
        private Button buttonAñadirCancionLista;
        private Panel panelAñadirCancion;
        private Label label11;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label10;
        private Button button8;
        private DataGridViewTextBoxColumn colNombreCanciones;
        private Button button9;
        private Panel panelAddToPlaylist;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Column1;
        private Label label12;
        private DataGridViewTextBoxColumn colNombreListasRepro;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button10;
        private Panel panelEliminarCancion;
        private Button button11;
        private Label label17;
        private DataGridView dataGridView7;
        private Label label18;
        private TextBox textBox10;
        private DataGridViewTextBoxColumn Column2;
    }
}