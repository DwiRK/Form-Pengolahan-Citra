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
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
    }
}
