namespace Interfaz
{
    partial class FormPlaylists
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
            buttonAnterior = new Button();
            buttonPausar = new Button();
            buttonSeguir = new Button();
            buttonSiguiente = new Button();
            button5 = new Button();
            labelLista = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonAnterior
            // 
            buttonAnterior.FlatStyle = FlatStyle.Flat;
            buttonAnterior.ForeColor = Color.Teal;
            buttonAnterior.Image = Properties.Resources.retroceder;
            buttonAnterior.Location = new Point(168, 327);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new Size(80, 80);
            buttonAnterior.TabIndex = 0;
            buttonAnterior.UseVisualStyleBackColor = true;
            buttonAnterior.Click += buttonAnterior_Click;
            // 
            // buttonPausar
            // 
            buttonPausar.FlatStyle = FlatStyle.Flat;
            buttonPausar.ForeColor = Color.Teal;
            buttonPausar.Image = Properties.Resources.pausa;
            buttonPausar.Location = new Point(265, 327);
            buttonPausar.Name = "buttonPausar";
            buttonPausar.Size = new Size(80, 80);
            buttonPausar.TabIndex = 1;
            buttonPausar.UseVisualStyleBackColor = true;
            buttonPausar.Click += buttonPausar_Click;
            // 
            // buttonSeguir
            // 
            buttonSeguir.FlatStyle = FlatStyle.Flat;
            buttonSeguir.ForeColor = Color.Teal;
            buttonSeguir.Image = Properties.Resources.play1;
            buttonSeguir.Location = new Point(463, 327);
            buttonSeguir.Name = "buttonSeguir";
            buttonSeguir.Size = new Size(80, 80);
            buttonSeguir.TabIndex = 2;
            buttonSeguir.UseVisualStyleBackColor = true;
            buttonSeguir.Click += button3_Click;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.FlatStyle = FlatStyle.Flat;
            buttonSiguiente.ForeColor = Color.Teal;
            buttonSiguiente.Image = Properties.Resources.adelantar;
            buttonSiguiente.Location = new Point(559, 327);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(80, 80);
            buttonSiguiente.TabIndex = 3;
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Teal;
            button5.Image = Properties.Resources.repro;
            button5.Location = new Point(364, 327);
            button5.Name = "button5";
            button5.Size = new Size(80, 80);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // labelLista
            // 
            labelLista.AutoSize = true;
            labelLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelLista.Location = new Point(116, 24);
            labelLista.Name = "labelLista";
            labelLista.Size = new Size(229, 28);
            labelLista.TabIndex = 5;
            labelLista.Text = "Reproduciendo Playlist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(127, 272);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 6;
            label2.Text = "Cancion reproducida";
            // 
            // FormPlaylists
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labelLista);
            Controls.Add(button5);
            Controls.Add(buttonSiguiente);
            Controls.Add(buttonSeguir);
            Controls.Add(buttonPausar);
            Controls.Add(buttonAnterior);
            Name = "FormPlaylists";
            Text = "FormPlaylists";
            Load += FormPlaylists_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnterior;
        private Button buttonPausar;
        private Button buttonSeguir;
        private Button buttonSiguiente;
        private Button button5;
        private Label labelLista;
        private Label label2;
    }
}