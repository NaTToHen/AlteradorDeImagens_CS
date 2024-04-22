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
            btnBinario = new Button();
            valorBlending = new TextBox();
            btnBlending = new Button();
            btnNot = new Button();
            btnAnd = new Button();
            btnXor = new Button();
            btnOr = new Button();
            btnHistograma = new Button();
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
            btnImagem1.BackColor = Color.FromArgb(64, 64, 64);
            btnImagem1.FlatAppearance.MouseDownBackColor = Color.White;
            btnImagem1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnImagem1.FlatStyle = FlatStyle.Flat;
            btnImagem1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImagem1.ForeColor = SystemColors.Control;
            btnImagem1.Location = new Point(83, 397);
            btnImagem1.Name = "btnImagem1";
            btnImagem1.Size = new Size(350, 32);
            btnImagem1.TabIndex = 1;
            btnImagem1.Text = "Carregar imagem 1";
            btnImagem1.UseVisualStyleBackColor = false;
            btnImagem1.Click += btnImagem1_Click;
            // 
            // imgCarregada
            // 
            imgCarregada.Anchor = AnchorStyles.None;
            imgCarregada.BackColor = Color.FromArgb(30, 30, 30);
            imgCarregada.BorderStyle = BorderStyle.FixedSingle;
            imgCarregada.Location = new Point(83, 32);
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
            imgFinal.BorderStyle = BorderStyle.FixedSingle;
            imgFinal.Location = new Point(1238, 32);
            imgFinal.Name = "imgFinal";
            imgFinal.Size = new Size(350, 350);
            imgFinal.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFinal.TabIndex = 3;
            imgFinal.TabStop = false;
            // 
            // btnCinza
            // 
            btnCinza.Anchor = AnchorStyles.None;
            btnCinza.BackColor = Color.FromArgb(64, 64, 64);
            btnCinza.FlatAppearance.MouseDownBackColor = Color.White;
            btnCinza.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCinza.FlatStyle = FlatStyle.Flat;
            btnCinza.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinza.ForeColor = SystemColors.Control;
            btnCinza.Location = new Point(830, 32);
            btnCinza.Name = "btnCinza";
            btnCinza.Size = new Size(201, 32);
            btnCinza.TabIndex = 4;
            btnCinza.Text = "Escala de Cinza";
            btnCinza.UseVisualStyleBackColor = false;
            btnCinza.Click += btnCinza_Click;
            // 
            // btnBrilho
            // 
            btnBrilho.Anchor = AnchorStyles.None;
            btnBrilho.BackColor = Color.FromArgb(64, 64, 64);
            btnBrilho.FlatAppearance.MouseDownBackColor = Color.White;
            btnBrilho.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnBrilho.FlatStyle = FlatStyle.Flat;
            btnBrilho.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrilho.ForeColor = SystemColors.Control;
            btnBrilho.Location = new Point(830, 79);
            btnBrilho.Name = "btnBrilho";
            btnBrilho.Size = new Size(201, 32);
            btnBrilho.TabIndex = 5;
            btnBrilho.Text = "Aumentar brilho";
            btnBrilho.UseVisualStyleBackColor = false;
            btnBrilho.Click += btnBrilho_Click;
            // 
            // valorBrilho
            // 
            valorBrilho.Anchor = AnchorStyles.None;
            valorBrilho.BorderStyle = BorderStyle.None;
            valorBrilho.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorBrilho.Location = new Point(1037, 79);
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
            btnNegativo.BackColor = Color.FromArgb(64, 64, 64);
            btnNegativo.FlatAppearance.MouseDownBackColor = Color.White;
            btnNegativo.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnNegativo.FlatStyle = FlatStyle.Flat;
            btnNegativo.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNegativo.ForeColor = SystemColors.Control;
            btnNegativo.Location = new Point(830, 125);
            btnNegativo.Name = "btnNegativo";
            btnNegativo.Size = new Size(201, 32);
            btnNegativo.TabIndex = 7;
            btnNegativo.Text = "Imagem negativa";
            btnNegativo.UseVisualStyleBackColor = false;
            btnNegativo.Click += btnNegativo_Click;
            // 
            // btnContraste
            // 
            btnContraste.Anchor = AnchorStyles.None;
            btnContraste.BackColor = Color.FromArgb(64, 64, 64);
            btnContraste.FlatAppearance.MouseDownBackColor = Color.White;
            btnContraste.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnContraste.FlatStyle = FlatStyle.Flat;
            btnContraste.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContraste.ForeColor = SystemColors.Control;
            btnContraste.Location = new Point(830, 173);
            btnContraste.Name = "btnContraste";
            btnContraste.Size = new Size(201, 32);
            btnContraste.TabIndex = 8;
            btnContraste.Text = "Contraste";
            btnContraste.UseVisualStyleBackColor = false;
            btnContraste.Click += btnContraste_Click;
            // 
            // imgCarregada2
            // 
            imgCarregada2.Anchor = AnchorStyles.None;
            imgCarregada2.BackColor = Color.FromArgb(30, 30, 30);
            imgCarregada2.BorderStyle = BorderStyle.FixedSingle;
            imgCarregada2.Location = new Point(452, 32);
            imgCarregada2.Name = "imgCarregada2";
            imgCarregada2.Size = new Size(350, 350);
            imgCarregada2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgCarregada2.TabIndex = 10;
            imgCarregada2.TabStop = false;
            // 
            // btnImagem2
            // 
            btnImagem2.Anchor = AnchorStyles.None;
            btnImagem2.BackColor = Color.FromArgb(64, 64, 64);
            btnImagem2.FlatAppearance.MouseDownBackColor = Color.White;
            btnImagem2.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnImagem2.FlatStyle = FlatStyle.Flat;
            btnImagem2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImagem2.ForeColor = SystemColors.Control;
            btnImagem2.Location = new Point(452, 397);
            btnImagem2.Name = "btnImagem2";
            btnImagem2.Size = new Size(350, 32);
            btnImagem2.TabIndex = 9;
            btnImagem2.Text = "Carregar imagem para somar";
            btnImagem2.UseVisualStyleBackColor = false;
            btnImagem2.Click += btnImagem2_Click;
            // 
            // valorContraste
            // 
            valorContraste.Anchor = AnchorStyles.None;
            valorContraste.BorderStyle = BorderStyle.None;
            valorContraste.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorContraste.Location = new Point(1037, 173);
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
            btnSomar.BackColor = Color.FromArgb(64, 64, 64);
            btnSomar.FlatAppearance.MouseDownBackColor = Color.White;
            btnSomar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSomar.FlatStyle = FlatStyle.Flat;
            btnSomar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSomar.ForeColor = SystemColors.Control;
            btnSomar.Location = new Point(830, 220);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(201, 32);
            btnSomar.TabIndex = 12;
            btnSomar.Text = "Somar imagens";
            btnSomar.UseVisualStyleBackColor = false;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnBinario
            // 
            btnBinario.Anchor = AnchorStyles.None;
            btnBinario.BackColor = Color.FromArgb(64, 64, 64);
            btnBinario.FlatAppearance.MouseDownBackColor = Color.White;
            btnBinario.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnBinario.FlatStyle = FlatStyle.Flat;
            btnBinario.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBinario.ForeColor = SystemColors.Control;
            btnBinario.Location = new Point(830, 267);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(201, 32);
            btnBinario.TabIndex = 13;
            btnBinario.Text = "Imagem binaria";
            btnBinario.UseVisualStyleBackColor = false;
            btnBinario.Click += btnBinario_Click;
            // 
            // valorBlending
            // 
            valorBlending.Anchor = AnchorStyles.None;
            valorBlending.BorderStyle = BorderStyle.None;
            valorBlending.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorBlending.Location = new Point(1037, 314);
            valorBlending.MinimumSize = new Size(180, 30);
            valorBlending.Name = "valorBlending";
            valorBlending.PlaceholderText = "Valor do blending";
            valorBlending.Size = new Size(180, 30);
            valorBlending.TabIndex = 15;
            valorBlending.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBlending
            // 
            btnBlending.Anchor = AnchorStyles.None;
            btnBlending.BackColor = Color.FromArgb(64, 64, 64);
            btnBlending.FlatAppearance.MouseDownBackColor = Color.White;
            btnBlending.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnBlending.FlatStyle = FlatStyle.Flat;
            btnBlending.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBlending.ForeColor = SystemColors.Control;
            btnBlending.Location = new Point(830, 314);
            btnBlending.Name = "btnBlending";
            btnBlending.Size = new Size(201, 32);
            btnBlending.TabIndex = 14;
            btnBlending.Text = "Blending";
            btnBlending.UseVisualStyleBackColor = false;
            btnBlending.Click += btnBlending_Click;
            // 
            // btnNot
            // 
            btnNot.Anchor = AnchorStyles.None;
            btnNot.BackColor = Color.FromArgb(64, 64, 64);
            btnNot.FlatAppearance.MouseDownBackColor = Color.White;
            btnNot.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnNot.FlatStyle = FlatStyle.Flat;
            btnNot.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNot.ForeColor = SystemColors.Control;
            btnNot.Location = new Point(830, 352);
            btnNot.Name = "btnNot";
            btnNot.Size = new Size(79, 32);
            btnNot.TabIndex = 16;
            btnNot.Text = "NOT";
            btnNot.UseVisualStyleBackColor = false;
            btnNot.Click += btnNot_Click;
            // 
            // btnAnd
            // 
            btnAnd.Anchor = AnchorStyles.None;
            btnAnd.BackColor = Color.FromArgb(64, 64, 64);
            btnAnd.FlatAppearance.MouseDownBackColor = Color.White;
            btnAnd.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnAnd.FlatStyle = FlatStyle.Flat;
            btnAnd.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnd.ForeColor = SystemColors.Control;
            btnAnd.Location = new Point(915, 352);
            btnAnd.Name = "btnAnd";
            btnAnd.Size = new Size(79, 32);
            btnAnd.TabIndex = 17;
            btnAnd.Text = "AND";
            btnAnd.UseVisualStyleBackColor = false;
            btnAnd.Click += btnAnd_Click;
            // 
            // btnXor
            // 
            btnXor.Anchor = AnchorStyles.None;
            btnXor.BackColor = Color.FromArgb(64, 64, 64);
            btnXor.FlatAppearance.MouseDownBackColor = Color.White;
            btnXor.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnXor.FlatStyle = FlatStyle.Flat;
            btnXor.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXor.ForeColor = SystemColors.Control;
            btnXor.Location = new Point(1000, 352);
            btnXor.Name = "btnXor";
            btnXor.Size = new Size(79, 32);
            btnXor.TabIndex = 18;
            btnXor.Text = "XOR";
            btnXor.UseVisualStyleBackColor = false;
            // 
            // btnOr
            // 
            btnOr.Anchor = AnchorStyles.None;
            btnOr.BackColor = Color.FromArgb(64, 64, 64);
            btnOr.FlatAppearance.MouseDownBackColor = Color.White;
            btnOr.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnOr.FlatStyle = FlatStyle.Flat;
            btnOr.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOr.ForeColor = SystemColors.Control;
            btnOr.Location = new Point(1085, 352);
            btnOr.Name = "btnOr";
            btnOr.Size = new Size(79, 32);
            btnOr.TabIndex = 19;
            btnOr.Text = "OR";
            btnOr.UseVisualStyleBackColor = false;
            // 
            // btnHistograma
            // 
            btnHistograma.Anchor = AnchorStyles.None;
            btnHistograma.BackColor = Color.FromArgb(64, 64, 64);
            btnHistograma.FlatAppearance.MouseDownBackColor = Color.White;
            btnHistograma.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnHistograma.FlatStyle = FlatStyle.Flat;
            btnHistograma.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistograma.ForeColor = SystemColors.Control;
            btnHistograma.Location = new Point(830, 400);
            btnHistograma.Name = "btnHistograma";
            btnHistograma.Size = new Size(387, 32);
            btnHistograma.TabIndex = 20;
            btnHistograma.Text = "Mostrar Histograma";
            btnHistograma.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1684, 624);
            Controls.Add(btnHistograma);
            Controls.Add(btnOr);
            Controls.Add(btnXor);
            Controls.Add(btnAnd);
            Controls.Add(btnNot);
            Controls.Add(valorBlending);
            Controls.Add(btnBlending);
            Controls.Add(btnBinario);
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
        private Button btnBinario;
        private TextBox valorBlending;
        private Button btnBlending;
        private Button btnNot;
        private Button btnAnd;
        private Button btnXor;
        private Button btnOr;
        private Button btnHistograma;
    }
}
