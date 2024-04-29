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
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            button3 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCarregada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCarregada2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            btnImagem1.Location = new Point(52, 456);
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
            imgCarregada.Location = new Point(52, 91);
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
            imgFinal.Location = new Point(1244, 91);
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
            btnCinza.Location = new Point(19, 59);
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
            btnBrilho.Location = new Point(19, 106);
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
            valorBrilho.Location = new Point(226, 106);
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
            btnNegativo.Location = new Point(19, 152);
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
            btnContraste.Location = new Point(19, 200);
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
            imgCarregada2.Location = new Point(421, 91);
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
            btnImagem2.Location = new Point(421, 456);
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
            valorContraste.Location = new Point(226, 200);
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
            btnSomar.Location = new Point(19, 247);
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
            btnBinario.Location = new Point(19, 294);
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
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCinza);
            panel1.Controls.Add(btnBrilho);
            panel1.Controls.Add(btnBinario);
            panel1.Controls.Add(btnSomar);
            panel1.Controls.Add(valorBrilho);
            panel1.Controls.Add(valorContraste);
            panel1.Controls.Add(btnContraste);
            panel1.Controls.Add(btnNegativo);
            panel1.Location = new Point(799, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 344);
            panel1.TabIndex = 21;
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
            panel2.Location = new Point(799, 456);
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
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatAppearance.MouseDownBackColor = Color.White;
            button4.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(437, 141);
            button4.Name = "button4";
            button4.Size = new Size(79, 32);
            button4.TabIndex = 19;
            button4.Text = "OR";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(16, 137);
            button2.Name = "button2";
            button2.Size = new Size(387, 32);
            button2.TabIndex = 20;
            button2.Text = "Maximo";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(16, 51);
            button1.Name = "button1";
            button1.Size = new Size(387, 32);
            button1.TabIndex = 14;
            button1.Text = "Minimo";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(40, 40, 40);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(52, 524);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 193);
            panel3.TabIndex = 24;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(16, 93);
            button3.Name = "button3";
            button3.Size = new Size(387, 32);
            button3.TabIndex = 24;
            button3.Text = "Media";
            button3.UseVisualStyleBackColor = false;
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1684, 743);
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
        private Button button4;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button button3;
        private Label label3;
    }
}
