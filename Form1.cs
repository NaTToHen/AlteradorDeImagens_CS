using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
//using System.Runtime.Intrinsics.X86;
//using System.Windows.Forms.DataVisualization.Charting;

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

        private Color Blending(Color pixel1, Color pixel2) {
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
                        Color blendedPixel = Blending(pixel1, pixel2);

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

        private void btnXor_Click(object sender, EventArgs e) {
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

                        byte r = (byte)(p.R ^ p2.R);
                        byte g = (byte)(p.G ^ p2.G);
                        byte b = (byte)(p.B ^ p2.B);

                        if (r > 255) r = 255;
                        if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        imagemFinal.SetPixel(x, y, Color.FromArgb(red: r, green: g, blue: b));
                    }
                }
                imgFinal.Image = imagemFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira as duas imagens, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOr_Click(object sender, EventArgs e) {
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

                        byte r = (byte)(p.R | p2.R);
                        byte g = (byte)(p.G | p2.G);
                        byte b = (byte)(p.B | p2.B);

                        if (r > 255) r = 255;
                        if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        imagemFinal.SetPixel(x, y, Color.FromArgb(red: r, green: g, blue: b));
                    }
                }
                imgFinal.Image = imagemFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira as duas imagens, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHistograma_Click(object sender, EventArgs e) {
            try
            {
                Bitmap bmp = new Bitmap(imageURL);
                Bitmap bmp2 = new Bitmap(imageURL2);
                Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);
                int width = bmp.Width;
                int height = bmp.Height;

                bmp2 = ResizeImage(bmp2, width, height);

                // Criar painéis para os histogramas (se necessário)
                Panel histo1 = histograma1; // Assuma que você inicializou os painéis corretamente
                Panel histo2 = histograma2;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira a imagem, ou algum erro ocorreu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnMinimo_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            Bitmap bmp2 = new Bitmap(imageURL2);
            Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

            int[,] kernel = new int[,] { { -1, -1, -1 }, { -1, 0, -1 }, { -1, -1, -1 } };

            int width = bmp.Width;
            int height = bmp.Height;

            bmp2 = ResizeImage(bmp2, width, height);

            imgFinal.Image = AplicarFiltroMinimo(bmp, bmp2, kernel);
        }

        private void btnMedia_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            Bitmap bmp2 = new Bitmap(imageURL2);
            Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

            int[,] kernel = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

            int width = bmp.Width;
            int height = bmp.Height;

            bmp2 = ResizeImage(bmp2, width, height);
            imgFinal.Image = AplicarFiltroMedia(bmp, bmp2, kernel);
        }

        private void btnMaximo_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            Bitmap bmp2 = new Bitmap(imageURL2);
            Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

            int[,] kernel = new int[,] { { -1, -1, -1 }, { -1, 0, -1 }, { -1, -1, -1 } };

            int width = bmp.Width;
            int height = bmp.Height;

            bmp2 = ResizeImage(bmp2, width, height);

            imgFinal.Image = AplicarFiltroMinimo(bmp, bmp2, kernel);
        }

        /*private Bitmap AplicarFiltroMinimo(Bitmap imagem1, Bitmap imagem2, int[,] kernel) {
            int largura = imagem1.Width;
            int altura = imagem1.Height;
            Bitmap imagemFinal = new Bitmap(largura, altura);

            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    int valorMinimo = int.MaxValue;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int xConv = x + i;
                            int yConv = y + j;

                            if (xConv >= 0 && xConv < largura && yConv >= 0 && yConv < altura)
                            {
                                int valorPixel1 = imagem1.GetPixel(xConv, yConv).R;
                                int valorPixel2 = imagem2.GetPixel(xConv, yConv).R;
                                valorMinimo = Math.Min(valorMinimo, Math.Min(valorPixel1, valorPixel2));
                            }
                        }
                    }
                    imagemFinal.SetPixel(x, y, Color.FromArgb(valorMinimo, valorMinimo, valorMinimo));
                }
            }
            return imagemFinal;
        }*/

        private Bitmap AplicarFiltroMinimo(Bitmap bmp1, Bitmap bmp2, int[,] kernel) {
            int width = bmp1.Width;
            int height = bmp1.Height;
            Bitmap imagemFinal = new Bitmap(width, height);

            int kernelWidth = kernel.GetLength(1);
            int kernelHeight = kernel.GetLength(0);
            int kernelOffsetX = kernelWidth / 2;
            int kernelOffsetY = kernelHeight / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int minValue = int.MaxValue;

                    for (int ky = -kernelOffsetY; ky <= kernelOffsetY; ky++)
                    {
                        for (int kx = -kernelOffsetX; kx <= kernelOffsetX; kx++)
                        {
                            int pixelPosX = x + kx;
                            int pixelPosY = y + ky;

                            if (pixelPosX >= 0 && pixelPosX < width && pixelPosY >= 0 && pixelPosY < height)
                            {
                                Color color1 = bmp1.GetPixel(pixelPosX, pixelPosY);
                                Color color2 = bmp2.GetPixel(pixelPosX, pixelPosY);

                                int value1 = (color1.R + color1.G + color1.B) / 3;
                                int value2 = (color2.R + color2.G + color2.B) / 3;

                                int minValueInWindow = Math.Min(value1, value2);

                                if (minValueInWindow < minValue)
                                {
                                    minValue = minValueInWindow;
                                }
                            }
                        }
                    }
                    Color finalColor = Color.FromArgb(minValue, minValue, minValue);
                    imagemFinal.SetPixel(x, y, finalColor);
                }
            }

            return imagemFinal;
        }

        private Bitmap AplicarFiltroMedia(Bitmap bmp1, Bitmap bmp2, int[,] kernel) {
            int width = bmp1.Width;
            int height = bmp1.Height;
            Bitmap imagemFinal = new Bitmap(width, height);

            int kernelWidth = kernel.GetLength(1);
            int kernelHeight = kernel.GetLength(0);
            int kernelOffsetX = kernelWidth / 2;
            int kernelOffsetY = kernelHeight / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int sumR = 0, sumG = 0, sumB = 0;
                    int count = 0;

                    for (int ky = -kernelOffsetY; ky <= kernelOffsetY; ky++)
                    {
                        for (int kx = -kernelOffsetX; kx <= kernelOffsetX; kx++)
                        {
                            int pixelPosX = x + kx;
                            int pixelPosY = y + ky;

                            if (pixelPosX >= 0 && pixelPosX < width && pixelPosY >= 0 && pixelPosY < height)
                            {
                                Color color1 = bmp1.GetPixel(pixelPosX, pixelPosY);
                                Color color2 = bmp2.GetPixel(pixelPosX, pixelPosY);

                                int avgR = (color1.R + color2.R) / 2;
                                int avgG = (color1.G + color2.G) / 2;
                                int avgB = (color1.B + color2.B) / 2;

                                sumR += avgR;
                                sumG += avgG;
                                sumB += avgB;
                                count++;
                            }
                        }
                    }

                    int mediaR = sumR / count;
                    int mediaG = sumG / count;
                    int mediaB = sumB / count;

                    Color finalColor = Color.FromArgb(mediaR, mediaG, mediaB);
                    imagemFinal.SetPixel(x, y, finalColor);
                }
            }

            return imagemFinal;
        }

        private void label4_Click(object sender, EventArgs e) {

        }
    }
}