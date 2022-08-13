using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDevDonusumler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implicit Convesion (Bilinçsiz Dönüşüm)
            Console.WriteLine("***** Implicit Conversion ******");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "asim";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            //Explicit Conservision (Bilinçli Dönüşüm)

            Console.WriteLine("**********Expilicit Consevision************");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("y: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("y: " + v);

            //ToString Methodu

            Console.WriteLine("***ToString Methodu***");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            //System.Convert 
            Console.WriteLine("****System.Convert sınıfı *****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);

            //parse
            Console.WriteLine("****parse methodu*****");
            ParseMethodu();
        }

        public static void ParseMethodu() 
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double d1;

            rakam1 = Int32.Parse(metin1);
            d1 = double.Parse(metin2);
            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double : " + d1);
        }
        
    }
}
    