namespace AlteradorDeImagens
{
    public partial class Home : Form {
        String imageURL = "";
        String imageURL2 = "";
        public Home() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        private void btnImagem1_Click(object sender, EventArgs e) {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageURL = dialog.FileName;
                    imgCarregada.ImageLocation = imageURL;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O tipo da imagem esta errado, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImagem2_Click(object sender, EventArgs e) {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageURL2 = dialog.FileName;
                    imgCarregada2.ImageLocation = imageURL2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("O tipo da imagem esta errado, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCinza_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            int width = bmp.Width;
            int height = bmp.Height;
            Color p;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            imgFinal.Image = bmp;
        }

        private void btnBrilho_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            int width = bmp.Width;
            int height = bmp.Height;
            Color p;

            int valorSomar = Int32.Parse(valorBrilho.Text);

            if (valorSomar > 255) valorSomar = 255;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = p.A + valorSomar;
                    int r = p.R + valorSomar;
                    int g = p.G + valorSomar;
                    int b = p.B + valorSomar;

                    if (a > 255) a = 255;
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;

                    bmp.SetPixel(x, y, Color.FromArgb(a, red: r, green: g, blue: b));
                }
            }
            imgFinal.Image = bmp;
        }

        private void btnNegativo_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            int width = bmp.Width;
            int height = bmp.Height;
            Color p;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = 255 - p.A;
                    int r = 255 - p.R;
                    int g = 255 - p.G;
                    int b = 255 - p.B;

                    bmp.SetPixel(x, y, Color.FromArgb(a, red: r, green: g, blue: b));
                }
            }
            imgFinal.Image = bmp;
        }
    }
}
