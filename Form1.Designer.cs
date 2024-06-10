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
            btnBlending = new Button();
            btnNot = new Button();
            btnAnd = new Button();
            btnXor = new Button();
            btnOr = new Button();
            btnHistograma = new Button();
            panel1 = new Panel();
            btnDividir = new Button();
            btnMultiplica = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            valorOrdem = new TextBox();
            btnOrdem = new Button();
            btnMediana = new Button();
            btnMedia = new Button();
            btnMinimo = new Button();
            btnMaximo = new Button();
            label3 = new Label();
            histogramaTitulo = new Label();
            panel4 = new Panel();
            histograma2 = new Panel();
            histograma1 = new Panel();
            panel5 = new Panel();
            valorGaus = new TextBox();
            btnGaussiano = new Button();
            imgFiltro = new PictureBox();
            label4 = new Label();
            button8 = new Button();
            panel6 = new Panel();
            btnPrewitt = new Button();
            btnLaplaciano = new Button();
            btnSobel = new Button();
            label5 = new Label();
            panel7 = new Panel();
            btnFlipImage = new Button();
            btnRecorte = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCarregada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCarregada2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top;
            titulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(927, 34);
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
            btnImagem1.Location = new Point(25, 518);
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
            imgCarregada.Location = new Point(25, 153);
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
            imgFinal.Location = new Point(1515, 153);
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
            btnCinza.Location = new Point(19, 62);
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
            btnBrilho.Location = new Point(19, 109);
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
            valorBrilho.Location = new Point(226, 109);
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
            btnNegativo.Location = new Point(19, 155);
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
            btnContraste.Location = new Point(19, 203);
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
            imgCarregada2.Location = new Point(394, 153);
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
            btnImagem2.Location = new Point(394, 518);
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
            valorContraste.Location = new Point(226, 203);
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
            btnSomar.Location = new Point(19, 250);
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
            btnBinario.Location = new Point(19, 297);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(201, 32);
            btnBinario.TabIndex = 13;
            btnBinario.Text = "Imagem binaria";
            btnBinario.UseVisualStyleBackColor = false;
            btnBinario.Click += btnBinario_Click;
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
            btnBlending.Location = new Point(19, 57);
            btnBlending.Name = "btnBlending";
            btnBlending.Size = new Size(387, 32);
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
            btnNot.Location = new Point(19, 95);
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
            btnAnd.Location = new Point(124, 95);
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
            btnXor.Location = new Point(229, 95);
            btnXor.Name = "btnXor";
            btnXor.Size = new Size(79, 32);
            btnXor.TabIndex = 18;
            btnXor.Text = "XOR";
            btnXor.UseVisualStyleBackColor = false;
            btnXor.Click += btnXor_Click;
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
            btnOr.Location = new Point(327, 95);
            btnOr.Name = "btnOr";
            btnOr.Size = new Size(79, 32);
            btnOr.TabIndex = 19;
            btnOr.Text = "OR";
            btnOr.UseVisualStyleBackColor = false;
            btnOr.Click += btnOr_Click;
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
            btnHistograma.Location = new Point(19, 143);
            btnHistograma.Name = "btnHistograma";
            btnHistograma.Size = new Size(387, 32);
            btnHistograma.TabIndex = 20;
            btnHistograma.Text = "Mostrar Histograma";
            btnHistograma.UseVisualStyleBackColor = false;
            btnHistograma.Click += btnHistograma_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(btnDividir);
            panel1.Controls.Add(btnMultiplica);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCinza);
            panel1.Controls.Add(btnBrilho);
            panel1.Controls.Add(btnBinario);
            panel1.Controls.Add(btnSomar);
            panel1.Controls.Add(valorBrilho);
            panel1.Controls.Add(valorContraste);
            panel1.Controls.Add(btnContraste);
            panel1.Controls.Add(btnNegativo);
            panel1.Location = new Point(772, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 350);
            panel1.TabIndex = 21;
            // 
            // btnDividir
            // 
            btnDividir.Anchor = AnchorStyles.None;
            btnDividir.BackColor = Color.FromArgb(64, 64, 64);
            btnDividir.FlatAppearance.MouseDownBackColor = Color.White;
            btnDividir.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnDividir.FlatStyle = FlatStyle.Flat;
            btnDividir.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.ForeColor = SystemColors.Control;
            btnDividir.Location = new Point(230, 155);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(176, 32);
            btnDividir.TabIndex = 26;
            btnDividir.Text = "Dividir imagens";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplica
            // 
            btnMultiplica.Anchor = AnchorStyles.None;
            btnMultiplica.BackColor = Color.FromArgb(64, 64, 64);
            btnMultiplica.FlatAppearance.MouseDownBackColor = Color.White;
            btnMultiplica.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnMultiplica.FlatStyle = FlatStyle.Flat;
            btnMultiplica.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplica.ForeColor = SystemColors.Control;
            btnMultiplica.Location = new Point(230, 62);
            btnMultiplica.Name = "btnMultiplica";
            btnMultiplica.Size = new Size(176, 32);
            btnMultiplica.TabIndex = 25;
            btnMultiplica.Text = "Multi. imagens";
            btnMultiplica.UseVisualStyleBackColor = false;
            btnMultiplica.Click += btnMultiplica_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 13);
            label2.Name = "label2";
            label2.Size = new Size(387, 25);
            label2.TabIndex = 24;
            label2.Text = "Filtros de Cor";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnBlending);
            panel2.Controls.Add(btnHistograma);
            panel2.Controls.Add(btnNot);
            panel2.Controls.Add(btnOr);
            panel2.Controls.Add(btnAnd);
            panel2.Controls.Add(btnXor);
            panel2.Location = new Point(772, 518);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 193);
            panel2.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(387, 25);
            label1.TabIndex = 23;
            label1.Text = "Operações Logicas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Controls.Add(valorOrdem);
            panel3.Controls.Add(btnOrdem);
            panel3.Controls.Add(btnMediana);
            panel3.Controls.Add(btnMedia);
            panel3.Controls.Add(btnMinimo);
            panel3.Controls.Add(btnMaximo);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(772, 730);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 259);
            panel3.TabIndex = 24;
            // 
            // valorOrdem
            // 
            valorOrdem.Anchor = AnchorStyles.None;
            valorOrdem.BorderStyle = BorderStyle.None;
            valorOrdem.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorOrdem.Location = new Point(217, 203);
            valorOrdem.MinimumSize = new Size(100, 30);
            valorOrdem.Name = "valorOrdem";
            valorOrdem.PlaceholderText = "Valor";
            valorOrdem.Size = new Size(186, 30);
            valorOrdem.TabIndex = 30;
            valorOrdem.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOrdem
            // 
            btnOrdem.Anchor = AnchorStyles.None;
            btnOrdem.BackColor = Color.FromArgb(64, 64, 64);
            btnOrdem.FlatAppearance.MouseDownBackColor = Color.White;
            btnOrdem.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnOrdem.FlatStyle = FlatStyle.Flat;
            btnOrdem.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdem.ForeColor = SystemColors.Control;
            btnOrdem.Location = new Point(217, 165);
            btnOrdem.Name = "btnOrdem";
            btnOrdem.Size = new Size(186, 32);
            btnOrdem.TabIndex = 32;
            btnOrdem.Text = "Ordem";
            btnOrdem.UseVisualStyleBackColor = false;
            btnOrdem.Click += btnOrdem_Click;
            // 
            // btnMediana
            // 
            btnMediana.Anchor = AnchorStyles.None;
            btnMediana.BackColor = Color.FromArgb(64, 64, 64);
            btnMediana.FlatAppearance.MouseDownBackColor = Color.White;
            btnMediana.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnMediana.FlatStyle = FlatStyle.Flat;
            btnMediana.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMediana.ForeColor = SystemColors.Control;
            btnMediana.Location = new Point(16, 165);
            btnMediana.Name = "btnMediana";
            btnMediana.Size = new Size(187, 32);
            btnMediana.TabIndex = 31;
            btnMediana.Text = "Mediana";
            btnMediana.UseVisualStyleBackColor = false;
            btnMediana.Click += btnMediana_Click;
            // 
            // btnMedia
            // 
            btnMedia.Anchor = AnchorStyles.None;
            btnMedia.BackColor = Color.FromArgb(64, 64, 64);
            btnMedia.FlatAppearance.MouseDownBackColor = Color.White;
            btnMedia.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedia.ForeColor = SystemColors.Control;
            btnMedia.Location = new Point(217, 75);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(186, 32);
            btnMedia.TabIndex = 29;
            btnMedia.Text = "Media";
            btnMedia.UseVisualStyleBackColor = false;
            btnMedia.Click += btnMedia_Click;
            // 
            // btnMinimo
            // 
            btnMinimo.Anchor = AnchorStyles.None;
            btnMinimo.BackColor = Color.FromArgb(64, 64, 64);
            btnMinimo.FlatAppearance.MouseDownBackColor = Color.White;
            btnMinimo.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnMinimo.FlatStyle = FlatStyle.Flat;
            btnMinimo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimo.ForeColor = SystemColors.Control;
            btnMinimo.Location = new Point(16, 75);
            btnMinimo.Name = "btnMinimo";
            btnMinimo.Size = new Size(187, 32);
            btnMinimo.TabIndex = 27;
            btnMinimo.Text = "Minimo";
            btnMinimo.UseVisualStyleBackColor = false;
            btnMinimo.Click += btnMinimo_Click;
            // 
            // btnMaximo
            // 
            btnMaximo.Anchor = AnchorStyles.None;
            btnMaximo.BackColor = Color.FromArgb(64, 64, 64);
            btnMaximo.FlatAppearance.MouseDownBackColor = Color.White;
            btnMaximo.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnMaximo.FlatStyle = FlatStyle.Flat;
            btnMaximo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximo.ForeColor = SystemColors.Control;
            btnMaximo.Location = new Point(16, 122);
            btnMaximo.Name = "btnMaximo";
            btnMaximo.Size = new Size(387, 32);
            btnMaximo.TabIndex = 28;
            btnMaximo.Text = "Maximo";
            btnMaximo.UseVisualStyleBackColor = false;
            btnMaximo.Click += btnMaximo_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 11);
            label3.Name = "label3";
            label3.Size = new Size(387, 25);
            label3.TabIndex = 23;
            label3.Text = "Convolação";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // histogramaTitulo
            // 
            histogramaTitulo.Anchor = AnchorStyles.Top;
            histogramaTitulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            histogramaTitulo.ForeColor = Color.White;
            histogramaTitulo.Location = new Point(169, 7);
            histogramaTitulo.Name = "histogramaTitulo";
            histogramaTitulo.Size = new Size(387, 25);
            histogramaTitulo.TabIndex = 25;
            histogramaTitulo.Text = "Graficos";
            histogramaTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(40, 40, 40);
            panel4.Controls.Add(histograma2);
            panel4.Controls.Add(histograma1);
            panel4.Controls.Add(histogramaTitulo);
            panel4.Location = new Point(25, 575);
            panel4.Name = "panel4";
            panel4.Size = new Size(719, 348);
            panel4.TabIndex = 24;
            // 
            // histograma2
            // 
            histograma2.BackColor = Color.FromArgb(20, 20, 20);
            histograma2.Location = new Point(369, 58);
            histograma2.Name = "histograma2";
            histograma2.Size = new Size(328, 252);
            histograma2.TabIndex = 27;
            // 
            // histograma1
            // 
            histograma1.BackColor = Color.FromArgb(20, 20, 20);
            histograma1.Location = new Point(22, 58);
            histograma1.Name = "histograma1";
            histograma1.Size = new Size(328, 252);
            histograma1.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(40, 40, 40);
            panel5.Controls.Add(valorGaus);
            panel5.Controls.Add(btnGaussiano);
            panel5.Controls.Add(imgFiltro);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(button8);
            panel5.Location = new Point(1209, 153);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 350);
            panel5.TabIndex = 25;
            // 
            // valorGaus
            // 
            valorGaus.Anchor = AnchorStyles.None;
            valorGaus.BorderStyle = BorderStyle.None;
            valorGaus.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorGaus.Location = new Point(145, 62);
            valorGaus.MinimumSize = new Size(110, 32);
            valorGaus.Name = "valorGaus";
            valorGaus.PlaceholderText = "Valor";
            valorGaus.Size = new Size(110, 32);
            valorGaus.TabIndex = 25;
            valorGaus.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGaussiano
            // 
            btnGaussiano.Anchor = AnchorStyles.None;
            btnGaussiano.BackColor = Color.FromArgb(64, 64, 64);
            btnGaussiano.FlatAppearance.MouseDownBackColor = Color.White;
            btnGaussiano.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnGaussiano.FlatStyle = FlatStyle.Flat;
            btnGaussiano.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGaussiano.ForeColor = SystemColors.Control;
            btnGaussiano.Location = new Point(35, 62);
            btnGaussiano.Name = "btnGaussiano";
            btnGaussiano.Size = new Size(97, 32);
            btnGaussiano.TabIndex = 25;
            btnGaussiano.Text = "Aplicar";
            btnGaussiano.UseVisualStyleBackColor = false;
            btnGaussiano.Click += btnGaussiano_Click;
            // 
            // imgFiltro
            // 
            imgFiltro.Anchor = AnchorStyles.None;
            imgFiltro.BackColor = Color.FromArgb(224, 224, 224);
            imgFiltro.BorderStyle = BorderStyle.FixedSingle;
            imgFiltro.Location = new Point(35, 109);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(220, 220);
            imgFiltro.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFiltro.TabIndex = 26;
            imgFiltro.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-10, 16);
            label4.Name = "label4";
            label4.Size = new Size(310, 25);
            label4.TabIndex = 23;
            label4.Text = "Filtro Gaussiano";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.FromArgb(64, 64, 64);
            button8.FlatAppearance.MouseDownBackColor = Color.White;
            button8.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.Control;
            button8.Location = new Point(481, 266);
            button8.Name = "button8";
            button8.Size = new Size(79, 32);
            button8.TabIndex = 19;
            button8.Text = "OR";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(40, 40, 40);
            panel6.Controls.Add(btnPrewitt);
            panel6.Controls.Add(btnLaplaciano);
            panel6.Controls.Add(btnSobel);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(1209, 518);
            panel6.Name = "panel6";
            panel6.Size = new Size(289, 193);
            panel6.TabIndex = 24;
            // 
            // btnPrewitt
            // 
            btnPrewitt.Anchor = AnchorStyles.None;
            btnPrewitt.BackColor = Color.FromArgb(64, 64, 64);
            btnPrewitt.FlatAppearance.MouseDownBackColor = Color.White;
            btnPrewitt.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnPrewitt.FlatStyle = FlatStyle.Flat;
            btnPrewitt.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrewitt.ForeColor = SystemColors.Control;
            btnPrewitt.Location = new Point(17, 47);
            btnPrewitt.Name = "btnPrewitt";
            btnPrewitt.Size = new Size(255, 32);
            btnPrewitt.TabIndex = 24;
            btnPrewitt.Text = "Prewitt";
            btnPrewitt.UseVisualStyleBackColor = false;
            btnPrewitt.Click += btnPrewitt_Click;
            // 
            // btnLaplaciano
            // 
            btnLaplaciano.Anchor = AnchorStyles.None;
            btnLaplaciano.BackColor = Color.FromArgb(64, 64, 64);
            btnLaplaciano.FlatAppearance.MouseDownBackColor = Color.White;
            btnLaplaciano.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnLaplaciano.FlatStyle = FlatStyle.Flat;
            btnLaplaciano.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLaplaciano.ForeColor = SystemColors.Control;
            btnLaplaciano.Location = new Point(17, 94);
            btnLaplaciano.Name = "btnLaplaciano";
            btnLaplaciano.Size = new Size(255, 32);
            btnLaplaciano.TabIndex = 25;
            btnLaplaciano.Text = "laplaciano";
            btnLaplaciano.UseVisualStyleBackColor = false;
            btnLaplaciano.Click += btnLaplaciano_Click;
            // 
            // btnSobel
            // 
            btnSobel.Anchor = AnchorStyles.None;
            btnSobel.BackColor = Color.FromArgb(64, 64, 64);
            btnSobel.FlatAppearance.MouseDownBackColor = Color.White;
            btnSobel.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnSobel.FlatStyle = FlatStyle.Flat;
            btnSobel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSobel.ForeColor = SystemColors.Control;
            btnSobel.Location = new Point(17, 142);
            btnSobel.Name = "btnSobel";
            btnSobel.Size = new Size(255, 32);
            btnSobel.TabIndex = 26;
            btnSobel.Text = "Sobel";
            btnSobel.UseVisualStyleBackColor = false;
            btnSobel.Click += btnSobel_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 7);
            label5.Name = "label5";
            label5.Size = new Size(283, 25);
            label5.TabIndex = 23;
            label5.Text = "Detecção de Bordas";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.FromArgb(40, 40, 40);
            panel7.Controls.Add(btnFlipImage);
            panel7.Controls.Add(btnRecorte);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(1209, 730);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 154);
            panel7.TabIndex = 27;
            // 
            // btnFlipImage
            // 
            btnFlipImage.Anchor = AnchorStyles.None;
            btnFlipImage.BackColor = Color.FromArgb(64, 64, 64);
            btnFlipImage.FlatAppearance.MouseDownBackColor = Color.White;
            btnFlipImage.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnFlipImage.FlatStyle = FlatStyle.Flat;
            btnFlipImage.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFlipImage.ForeColor = SystemColors.Control;
            btnFlipImage.Location = new Point(17, 54);
            btnFlipImage.Name = "btnFlipImage";
            btnFlipImage.Size = new Size(255, 32);
            btnFlipImage.TabIndex = 24;
            btnFlipImage.Text = "Ponta cabeça";
            btnFlipImage.UseVisualStyleBackColor = false;
            btnFlipImage.Click += btnFlipImage_Click;
            // 
            // btnRecorte
            // 
            btnRecorte.Anchor = AnchorStyles.None;
            btnRecorte.BackColor = Color.FromArgb(64, 64, 64);
            btnRecorte.FlatAppearance.MouseDownBackColor = Color.White;
            btnRecorte.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnRecorte.FlatStyle = FlatStyle.Flat;
            btnRecorte.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecorte.ForeColor = SystemColors.Control;
            btnRecorte.Location = new Point(17, 101);
            btnRecorte.Name = "btnRecorte";
            btnRecorte.Size = new Size(255, 32);
            btnRecorte.TabIndex = 25;
            btnRecorte.Text = "Recortar Imagem";
            btnRecorte.UseVisualStyleBackColor = false;
            btnRecorte.Click += btnRecorte_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(283, 25);
            label6.TabIndex = 23;
            label6.Text = "Outras ações";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(imgCarregada2);
            Controls.Add(btnImagem2);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button btnBlending;
        private Button btnNot;
        private Button btnAnd;
        private Button btnXor;
        private Button btnOr;
        private Button btnHistograma;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Label histogramaTitulo;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Button button8;
        private Panel histograma2;
        private Panel histograma1;
        public TextBox valorGaus;
        private Button btnGaussiano;
        private PictureBox imgFiltro;
        private Panel panel6;
        private Label label5;
        private Button btnPrewitt;
        private Button btnLaplaciano;
        private Button btnSobel;
        private TextBox valorOrdem;
        private Button btnOrdem;
        private Button btnMediana;
        private Button btnMedia;
        private Button btnMinimo;
        private Button btnMaximo;
        private Panel panel7;
        private Button btnFlipImage;
        private Button btnRecorte;
        private Label label6;
        private Button btnDividir;
        private Button btnMultiplica;
    }
}
