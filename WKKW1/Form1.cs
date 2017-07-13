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
using System.Windows.Forms.DataVisualization.Charting;

// Allow managed code to call unmanaged functions that are implemented in a DLL
using System.Runtime.InteropServices;

namespace WKKW1
{


    public partial class Form1 : Form
    {
        int InputIteration = 0;
        int InputPopulation = 0;
        

        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CreateNew(int Input);
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void HorseTest();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SaveBest();
        [DllImport("WKKW.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr BinGenerator();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getBest();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getPopulationSize();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float getPopulationFC(int i);
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MinMaxSelector(float GFC);
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void NewGenerationSelector();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void BreedSelector();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ParentSelector();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CrossBreed();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ApplyPopulation();
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void FindBest();

        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getJumpPoints(int i);
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int getCrossPoints(int i);
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern float getDressagePoints(int i);


        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool Chance(double Percent);
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool ifStop(bool Iteration, int It, float Best, float Argument);
        [DllImport("WKKW.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool ifStop2Arguments(int ActualIteration, int MaxIteration, float Best, float MaxBest);

        public Form1()
        {
            InitializeComponent();
            //this.BackColor = Color.White;
        }

       
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var input1 = textBox1.Text;
            var input2 = textBox2.Text;

            int integer;
            if (Int32.TryParse(textBox1.Text, out integer) == true)
            {

                if (textBox1.Text != null && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    InputPopulation = Int32.Parse(input1);

                    if (InputPopulation > 100)
                    {
                        InputPopulation = 100;
                        textBox1.Text = "100";
                        textBox1.Invalidate();
                    }
                    if (InputPopulation <= 0)
                    {
                        InputPopulation = 2;
                        textBox1.Text = "2";
                        textBox1.Invalidate();
                    }
                }
                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    button1.Enabled = true;
                }
                else button1.Enabled = false;

            }
            else textBox1.Text = "";
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var input1 = textBox1.Text;
            var input2 = textBox2.Text;

            int integer;
            if (Int32.TryParse(textBox1.Text, out integer) == true)
            {
                if (textBox2.Text != null && !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    InputIteration = Int32.Parse(input2);
                    if (InputIteration > 200)
                    {
                        InputIteration = 200;
                        textBox2.Text = "200";
                        textBox2.Invalidate();
                    }
                    if (InputIteration <= 0)
                    {
                        InputIteration = 2;
                        textBox2.Text = "2";
                        textBox2.Invalidate();
                    }
                }

                if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    button1.Enabled = true;
                }
                else button1.Enabled = false;
            }
            else textBox1.Text = "";
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            

            while (chart1.Series.Count > 0) { chart1.Series.RemoveAt(0); }
            List<float> Bests = new List<float>();
            //PictureBox[] pictureBoxs = new PictureBox[InputPopulation];
            List<PictureBox> lst = new List<PictureBox>();
            

            float GlobalFC; //Globalne FC
            int n = 1; //Iteracja - zaczynamy od pierwszej
            bool Iteration; //Do warunków stopu
            bool stop = true;
            float StopArgument;
            int Key;
            stop = true;
            Random random = new Random();

            CreateNew(InputPopulation); //Generowanie nowej populacji - wejściowej
            label5.Text = getPopulationSize().ToString();

            

            Bitmap baseImage;
            Bitmap overlayImage;
            Bitmap overlayImage0;
            Bitmap overlayImage1;
            Bitmap overlayImage2;
            Bitmap overlayImage3;
            Bitmap overlayImage4;
            Bitmap overlayImage5;
            Bitmap overlayImage6;
            Bitmap overlayImage7;
            Bitmap overlayImage8;
            Bitmap overlayImage9;
            Bitmap overlayImage10;

            baseImage = (Bitmap)Image.FromFile("WKKWimages\\skoki500.png");
            baseImage.SetResolution(110,110);

            overlayImage = (Bitmap)Image.FromFile(@"WKKWimages\\horse30.png");
            overlayImage.SetResolution(100, 100);
            overlayImage0 = (Bitmap)Image.FromFile("WKKWimages\\horse0.png");
            overlayImage0.SetResolution(100, 100);
            overlayImage1 = (Bitmap)Image.FromFile("WKKWimages\\horse1.png");
            overlayImage1.SetResolution(100, 100);
            overlayImage2 = (Bitmap)Image.FromFile("WKKWimages\\horse2.png");
            overlayImage2.SetResolution(100, 100);
            overlayImage3 = (Bitmap)Image.FromFile("WKKWimages\\horse3.png");
            overlayImage3.SetResolution(100, 100);
            overlayImage4 = (Bitmap)Image.FromFile("WKKWimages\\horse4.png");
            overlayImage4.SetResolution(100, 100);
            overlayImage5 = (Bitmap)Image.FromFile("WKKWimages\\horse5.png");
            overlayImage5.SetResolution(100, 100);
            overlayImage6 = (Bitmap)Image.FromFile("WKKWimages\\horse6.png");
            overlayImage6.SetResolution(100, 100);
            overlayImage7 = (Bitmap)Image.FromFile("WKKWimages\\horse7.png");
            overlayImage7.SetResolution(100, 100);
            overlayImage8 = (Bitmap)Image.FromFile("WKKWimages\\horse8.png");
            overlayImage8.SetResolution(100, 100);
            overlayImage9 = (Bitmap)Image.FromFile("WKKWimages\\horse9.png");
            overlayImage9.SetResolution(100, 100);
            overlayImage10 = (Bitmap)Image.FromFile("WKKWimages\\horse10.png");
            overlayImage10.SetResolution(100, 100);

            var finalImage = new Bitmap(baseImage.Width, baseImage.Height, PixelFormat.Format32bppArgb);
            var graphics = Graphics.FromImage(finalImage);
            graphics.CompositingMode = CompositingMode.SourceOver;

            

            do
            { //Nieskończona pętla
                /*
                for (int i = 1; i < InputPopulation; i++)
                {

                    int intrandom = random.Next(50, 200);
                    PictureBox pb = new PictureBox()
                    {
                        Size = new Size(30, 30),

                        Location = new Point(5, intrandom),
                        //BorderStyle = BorderStyle.Fixed3D,
                        Image = Image.FromFile("C:\\Users\\Galaxis\\Desktop\\WKKWimages\\horse30.png"),
                        BackColor = Color.Transparent
                };
                    lst.Add(pb);
                    this.Controls.Add(pb);
                    //pb.BringToFront();
                    pb.Parent = picture;
                    pb.BackColor = Color.Transparent;

                } */



                HorseTest(); //Test
                System.Windows.Forms.Label x;
                GlobalFC = 0; //Zerowanie FC <- WYMAGANE
                SaveBest(); //Zapis najlepszego, o ile lepszy niż to co w pamięci
                if (ifStop2Arguments(n, InputIteration, getBest(), 28))
                {
                    stop = false;
                    //break; //Sprawdzanie czy stop i przerwanie jeżeli tak
                    label5.Text = "Ilosc wykonanych iteracji: " + n.ToString();
                    label6.Text = "Najlepszy osobnik: " + getBest().ToString() + "/30";             
                }
                for (int i = 0; i < getPopulationSize(); i++) GlobalFC += getPopulationFC(i); //Sumowanie globalnego FC ze wszystkich koni
                MinMaxSelector(GlobalFC); //Wyznaczanie min max na podstawie globalnego FC
                NewGenerationSelector(); //Pierwsza ruletka - losowanie min i max
                BreedSelector(); //Druga ruletka - losowanie dla 0.5
                ParentSelector(); //Wyznaczenie listy rodziców
                CrossBreed(); //Rozmnażanie z rodziców
                ApplyPopulation(); //Zaakceptowanie nowej populacji (mutacja tutaj też jest)
                FindBest(); //Sprawdzenie najgorszego z najlepszym z poprzedniej
                Bests.Add(getBest());
                            /*std::cout
                                << "Najlepszy FC: "
                                << BEST.FC << " w "
                                << n << " iteracji."
                                << std::endl; */
                //label5.Text = n.ToString();
                n++; //Zwiększanie globalnej iteracji
            } while (stop);
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;

            Series series = this.chart1.Series.Add("Best");


            for (int i = 0; i < Bests.Count; i++)
            {

                // Add point.
                series.Points.Add(Bests[i]);
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 2;

            }


            graphics.DrawImage(baseImage, 0, 0);
            for (int i = 0; i < getPopulationSize(); i++)
            {
                int Jump = getJumpPoints(i);
                int x;
                int y;

                if (Jump == 0)
                {
                    int randomx = random.Next(323, 352);
                    int randomy = random.Next(54, 77);
                    graphics.DrawImage(overlayImage0, randomx, randomy);
                }
                if (Jump == 1)
                {
                    int randomx = random.Next(202, 250);
                    int randomy = random.Next(124, 137);
                    graphics.DrawImage(overlayImage1, randomx, randomy);
                }
                if (Jump == 2)
                {
                    int randomx = random.Next(195, 225);
                    int randomy = random.Next(20, 24);
                    graphics.DrawImage(overlayImage2, randomx, randomy);
                }
                if (Jump == 3)
                {
                    int randomx = random.Next(393, 393);
                    int randomy = random.Next(50, 80);
                    graphics.DrawImage(overlayImage3, randomx, randomy);
                }
                if (Jump == 4)
                {
                    int randomx = random.Next(205, 253);
                    int randomy = random.Next(171, 175);
                    graphics.DrawImage(overlayImage4, randomx, randomy);
                }
                if (Jump == 5)
                {
                    int randomx = random.Next(80, 114);
                    int randomy = random.Next(95, 110);
                    graphics.DrawImage(overlayImage5, randomx, randomy);
                }
                if (Jump == 6)
                {
                    int randomx = random.Next(0, 5);
                    int randomy = random.Next(90, 120);
                    graphics.DrawImage(overlayImage6, randomx, randomy);
                }
                if (Jump == 7)
                {
                    int randomx = random.Next(16, 60);
                    int randomy = random.Next(183, 208);
                    graphics.DrawImage(overlayImage7, randomx, randomy);
                }
                if (Jump == 8)
                {
                    int randomx = random.Next(284, 305);
                    int randomy = random.Next(134, 170);
                    graphics.DrawImage(overlayImage8, randomx, randomy);
                }
                if (Jump == 9)
                {
                    int randomx = random.Next(198, 250);
                    int randomy = random.Next(63, 72);
                    graphics.DrawImage(overlayImage9, randomx, randomy);
                }
                if (Jump == 10)
                {
                    int randomx = random.Next(59, 136);
                    int randomy = random.Next(8, 27);
                    graphics.DrawImage(overlayImage10, randomx, randomy);
                }
                //else graphics.DrawImage(overlayImage, 1, 1);

            }

            //show in a winform picturebox
            //pictureBox1.Image = finalImage;

            //save the final composite image to disk
            finalImage.Save("WKKWimages\\final.png", ImageFormat.Png);

            var picture = new PictureBox
            {
                Name = "skoki",
                Size = new Size(500, 271),
                Location = new Point(5, 250),
                //Image = Image.FromFile("C:\\Users\\Galaxis\\Desktop\\WKKWimages\\final.png"),

            };
            using (Bitmap bmp = Bitmap.FromFile("WKKWimages\\final.png") as Bitmap)
            {
                picture.Image = new Bitmap(bmp);
            }
            this.Controls.Add(picture);
            picture.BringToFront();


        }



        private void label5_Click(object sender, EventArgs e)
        {
            
        }


    }
}
