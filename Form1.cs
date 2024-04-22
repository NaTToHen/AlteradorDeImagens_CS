using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace AlteradorDeImagens {

    public partial class Home : Form {
        String imageURL = "";
        String imageURL2 = "";

        public static Bitmap ResizeImage(Image image, int width, int height) {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private Color Blending(Color pixel1, Color pixel2, int blendValue) {
            int r = (pixel1.R + pixel2.R) / 2;
            int g = (pixel1.G + pixel2.G) / 2;
            int b = (pixel1.B + pixel2.B) / 2;

            return Color.FromArgb(r, g, b);
        }

        public Home() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        private void btnImagem1_Click(object sender, EventArgs e) {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png | BMP files(*.bmp)|*.bmp";

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
                //dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

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
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Insira uma imagem na imagem 1, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrilho_Click(object sender, EventArgs e) {
            try
            {
                Bitmap bmp = new Bitmap(imageURL);
                int width = bmp.Width;
                int height = bmp.Height;
                Color p;

                if (valorBrilho.Text == "")
                {
                    MessageBox.Show("Insira um valor entre 0 e 255", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int valorSomar = Int32.Parse(valorBrilho.Text);

                if (valorSomar < 0 || valorSomar > 255)
                {
                    MessageBox.Show("Insira um valor entre 0 e 255", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
            catch (Exception ex)
            {
                MessageBox.Show("Insira uma imagem na imagem 1, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNegativo_Click(object sender, EventArgs e) {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Insira uma imagem na imagem 1, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContraste_Click(object sender, EventArgs e) {
            try
            {
                Bitmap bmp = new Bitmap(imageURL);
                int width = bmp.Width;
                int height = bmp.Height;
                Color p;

                if (valorContraste.Text == "")
                {
                    MessageBox.Show("Insira um valor entre 0 e 255", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int valorContra = Int32.Parse(valorContraste.Text);

                    if (valorContra < 0 || valorContra > 255)
                    {
                        MessageBox.Show("Insira um valor entre 0 e 255", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            p = bmp.GetPixel(x, y);

                            int a = (p.A - 128) * valorContra + 128;
                            int r = (p.R - 128) * valorContra + 128;
                            int g = (p.G - 128) * valorContra + 128;
                            int b = (p.B - 128) * valorContra + 128;

                            if (a > 255) a = 255;
                            if (a < 0) a = 0;

                            if (r > 255) r = 255;
                            if (r < 0) r = 0;

                            if (g > 255) g = 255;
                            if (g < 0) g = 0;

                            if (b > 255) b = 255;
                            if (b < 0) b = 0;

                            bmp.SetPixel(x, y, Color.FromArgb(a, red: r, green: g, blue: b));
                        }
                    }
                    imgFinal.Image = bmp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira uma imagem na imagem 1, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSomar_Click(object sender, EventArgs e) {
            try
            {
                Bitmap bmp = new Bitmap(imageURL);
                Bitmap bmp2 = new Bitmap(imageURL2);
                Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

                int width = bmp.Width;
                int height = bmp.Height;

                bmp2 = ResizeImage(bmp2, width, height);

                Color p;
                Color p2;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        p = bmp.GetPixel(x, y);
                        p2 = bmp2.GetPixel(x, y);

                        int a = p.A + p2.A;
                        int r = p.R + p2.R;
                        int g = p.G + p2.G;
                        int b = p.B + p2.B;

                        if (a > 255) a = 255;
                        if (a < 0) a = 0;

                        if (r > 255) r = 255;
                        if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        imagemFinal.SetPixel(x, y, Color.FromArgb(a, red: r, green: g, blue: b));
                    }
                }
                imgFinal.Image = imagemFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira as duas imagens, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBinario_Click(object sender, EventArgs e) {
            try
            {
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
                        if (avg >= 126)
                        {
                            bmp.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                imgFinal.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira uma imagem na imagem 1, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBlending_Click(object sender, EventArgs e) {
            try
            {
                Bitmap bmp = new Bitmap(imageURL);
                Bitmap bmp2 = new Bitmap(imageURL2);
                Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

                int valorBlend = Int32.Parse(valorBlending.Text);

                if (valorBlend < 0 || valorBlend > 100)
                {
                    MessageBox.Show("Insira um valor entre 0 e 100", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("valor invalido");
                }

                int width = bmp.Width;
                int height = bmp.Height;

                bmp2 = ResizeImage(bmp2, width, height);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixel1 = bmp.GetPixel(x, y);
                        Color pixel2 = bmp2.GetPixel(x, y);

                        // Realize o blending entre os pixels das duas imagens
                        Color blendedPixel = Blending(pixel1, pixel2, valorBlend);

                        // Defina o pixel na imagem final
                        imagemFinal.SetPixel(x, y, blendedPixel);
                    }
                }

                // Exibir a imagem final no controle PictureBox
                imgFinal.Image = imagemFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira as duas imagens, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNot_Click(object sender, EventArgs e) {
            try
            {
                Bitmap bmp = new Bitmap(imageURL);
                Bitmap bmp2 = new Bitmap(imageURL2);
                Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

                int width = bmp.Width;
                int height = bmp.Height;

                bmp2 = ResizeImage(bmp2, width, height);

                Color p;
                Color p2;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        p = bmp.GetPixel(x, y);
                        p2 = bmp2.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        if (a > 255) a = 255;
                        if (a < 0) a = 0;

                        if (r > 255) r = 255;
                        if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        int avg = (r + g + b) / 3;
                        if (avg >= 126)
                        {
                            bmp.SetPixel(x, y, Color.Black);
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.White);
                        }
                    }
                }
                imgFinal.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira as duas imagens, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnd_Click(object sender, EventArgs e) {
            try
            {
                Bitmap bmp = new Bitmap(imageURL);
                Bitmap bmp2 = new Bitmap(imageURL2);
                Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

                int width = bmp.Width;
                int height = bmp.Height;

                bmp2 = ResizeImage(bmp2, width, height);

                Color p;
                Color p2;

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        p = bmp.GetPixel(x, y);
                        p2 = bmp2.GetPixel(x, y);

                        int a = p.A + p2.A;
                        int r = p.R + p2.R;
                        int g = p.G + p2.G;
                        int b = p.B + p2.B;

                        if (a > 255) a = 255;
                        if (a < 0) a = 0;

                        if (r > 255) r = 255;
                        if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        imagemFinal.SetPixel(x, y, Color.FromArgb(a, red: r, green: g, blue: b));
                    }
                }
                imgFinal.Image = imagemFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira as duas imagens, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
