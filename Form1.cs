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

        //------------------------ Operadores logicos ----------------------------------

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
            //Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

            int[,] kernel = new int[,] { { -1, -1, -1 }, { -1, 0, -1 }, { -1, -1, -1 } };

            imgFinal.Image = AplicarFiltroMinimo(bmp, kernel);
        }

        //------------------------ Realçe de imagens ----------------------------------

        private void btnMedia_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            //Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

            int[,] kernel = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

            imgFinal.Image = AplicarFiltroMedia(bmp, kernel);
        }

        private void btnMaximo_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);

            int[,] kernel = new int[,] { { -1, -1, -1 }, { -1, 0, -1 }, { -1, -1, -1 } };

            imgFinal.Image = AplicarFiltroMaximo(bmp, kernel);
        }

        private void btnOrdem_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            int ordem = 4;
            imgFinal.Image = AplicarFiltroDeOrdem(bmp, ordem);
        }

        private void btnMediana_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            imgFinal.Image = AplicarFiltroMediana(bmp);
        }

        private Bitmap AplicarFiltroMinimo(Bitmap bmp, int[,] kernel) {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap imagemFinal = new Bitmap(width, height);

            int kernelWidth = kernel.GetLength(1);
            int kernelHeight = kernel.GetLength(0);
            int kernelX = kernelWidth / 2;
            int kernelY = kernelHeight / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int minValue = int.MaxValue;

                    for (int ky = -kernelY; ky <= kernelY; ky++)
                    {
                        for (int kx = -kernelX; kx <= kernelX; kx++)
                        {
                            int pixelPosX = x + kx;
                            int pixelPosY = y + ky;

                            if (pixelPosX >= 0 && pixelPosX < width && pixelPosY >= 0 && pixelPosY < height)
                            {
                                Color color = bmp.GetPixel(pixelPosX, pixelPosY);
                                int value = (color.R + color.G + color.B) / 3;

                                if (value < minValue)
                                {
                                    minValue = value;
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

        private Bitmap AplicarFiltroMedia(Bitmap bmp, int[,] kernel) {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap imagemFinal = new Bitmap(width, height);

            int kernelWidth = kernel.GetLength(1);
            int kernelHeight = kernel.GetLength(0);
            int kernelX = kernelWidth / 2;
            int kernelY = kernelHeight / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int sum = 0;
                    int count = 0;

                    for (int ky = -kernelY; ky <= kernelY; ky++)
                    {
                        for (int kx = -kernelX; kx <= kernelX; kx++)
                        {
                            int pixelPosX = x + kx;
                            int pixelPosY = y + ky;

                            if (pixelPosX >= 0 && pixelPosX < width && pixelPosY >= 0 && pixelPosY < height)
                            {
                                Color color = bmp.GetPixel(pixelPosX, pixelPosY);
                                int value = (color.R + color.G + color.B) / 3;

                                sum += value;
                                count++;
                            }
                        }
                    }

                    int media = sum / count;
                    Color finalColor = Color.FromArgb(media, media, media);
                    imagemFinal.SetPixel(x, y, finalColor);
                }
            }

            return imagemFinal;
        }

        private Bitmap AplicarFiltroMaximo(Bitmap bmp, int[,] kernel) {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap imagemFinal = new Bitmap(width, height);

            int kernelWidth = kernel.GetLength(1);
            int kernelHeight = kernel.GetLength(0);
            int kernelX = kernelWidth / 2;
            int kernelY = kernelHeight / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int maxValue = int.MinValue;

                    for (int ky = -kernelY; ky <= kernelY; ky++)
                    {
                        for (int kx = -kernelX; kx <= kernelX; kx++)
                        {
                            int pixelPosX = x + kx;
                            int pixelPosY = y + ky;

                            if (pixelPosX >= 0 && pixelPosX < width && pixelPosY >= 0 && pixelPosY < height)
                            {
                                Color color = bmp.GetPixel(pixelPosX, pixelPosY);
                                int value = (color.R + color.G + color.B) / 3;

                                if (value > maxValue)
                                {
                                    maxValue = value;
                                }
                            }
                        }
                    }
                    Color finalColor = Color.FromArgb(maxValue, maxValue, maxValue);
                    imagemFinal.SetPixel(x, y, finalColor);
                }
            }

            return imagemFinal;
        }

        private Bitmap AplicarFiltroDeOrdem(Bitmap bmp, int ordem) {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap imagemFinal = new Bitmap(width, height);

            int[,] kernel = new int[,] { { -1, -1, -1 }, { -1, 0, -1 }, { -1, -1, -1 } };

            int kernelWidth = kernel.GetLength(1);
            int kernelHeight = kernel.GetLength(0);
            int kernelX = kernelWidth / 2;
            int kernelY = kernelHeight / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    List<int> valores = new List<int>();

                    for (int ky = -kernelY; ky <= kernelY; ky++)
                    {
                        for (int kx = -kernelX; kx <= kernelX; kx++)
                        {
                            int pixelPosX = x + kx;
                            int pixelPosY = y + ky;

                            if (pixelPosX >= 0 && pixelPosX < width && pixelPosY >= 0 && pixelPosY < height)
                            {
                                Color color = bmp.GetPixel(pixelPosX, pixelPosY);
                                int value = (color.R + color.G + color.B) / 3;

                                valores.Add(value);
                            }
                        }
                    }

                    valores.Sort();

                    int ordemValor = valores[Math.Max(0, Math.Min(ordem, valores.Count - 1))];
                    Color finalColor = Color.FromArgb(ordemValor, ordemValor, ordemValor);
                    imagemFinal.SetPixel(x, y, finalColor);
                }
            }

            return imagemFinal;
        }

        private Bitmap AplicarFiltroMediana(Bitmap bmp) {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap imagemFinal = new Bitmap(width, height);

            int[,] kernel = new int[,] { { -1, -1, -1 }, { -1, 0, -1 }, { -1, -1, -1 } };

            int kernelWidth = kernel.GetLength(1);
            int kernelHeight = kernel.GetLength(0);
            int kernelX = kernelWidth / 2;
            int kernelY = kernelHeight / 2;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    List<int> valores = new List<int>();

                    for (int ky = -kernelY; ky <= kernelY; ky++)
                    {
                        for (int kx = -kernelX; kx <= kernelX; kx++)
                        {
                            int pixelPosX = x + kx;
                            int pixelPosY = y + ky;

                            if (pixelPosX >= 0 && pixelPosX < width && pixelPosY >= 0 && pixelPosY < height)
                            {
                                Color color = bmp.GetPixel(pixelPosX, pixelPosY);
                                int value = (color.R + color.G + color.B) / 3;

                                valores.Add(value);
                            }
                        }
                    }

                    valores.Sort();

                    int medianaValor = valores[valores.Count / 2];
                    Color finalColor = Color.FromArgb(medianaValor, medianaValor, medianaValor);
                    imagemFinal.SetPixel(x, y, finalColor);
                }
            }
            return imagemFinal;
        }

        //------------------------ Detecção de Bordas ----------------------------------

        private void btnSobel_Click(object sender, EventArgs e) {
            Bitmap bmp = new Bitmap(imageURL);
            //Bitmap imagemFinal = new Bitmap(bmp.Width, bmp.Height);

            int[][] sobelX = {
                new int[] {-1, 0, 1},
                new int[] {-2, 0, 2},
                new int[] {-1, 0, 1}
            };

            int[][] sobelY = {
                new int[] {-1, -2, -1},
                new int[] { 0, 0, 0},
                new int[] { 1, 2, 1}
            };

            imgFinal.Image = AplicarSobel(bmp, sobelX, sobelY);
        }

        private Bitmap AplicarSobel(Bitmap bmp,  int[][] sobelx, int[][]sobely) {
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap imageFinal = new Bitmap(width, height);

            Color p;



                    for (int i = 1; i < width-1; i++)
                    {
                        for (int j = 1; j < height-1; j++)
                        {
                            int dx = bmp.GetPixel(i - 1, j - 1).R * sobelx[0][0] + bmp.GetPixel(i, j - 1).R * sobelx[0][1] + bmp.GetPixel(i + 1, j - 1).R * sobelx[0][2]
                              + bmp.GetPixel(i - 1, j).R * sobelx[1][0] + bmp.GetPixel(i, j).R * sobelx[1][1] + bmp.GetPixel(i + 1, j).R * sobelx[1][2]
                              + bmp.GetPixel(i - 1, j + 1).R * sobelx[2][0] + bmp.GetPixel(i, j + 1).R * sobelx[2][1] + bmp.GetPixel(i + 1, j + 1).R * sobelx[2][2];

                            int dy = bmp.GetPixel(i - 1, j - 1).R * sobely[0][0] + bmp.GetPixel(i, j - 1).R * sobely[0][1] + bmp.GetPixel(i + 1, j - 1).R * sobely[0][2]
                                   + bmp.GetPixel(i - 1, j).R * sobely[1][0] + bmp.GetPixel(i, j).R * sobely[1][1] + bmp.GetPixel(i + 1, j).R * sobely[1][2]
                                   + bmp.GetPixel(i - 1, j + 1).R * sobely[2][0] + bmp.GetPixel(i, j + 1).R * sobely[2][1] + bmp.GetPixel(i + 1, j + 1).R * sobely[2][2];
                            double derivata = Math.Sqrt((dx * dx) + (dy * dy));

                            if (derivata > 255)
                            {
                                imageFinal.SetPixel(i, j, Color.White);
                            }
                            else
                            {
                                imageFinal.SetPixel(i, j, Color.FromArgb(255, (int)derivata, (int)derivata, (int)derivata));
                            }
                        }
                    }
            return imageFinal;
        }
    }
}