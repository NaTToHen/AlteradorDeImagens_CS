namespace AlteradorDeImagens
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            titulo = new Label();
            btnImagem1 = new Button();
            imgCarregada = new PictureBox();
            imgFinal = new PictureBox();
            btnCinza = new Button();
            ((System.ComponentModel.ISupportInitialize)imgCarregada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFinal).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.Font = new Font("JetBrains Mono NL", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(425, 31);
            titulo.Name = "titulo";
            titulo.Size = new Size(232, 25);
            titulo.TabIndex = 0;
            titulo.Text = "Alterador de imagens";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnImagem1
            // 
            btnImagem1.Anchor = AnchorStyles.None;
            btnImagem1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImagem1.Location = new Point(77, 394);
            btnImagem1.Name = "btnImagem1";
            btnImagem1.Size = new Size(170, 32);
            btnImagem1.TabIndex = 1;
            btnImagem1.Text = "Carregar imagem 1";
            btnImagem1.UseVisualStyleBackColor = true;
            btnImagem1.Click += btnImagem1_Click;
            // 
            // imgCarregada
            // 
            imgCarregada.Anchor = AnchorStyles.None;
            imgCarregada.BackColor = Color.FromArgb(30, 30, 30);
            imgCarregada.Location = new Point(35, 124);
            imgCarregada.Name = "imgCarregada";
            imgCarregada.Size = new Size(255, 255);
            imgCarregada.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCarregada.TabIndex = 2;
            imgCarregada.TabStop = false;
            // 
            // imgFinal
            // 
            imgFinal.Anchor = AnchorStyles.None;
            imgFinal.BackColor = Color.FromArgb(30, 30, 30);
            imgFinal.Location = new Point(792, 124);
            imgFinal.Name = "imgFinal";
            imgFinal.Size = new Size(255, 255);
            imgFinal.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFinal.TabIndex = 3;
            imgFinal.TabStop = false;
            // 
            // btnCinza
            // 
            btnCinza.Anchor = AnchorStyles.None;
            btnCinza.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinza.Location = new Point(455, 124);
            btnCinza.Name = "btnCinza";
            btnCinza.Size = new Size(170, 32);
            btnCinza.TabIndex = 4;
            btnCinza.Text = "Escala de Cinza";
            btnCinza.UseVisualStyleBackColor = true;
            btnCinza.Click += btnCinza_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1084, 603);
            Controls.Add(btnCinza);
            Controls.Add(imgFinal);
            Controls.Add(imgCarregada);
            Controls.Add(btnImagem1);
            Controls.Add(titulo);
            Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterador de imagens";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgCarregada).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFinal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titulo;
        private Button btnImagem1;
        private PictureBox imgCarregada;
        private PictureBox imgFinal;
        private Button btnCinza;
    }
}
