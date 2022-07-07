namespace Konfolusi_Dan_Image_Filtering
{
    public partial class Form1 : Form
    {
        String fileLocation ="";
        Bitmap? gambarGrayscale;
        public Form1()
        {
            InitializeComponent();
        }

        private void Browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Browse Image";
            openFile.Filter = "Choose Image (*.jpeg, *.png) |*jpeg;*png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileLocation = openFile.FileName;
                Image image = Image.FromFile(fileLocation);
                OriginalPicture.Image = image;
            }
        }

        private void Convert_Grayscle_button_Click(object sender, EventArgs e)
        {
            //runtime eror handle
            try
            {
                gambarGrayscale = new Bitmap(fileLocation);
                Bitmap gambarOriginal = new Bitmap(fileLocation);
                for (int y = 0; y < gambarOriginal.Height; y++)
                {
                    for (int x = 0; x < gambarOriginal.Width; x++)
                    {
                        Color c = gambarOriginal.GetPixel(x, y);

                        int alpha = c.A;
                        int red = c.R;
                        int green = c.G;
                        int blue = c.B;

                        // convert to Grayscale
                        int xg = (int)(red + green + blue) / 3;

                        gambarGrayscale.SetPixel(x, y, Color.FromArgb(alpha, xg, xg, xg));
                    }
                }
                GrayscalePicture.Image = gambarGrayscale;
            }
            catch (Exception eror)
            {
                MessageBox.Show(eror.Message, "Eror File Image Not Found");
            }
        }

        private void Filter_Image_button_Click(object sender, EventArgs e)
        {
            //runtime eror handle
            if (gambarGrayscale != null)
            {
                Bitmap FilterImage = new Bitmap(gambarGrayscale);

                //karnel
                float[] k =  { 0.5f ,        //   0  0.5  0
                         0.5f, 0.5f, 0.5f,   // 0.5  0.5  0.5
                               0.5f };       //   0  0.5  0
                for (int y = 1; y < gambarGrayscale.Height - 1; y++)
                {
                    for (int x = 1; x < gambarGrayscale.Width - 1; x++)
                    {
                        Color c1 = gambarGrayscale.GetPixel(x - 1, y);
                        Color c2 = gambarGrayscale.GetPixel(x + 1, y);
                        Color c3 = gambarGrayscale.GetPixel(x, y - 1);
                        Color c4 = gambarGrayscale.GetPixel(x, y + 1);
                        Color c5 = gambarGrayscale.GetPixel(x, y);

                        int w1 = c1.R;
                        int w2 = c2.R;
                        int w3 = c3.R;
                        int w4 = c4.R;
                        int w5 = c5.R;

                        int h = (int)(k[0] * w1 + k[1] * w2 + k[2] * w3 + k[3] * w4 + +k[4] * w5);

                        if (h < 0) h = 0;
                        if (h > 255) h = 255;

                        FilterImage.SetPixel(x, y, Color.FromArgb(h, h, h));
                    }
                }
                FilterPicture.Image = FilterImage;
            }
            else
            {
                MessageBox.Show("Eror Gambar Belum Di Grayscale Atau Belum Dimuat", "Eror");
            }
        }
    }
}