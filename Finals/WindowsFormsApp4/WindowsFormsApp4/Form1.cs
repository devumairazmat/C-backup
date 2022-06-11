using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = bmp;
            }
            else
            {
                MessageBox.Show("No picture");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox1.Image = bmp;
            }
            else
            {
                MessageBox.Show("No picture");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Rectangle rect = new Rectangle(0, 0, 300, 300);
            Bitmap cloneImage = bmp.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
            pictureBox1.Image = cloneImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x, y;
            for (x = 0; x < bmp.Width; x++)
            {
                for (y = 0; y < bmp.Height; y++)
                {
                    Color old_pixel_colour = bmp.GetPixel(x, y);
                    Color new_pixel_colour = Color.FromArgb(100,old_pixel_colour.R,0,0);
                    bmp.SetPixel(x, y, new_pixel_colour);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int x, y;
            for (x = 0; x < bmp.Width; x++)
            {
                for (y = 0; y < bmp.Height; y++)
                {
                    Color old_pixel_colour = bmp.GetPixel(x, y);
                    Color new_pixel_colour = Color.FromArgb(255 - old_pixel_colour.R,
                        255 - old_pixel_colour.G, 255 - old_pixel_colour.B);
                    bmp.SetPixel(x, y, new_pixel_colour);
                }
            }
            pictureBox1.Image = bmp;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string save_path = "";
            saveFD.InitialDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFD.FileName = "default";
            saveFD.Filter = "JPEG|*.jpeg";

            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                save_path = saveFD.FileName;
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                bmp.Save(save_path, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("ImageSaved");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
