namespace AlteradorDeImagens
{
    public partial class Home : Form
    {
        String imageURL = "";
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImagem1_Click(object sender, EventArgs e)
        {
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

        private void btnCinza_Click(object sender, EventArgs e)
        {
            Bitmap bmt = new Bitmap(imageURL);
            int width = bmt.Width;
            int height = bmt.Height;
            Color p;

            for(int y = 0; y < height; y++) 
            {
                for(int x = 0; x < width; x++)
                {
                    p = bmt.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;
                    bmt.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }
            imgFinal.Image = bmt;
        }
    }
}
