using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spain
{
    class Program
    {
        void First()
        {
            
        }

        static void Main(string[] args)
        {

            int SumaWag = 0;
            double X = 0, Y = 0, Z = 0, Xs, Ys, Zs, Lat, Lon, Hyp;
            List<float> latList = new List<float>();
            List<float> lonList = new List<float>();
            string contents = File.ReadAllText("list_bez_wysp.txt");

            var input = contents;
            var outputs = input.Split('[', ']').Where((item, index) => index % 2 != 0).ToList();
            foreach (var output in outputs)
            {

                if (output != null && !String.IsNullOrWhiteSpace(output))
                {
                    int idx = output.LastIndexOf(',');
                    var lon = output.Substring(0, idx);
                    var lat = output.Substring(idx + 1);

                    latList.Add(float.Parse(lat, CultureInfo.InvariantCulture.NumberFormat));
                    lonList.Add(float.Parse(lon, CultureInfo.InvariantCulture.NumberFormat));
                    SumaWag++;

                }
            }

            /*
             * Ze stopni na radiany
             * */
            for (int i = 0; i < latList.Count; i++)
            {
                latList[i] = latList[i] * (float)0.01745329;
            }
            for (int i = 0; i < lonList.Count; i++)
            {
                lonList[i] = lonList[i] * (float)0.01745329;
            }

            /*
             * Średnia ważona współrzędnych kartezjańskich
             * X1= cos(Radian_from_Lat) * cos(Radian_from_Lon)
             * Y1= cos(Radian_from_Lat) * sin(Radian_from_Lon)
             * Z1= sin(Radian_from_Lat)

             * X = (X1*waga + X2*waga + X3*waga + ... + X42*waga)/SumaWag
             * Y = (Y1*waga + Y2*waga + Y3*waga + ... + Y42*waga)/SumaWag
             * Z = (Z1*waga + Z2*waga + Z3*waga + ... + Z42*waga)/SumaWag 
             * */
            for (int i = 0; i < SumaWag; i++)
            {
                X += Math.Cos(latList[i]) * Math.Cos(lonList[i]);
                Y += Math.Cos(latList[i]) * Math.Sin(lonList[i]);
                Z += Math.Sin(latList[i]);
            }
            Xs = X / SumaWag;
            Ys = Y / SumaWag;
            Zs = Z / SumaWag;
            Console.WriteLine("Xs = " + Xs);
            Console.WriteLine("Ys = " + Ys);
            Console.WriteLine("Zs = " + Zs);


            /*
             * Konwertowanie do  lat i lon
             * Lon = atan2(X, Y)
             * Hyp = sqrt(X * X + Y * Y)
             * Lat = atan2(Hyp, Z)
             * */
            Lon = Math.Atan2(Ys, Xs);
            Hyp = Math.Sqrt((Xs * Xs) + (Ys * Ys));
            Lat = Math.Atan2(Zs, Hyp);

            Console.WriteLine("Lon = " + Lon);
            Console.WriteLine("Hyp = " + Hyp);
            Console.WriteLine("Lat = " + Lat);

            /*
             * Ostatni krok to obliczenie konkretnych lon i lat - czyli długości i szerokości geograficznej naszego środka Hiszpanii w formie stopni decymalnych.
             * LON = Lon * (180 / PI)
             * LAT = Lat * (180 / PI)
             */
            Lon = Lon * (180 / Math.PI);
            Lat = Lat * (180 / Math.PI);



            Console.WriteLine(Lat);
            Console.WriteLine(Lon);
            Console.WriteLine(SumaWag);



            Console.ReadLine();
        }
    }
}
