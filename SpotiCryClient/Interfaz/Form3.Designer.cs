namespace Interfaz
{
    partial class formReproduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReproduccion));
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            buttonRetroceder = new Button();
            buttonPausar = new Button();
            buttonReproduccion = new Button();
            button4 = new Button();
            buttonReanudar = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            labelCancion = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 64);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(166, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 389);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(buttonRetroceder);
            panel4.Controls.Add(buttonPausar);
            panel4.Controls.Add(buttonReproduccion);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(buttonReanudar);
            panel4.Location = new Point(3, 294);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 92);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // buttonRetroceder
            // 
            buttonRetroceder.FlatStyle = FlatStyle.Flat;
            buttonRetroceder.ForeColor = Color.Teal;
            buttonRetroceder.Image = Properties.Resources.retroceder;
            buttonRetroceder.Location = new Point(3, 0);
            buttonRetroceder.Name = "buttonRetroceder";
            buttonRetroceder.Size = new Size(80, 80);
            buttonRetroceder.TabIndex = 2;
            buttonRetroceder.UseVisualStyleBackColor = true;
            buttonRetroceder.Click += buttonRetroceder_Click;
            // 
            // buttonPausar
            // 
            buttonPausar.FlatStyle = FlatStyle.Flat;
            buttonPausar.ForeColor = Color.Teal;
            buttonPausar.Image = Properties.Resources.pausa;
            buttonPausar.Location = new Point(89, 0);
            buttonPausar.Name = "buttonPausar";
            buttonPausar.Size = new Size(80, 80);
            buttonPausar.TabIndex = 3;
            buttonPausar.UseVisualStyleBackColor = true;
            buttonPausar.Click += buttonPausar_Click;
            // 
            // buttonReproduccion
            // 
            buttonReproduccion.FlatStyle = FlatStyle.Flat;
            buttonReproduccion.ForeColor = Color.Teal;
            buttonReproduccion.Image = Properties.Resources.repro;
            buttonReproduccion.Location = new Point(175, 0);
            buttonReproduccion.Name = "buttonReproduccion";
            buttonReproduccion.Size = new Size(80, 80);
            buttonReproduccion.TabIndex = 7;
            buttonReproduccion.UseVisualStyleBackColor = true;
            buttonReproduccion.Click += buttonReproduccion_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Teal;
            button4.Image = Properties.Resources.adelantar;
            button4.Location = new Point(347, -1);
            button4.Name = "button4";
            button4.Size = new Size(80, 80);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonReanudar
            // 
            buttonReanudar.FlatStyle = FlatStyle.Flat;
            buttonReanudar.ForeColor = Color.Teal;
            buttonReanudar.Image = Properties.Resources.play1;
            buttonReanudar.Location = new Point(261, 0);
            buttonReanudar.Name = "buttonReanudar";
            buttonReanudar.Size = new Size(80, 80);
            buttonReanudar.TabIndex = 4;
            buttonReanudar.UseVisualStyleBackColor = true;
            buttonReanudar.Click += buttonReanudar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(labelCancion);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 287);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 249);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelCancion
            // 
            labelCancion.AutoSize = true;
            labelCancion.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCancion.Location = new Point(16, 250);
            labelCancion.Name = "labelCancion";
            labelCancion.Size = new Size(70, 28);
            labelCancion.TabIndex = 1;
            labelCancion.Text = "label1";
            labelCancion.Click += label1_Click;
            // 
            // formReproduccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "formReproduccion";
            Text = "Form3";
            FormClosing += formReproduccion_FormClosing;
            Load += formReproduccion_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelCancion;
        private Button button4;
        private Button buttonReanudar;
        private Button buttonPausar;
        private Button buttonRetroceder;
        private Button buttonReproduccion;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
    }
}