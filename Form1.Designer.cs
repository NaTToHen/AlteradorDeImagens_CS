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
        private void InitializeComponent() {
            titulo = new Label();
            btnImagem1 = new Button();
            imgCarregada = new PictureBox();
            imgFinal = new PictureBox();
            btnCinza = new Button();
            btnBrilho = new Button();
            valorBrilho = new TextBox();
            btnNegativo = new Button();
            btnContraste = new Button();
            imgCarregada2 = new PictureBox();
            btnImagem2 = new Button();
            valorContraste = new TextBox();
            btnSomar = new Button();
            ((System.ComponentModel.ISupportInitialize)imgCarregada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCarregada2).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(740, 32);
            titulo.Name = "titulo";
            titulo.Size = new Size(281, 25);
            titulo.TabIndex = 0;
            titulo.Text = "Alterador de imagens";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnImagem1
            // 
            btnImagem1.Anchor = AnchorStyles.None;
            btnImagem1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImagem1.Location = new Point(45, 397);
            btnImagem1.Name = "btnImagem1";
            btnImagem1.Size = new Size(350, 32);
            btnImagem1.TabIndex = 1;
            btnImagem1.Text = "Carregar imagem 1";
            btnImagem1.UseVisualStyleBackColor = true;
            btnImagem1.Click += btnImagem1_Click;
            // 
            // imgCarregada
            // 
            imgCarregada.Anchor = AnchorStyles.None;
            imgCarregada.BackColor = Color.FromArgb(30, 30, 30);
            imgCarregada.Location = new Point(45, 32);
            imgCarregada.Name = "imgCarregada";
            imgCarregada.Size = new Size(350, 350);
            imgCarregada.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCarregada.TabIndex = 2;
            imgCarregada.TabStop = false;
            // 
            // imgFinal
            // 
            imgFinal.Anchor = AnchorStyles.None;
            imgFinal.BackColor = Color.FromArgb(30, 30, 30);
            imgFinal.Location = new Point(1276, 32);
            imgFinal.Name = "imgFinal";
            imgFinal.Size = new Size(350, 350);
            imgFinal.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFinal.TabIndex = 3;
            imgFinal.TabStop = false;
            // 
            // btnCinza
            // 
            btnCinza.Anchor = AnchorStyles.None;
            btnCinza.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinza.Location = new Point(826, 127);
            btnCinza.Name = "btnCinza";
            btnCinza.Size = new Size(201, 32);
            btnCinza.TabIndex = 4;
            btnCinza.Text = "Escala de Cinza";
            btnCinza.UseVisualStyleBackColor = true;
            btnCinza.Click += btnCinza_Click;
            // 
            // btnBrilho
            // 
            btnBrilho.Anchor = AnchorStyles.None;
            btnBrilho.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrilho.Location = new Point(826, 184);
            btnBrilho.Name = "btnBrilho";
            btnBrilho.Size = new Size(201, 32);
            btnBrilho.TabIndex = 5;
            btnBrilho.Text = "Aumentar brilho";
            btnBrilho.UseVisualStyleBackColor = true;
            btnBrilho.Click += btnBrilho_Click;
            // 
            // valorBrilho
            // 
            valorBrilho.Anchor = AnchorStyles.None;
            valorBrilho.BorderStyle = BorderStyle.None;
            valorBrilho.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorBrilho.Location = new Point(1033, 184);
            valorBrilho.MinimumSize = new Size(180, 30);
            valorBrilho.Name = "valorBrilho";
            valorBrilho.PlaceholderText = "Valor adicionado";
            valorBrilho.Size = new Size(180, 30);
            valorBrilho.TabIndex = 6;
            valorBrilho.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNegativo
            // 
            btnNegativo.Anchor = AnchorStyles.None;
            btnNegativo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNegativo.Location = new Point(826, 237);
            btnNegativo.Name = "btnNegativo";
            btnNegativo.Size = new Size(201, 32);
            btnNegativo.TabIndex = 7;
            btnNegativo.Text = "Imagem negativa";
            btnNegativo.UseVisualStyleBackColor = true;
            btnNegativo.Click += btnNegativo_Click;
            // 
            // btnContraste
            // 
            btnContraste.Anchor = AnchorStyles.None;
            btnContraste.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContraste.Location = new Point(826, 291);
            btnContraste.Name = "btnContraste";
            btnContraste.Size = new Size(201, 32);
            btnContraste.TabIndex = 8;
            btnContraste.Text = "Contraste";
            btnContraste.UseVisualStyleBackColor = true;
            btnContraste.Click += btnContraste_Click;
            // 
            // imgCarregada2
            // 
            imgCarregada2.Anchor = AnchorStyles.None;
            imgCarregada2.BackColor = Color.FromArgb(30, 30, 30);
            imgCarregada2.Location = new Point(414, 32);
            imgCarregada2.Name = "imgCarregada2";
            imgCarregada2.Size = new Size(350, 350);
            imgCarregada2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCarregada2.TabIndex = 10;
            imgCarregada2.TabStop = false;
            // 
            // btnImagem2
            // 
            btnImagem2.Anchor = AnchorStyles.None;
            btnImagem2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImagem2.Location = new Point(414, 397);
            btnImagem2.Name = "btnImagem2";
            btnImagem2.Size = new Size(350, 32);
            btnImagem2.TabIndex = 9;
            btnImagem2.Text = "Carregar imagem 2";
            btnImagem2.UseVisualStyleBackColor = true;
            btnImagem2.Click += btnImagem2_Click;
            // 
            // valorContraste
            // 
            valorContraste.Anchor = AnchorStyles.None;
            valorContraste.BorderStyle = BorderStyle.None;
            valorContraste.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorContraste.Location = new Point(1033, 291);
            valorContraste.MinimumSize = new Size(180, 30);
            valorContraste.Name = "valorContraste";
            valorContraste.PlaceholderText = "Valor adicionado";
            valorContraste.Size = new Size(180, 30);
            valorContraste.TabIndex = 11;
            valorContraste.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSomar
            // 
            btnSomar.Anchor = AnchorStyles.None;
            btnSomar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSomar.Location = new Point(826, 341);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(201, 32);
            btnSomar.TabIndex = 12;
            btnSomar.Text = "Somar imagens";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1684, 624);
            Controls.Add(btnSomar);
            Controls.Add(valorContraste);
            Controls.Add(imgCarregada2);
            Controls.Add(btnImagem2);
            Controls.Add(btnContraste);
            Controls.Add(btnNegativo);
            Controls.Add(valorBrilho);
            Controls.Add(btnBrilho);
            Controls.Add(btnCinza);
            Controls.Add(imgFinal);
            Controls.Add(imgCarregada);
            Controls.Add(btnImagem1);
            Controls.Add(titulo);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterador de imagens";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)imgCarregada).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCarregada2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button btnImagem1;
        private PictureBox imgCarregada;
        private PictureBox imgFinal;
        private Button btnCinza;
        private Button btnBrilho;
        private TextBox valorBrilho;
        private Button btnNegativo;
        private Button btnContraste;
        private PictureBox imgCarregada2;
        private Button btnImagem2;
        private TextBox valorContraste;
        private Button btnSomar;
    }
}
