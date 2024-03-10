using System.Drawing.Imaging;

namespace Homework
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "Select an image file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        originalImage = new Bitmap(openFileDialog.FileName);
                        originalPictureBox.Image = originalImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading the image: " + ex.Message);
                    }
                }
            }
        }

        private void downsizeButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            if (!double.TryParse(scaleTextBox.Text, out double scaleFactor) || scaleFactor <= 0 || scaleFactor > 100)
            {
                MessageBox.Show("Please enter a valid scaling factor (1-100).");
                return;
            }

            int newWidth = (int)(originalImage.Width * scaleFactor / 100);
            int newHeight = (int)(originalImage.Height * scaleFactor / 100);

            Bitmap downscaledImage = DownscaleImage(originalImage, newWidth, newHeight);

            downscaledPictureBox.Image = downscaledImage;
        }

        private Bitmap DownscaleImage(Bitmap original, int newWidth, int newHeight)
        {
            Bitmap downscaledImage = new Bitmap(newWidth, newHeight);

            BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData downscaledData = downscaledImage.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            unsafe
            {
                byte* originalScan0 = (byte*)originalData.Scan0;
                byte* downscaledScan0 = (byte*)downscaledData.Scan0;

                for (int y = 0; y < newHeight; y++)
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        int originalX = (int)(x * original.Width / (float)newWidth);
                        int originalY = (int)(y * original.Height / (float)newHeight);

                        byte* originalPixel = originalScan0 + originalY * originalData.Stride + originalX * 3;
                        byte* downscaledPixel = downscaledScan0 + y * downscaledData.Stride + x * 3;

                        downscaledPixel[0] = originalPixel[0]; // Blue
                        downscaledPixel[1] = originalPixel[1]; // Green
                        downscaledPixel[2] = originalPixel[2]; // Red
                    }
                }
            }

            original.UnlockBits(originalData);
            downscaledImage.UnlockBits(downscaledData);

            return downscaledImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void scaleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
