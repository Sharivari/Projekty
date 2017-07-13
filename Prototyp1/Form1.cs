using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototyp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*~~~~~~~~~~~Clicking "Generate" button~~~~~~~~~~~~~*/
        private void button1_Click(object sender, EventArgs e)
        {
            NowePNG();         
        }

     
        private void DrawCircle(int x, int y, int width, int height)
        {
            Bitmap Circle = new Bitmap(250, 250);
            Graphics g = Graphics.FromImage(Circle);
            System.Drawing.SolidBrush brush1 = new System.Drawing.SolidBrush(System.Drawing.Color.Brown);
            Random rnd = new Random();

            for (int i = 0; i <= 40; i ++)
            {
                x = rnd.Next(0, 250);
                y = rnd.Next(0, 250);

                int RandomW = rnd.Next(-(width/5), (width / 5));
                width = width + RandomW;
                
                g.FillEllipse(brush1, new System.Drawing.Rectangle(x, y, width, width));
            }
            imageList1.Images.Add("Circle", Circle);
        }

        private void ChangeBaseColor(byte r, byte g, byte b)
        {
            /*~~~~~~~~~~~Function from the web~~~~~~~~~~~~~*/
            /* https://msdn.microsoft.com/pl-pl/library/5ey6h79d(v=vs.110).aspx */

            // Create a new bitmap.
            Bitmap BaseBitmap = new Bitmap("Images\\base.png");

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, BaseBitmap.Width, BaseBitmap.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                BaseBitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                BaseBitmap.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * BaseBitmap.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // Set every second, third and fourth value - four because it's png.
            for (int counter = 2; counter < rgbValues.Length; counter += 4)
            {
                rgbValues[counter] = r;
                rgbValues[counter - 1] = g;
                rgbValues[counter - 2] = b;
            }

            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            BaseBitmap.UnlockBits(bmpData);

            var graphics = Graphics.FromImage(BaseBitmap);
            graphics.CompositingMode = CompositingMode.SourceOver;
            graphics.DrawImage(BaseBitmap, 0, 0);
            BaseBitmap.Save("Images\\finalbase.png");
            graphics.Dispose();
            BaseBitmap.Dispose();
        }



        private void NowePNG()
        {
            /*~~~~~~~~~~~Circles generation~~~~~~~~~~~~~*/
            DrawCircle(50, 50, 30, 30);

            /*~~~~~~~~~~~Changing the base's color~~~~~~~~~~~~~*/
            ChangeBaseColor(234, 224, 215);

            /*~~~~~~~~~~~Assembling textures into a final image~~~~~~~~~~~~~*/
            Bitmap baseImage;
            Bitmap MarkingImage;
            Bitmap OverLayerImage;

            baseImage = (Bitmap)Image.FromFile("Images\\finalbase.png");
            baseImage.SetResolution(200, 200);

            MarkingImage = (Bitmap)imageList1.Images[0];
            MarkingImage.SetResolution(100, 100);

            OverLayerImage = (Bitmap)Image.FromFile(@"Images\\OverLayer.png");
            OverLayerImage.SetResolution(200, 200);

            var finalImage = new Bitmap(baseImage.Width, baseImage.Height, PixelFormat.Format32bppArgb);
            var graphicss = Graphics.FromImage(finalImage);
            graphicss.CompositingMode = CompositingMode.SourceOver;

            graphicss.DrawImage(baseImage, 0, 0);
            graphicss.DrawImage(MarkingImage, 0, 0);
            graphicss.DrawImage(OverLayerImage, 0, 0);

            finalImage.Save("Images\\final.png", ImageFormat.Png);

            var picture = new PictureBox
            {
                Name = "Image",
                Size = new Size(500, 500),
                Location = new Point(5, 5),
            };
            using (Bitmap bmp2 = Bitmap.FromFile("Images\\final.png") as Bitmap)
            {
                picture.Image = new Bitmap(bmp2);
            }
            this.Controls.Add(picture);
            picture.BringToFront();
            baseImage.Dispose();
            graphicss.Dispose();
            finalImage.Dispose();
            imageList1.Dispose();
        }
    }
}
