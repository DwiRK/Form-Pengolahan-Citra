using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PengolahanCitraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            redWhiteBox();
            rgbPictureBox(255, 255, 255, 200);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void redWhiteBox()
        {
            Bitmap bmp1 = new Bitmap(200, 140);

            Color merah = Color.FromArgb(255, 0, 0);
            Color putih = Color.FromArgb(255, 255, 255);

            for (int y = 0; y < 70; y++)
            {
                for (int x = 0; x < 200; x++)
                {
                    bmp1.SetPixel(x, y, merah);
                }
            }

            for (int y = 70; y < 140; y++)
            {
                for (int x = 0; x < 200; x++)
                {
                    bmp1.SetPixel(x, y, putih);
                }
            }

            pictureBox3.Image = new Bitmap(bmp1.Height, bmp1.Width);
            pictureBox3.Image = bmp1;
        }

        private void rgbPictureBox(int redColorValue, int greenColorValue, int blueColorValue, int pictureSize)
        {
            Bitmap bitRed = new Bitmap(pictureSize, pictureSize);
            Bitmap bitGreen = new Bitmap(pictureSize, pictureSize);
            Bitmap bitBlue = new Bitmap(pictureSize, pictureSize);

            Color red = Color.FromArgb(redColorValue, 0, 0);
            Color green = Color.FromArgb(0, greenColorValue, 0);
            Color blue = Color.FromArgb(0, 0, blueColorValue);

            for (int y = 0; y < pictureSize; y++)
            {
                for (int x = 0; x < pictureSize; x++)
                {
                    bitRed.SetPixel(x, y, red);
                    bitGreen.SetPixel(x, y, green);
                    bitBlue.SetPixel(x, y, blue);
                }
            }

            redPictureBox.Image = new Bitmap(bitRed.Height, bitRed.Width);
            redPictureBox.Image = bitRed;

            greenPictureBox.Image = new Bitmap(bitGreen.Height, bitGreen.Width);
            greenPictureBox.Image = bitGreen;

            bluePictureBox.Image = new Bitmap(bitBlue.Height, bitBlue.Width);
            bluePictureBox.Image = bitBlue;
        }

        private void generateColorBtn_Click(object sender, EventArgs e)
        {
            int newRedValue, newGreenValue, newBlueValue;            Int32.TryParse(redValue.Text, out newRedValue);            Int32.TryParse(greenValue.Text, out newGreenValue);            Int32.TryParse(blueValue.Text, out newBlueValue);

            rgbPictureBox(newRedValue, newGreenValue, newBlueValue, 200);

            Bitmap bitCampur = new Bitmap(200, 200);

            Color mix = Color.FromArgb(newRedValue, newGreenValue, newBlueValue);

            for (int y = 0; y < 200; y++)            {                for (int x = 0; x < 200; x++)                {                    bitCampur.SetPixel(x, y, mix);                }            }

            mixPictureBox.Image = new Bitmap(bitCampur.Height, bitCampur.Width);            mixPictureBox.Image = bitCampur;
        }

        private void loadPictureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                imgLoadFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgLoadFlip.Image = Image.FromFile(ofd.FileName);

                imgGrayscaleFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgGrayscaleFlip.Image = Image.FromFile(ofd.FileName);

                imgBinerFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgBinerFlip.Image = Image.FromFile(ofd.FileName);

                imgHorizontalFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgHorizontalFlip.Image = Image.FromFile(ofd.FileName);

                imgVerticalFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgVerticalFlip.Image = Image.FromFile(ofd.FileName);

                imgContrastFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgContrastFlip.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp3 = (Bitmap)imgGrayscaleFlip.Image;            Color pixelColor;            imgGrayscaleFlip.Image = new Bitmap(imgGrayscaleFlip.Width, imgGrayscaleFlip.Height);            for (int y = 0; y < bmp3.Height; y++)            {                for (int x = 0; x < bmp3.Width; x++)                {
                    pixelColor = bmp3.GetPixel(x, y);                    int red = pixelColor.R;                    int green = pixelColor.G;                    int blue = pixelColor.B;                    int rata = (int)(red + green + blue) / 3;                    bmp3.SetPixel(x, y, Color.FromArgb(rata, rata, rata));
                }            }            imgGrayscaleFlip.SizeMode = PictureBoxSizeMode.StretchImage;            imgGrayscaleFlip.Image = bmp3;
        }

        private void binerBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp4 = (Bitmap)imgBinerFlip.Image;            Color pixelColor;

            for (int y = 0; y < bmp4.Height; y++)            {                for (int x = 0; x < bmp4.Width; x++)                {                    pixelColor = bmp4.GetPixel(x, y);                    int red = pixelColor.R;                    int green = pixelColor.G;                    int blue = pixelColor.B;                    int rata = (int)(red + green + blue) / 3;                    if (rata < 128) { rata = 0; } else { rata = 255; }                    bmp4.SetPixel(x, y, Color.FromArgb(rata, rata, rata));                }            }

            imgBinerFlip.SizeMode = PictureBoxSizeMode.StretchImage;            imgBinerFlip.Image = bmp4;
        }

        private void horizontalBtn_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)imgHorizontalFlip.Image;

            Color pC; //pixelColor

            int size = source.Height;            if (source.Width < source.Height) size = source.Width;
            {
                Bitmap bmp1 = new Bitmap(size, size);

                for (int y = 0; y < size; y++)
                {
                    for (int x = 0; x < size; x++)
                    {
                        pC = source.GetPixel(size - 1 - x, y);
                        bmp1.SetPixel(x, y, Color.FromArgb(pC.R, pC.G, pC.B));
                    }
                }

                imgHorizontalFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgHorizontalFlip.Image = bmp1;
            }
        }

        private void verticalBtn_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)imgVerticalFlip.Image;

            Color pC; //pixelColor

            int size = source.Width;
            if (source.Height < source.Width) size = source.Height;
            {
                Bitmap bmp2 = new Bitmap(size, size);

                for (int y = 0; y < size; y++)
                {
                    for (int x = 0; x < size; x++)
                    {
                        int a = size - y;
                        pC = source.GetPixel(x, size - 1 - y);
                        bmp2.SetPixel(x, y, Color.FromArgb(pC.R, pC.G, pC.B));
                    }

                }

                imgVerticalFlip.SizeMode = PictureBoxSizeMode.StretchImage;
                imgVerticalFlip.Image = bmp2;
            }
        }

        private void contrastBtn_Click(object sender, EventArgs e)
        {
            Bitmap source = (Bitmap)imgContrastFlip.Image;            Bitmap bmp1 = new Bitmap(source.Height, source.Width);            bmp1 = source;            Color pixelColor;            int k = 30;            for (int y = 0; y < source.Height; y++)            {                for (int x = 0; x < source.Width; x++)                {                    pixelColor = source.GetPixel(x, y);                    int red = pixelColor.R;                    int green = pixelColor.G;                    int blue = pixelColor.B;                    if ((red + k) <= 255) { red = red + k; };
                    if ((green + k) <= 255) { green = green + k; };
                    if ((blue + k) <= 255) { blue = blue + k; };
                    bmp1.SetPixel(x, y, Color.FromArgb(red, green, blue));                }            }

            imgContrastFlip.SizeMode = PictureBoxSizeMode.StretchImage;            imgContrastFlip.Image = bmp1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                imgLoadKuant.SizeMode = PictureBoxSizeMode.StretchImage;
                imgLoadKuant.Image = Image.FromFile(ofd.FileName);

                imgKuantGray16.SizeMode = PictureBoxSizeMode.StretchImage;
                imgKuantGray16.Image = Image.FromFile(ofd.FileName);

                imgKuantGray4.SizeMode = PictureBoxSizeMode.StretchImage;
                imgKuantGray4.Image = Image.FromFile(ofd.FileName);

                imgKuantGray2.SizeMode = PictureBoxSizeMode.StretchImage;
                imgKuantGray2.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void grayKuant16Btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = (Bitmap)imgKuantGray16.Image;            Color pixelColor;            int K = 16;            int th = (int)256 / K;            for (int y = 0; y < bmp1.Height; y++)            {                for (int x = 0; x < bmp1.Width; x++)                {                    pixelColor = bmp1.GetPixel(x, y);                    int red = pixelColor.R;                    int green = pixelColor.G;                    int blue = pixelColor.B;                    int rata = (int)(red + green + blue) / 3;                    int kuantisasi = (int)(rata / th);                    int result = (int)th * kuantisasi;                    bmp1.SetPixel(x, y, Color.FromArgb(result, result, result));
                }            }            imgKuantGray16.Image = new Bitmap(imgKuantGray16.Width, imgKuantGray16.Height);            imgKuantGray16.SizeMode = PictureBoxSizeMode.StretchImage;            imgKuantGray16.Image = bmp1;
        }

        private void grayKuant4Btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = (Bitmap)imgKuantGray4.Image;            Color pixelColor;            int K = 4;            int th = (int)256 / K;            for (int y = 0; y < bmp1.Height; y++)            {                for (int x = 0; x < bmp1.Width; x++)                {                    pixelColor = bmp1.GetPixel(x, y);                    int red = pixelColor.R;                    int green = pixelColor.G;                    int blue = pixelColor.B;                    int rata = (int)(red + green + blue) / 3;                    int kuantisasi = (int)(rata / th);                    int result = (int)th * kuantisasi;                    bmp1.SetPixel(x, y, Color.FromArgb(result, result, result));                }            }            imgKuantGray4.Image = new Bitmap(imgKuantGray4.Width, imgKuantGray4.Height);            imgKuantGray4.SizeMode = PictureBoxSizeMode.StretchImage;            imgKuantGray4.Image = bmp1;
        }

        private void grayKuant2Btn_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = (Bitmap)imgKuantGray2.Image;            Color pixelColor;            int K = 2;            int th = (int)256 / K;            for (int y = 0; y < bmp1.Height; y++)            {                for (int x = 0; x < bmp1.Width; x++)                {                    pixelColor = bmp1.GetPixel(x, y);                    int red = pixelColor.R;                    int green = pixelColor.G;                    int blue = pixelColor.B;                    int rata = (int)(red + green + blue) / 3;                    int kuantisasi = (int)(rata / th);                    int result = (int)th * kuantisasi;                    bmp1.SetPixel(x, y, Color.FromArgb(result, result, result));                }            }            imgKuantGray2.Image = new Bitmap(imgKuantGray2.Width, imgKuantGray2.Height);            imgKuantGray2.SizeMode = PictureBoxSizeMode.StretchImage;            imgKuantGray2.Image = bmp1;
        }
    }
}
