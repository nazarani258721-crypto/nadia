using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_menghitung_luas_dan_keliling_bangunan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program menghitumg luas dan keliling bangunan ===");
            Console.WriteLine("Menu Pilihan : ");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Segitiga");
            Console.WriteLine("3. Luas Lingkaran");
            Console.WriteLine("4. Keliling Persegi Panjang");
            Console.WriteLine("5. Keliling Lingkaran");
            Console.Write("Masukan pilihan (1-5)  =  ");
            int bangunan = int.Parse(Console.ReadLine());
            Console.Write("Masukan Panjang        =  ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Masukan lebar          =  ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Masukan alas untuk menghitung suatu segitiga        =  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Masukan tinggi untuk menghitung suatu segitiga      =  ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Masukan jari jari untuk menghitung suatu lingkaran  =  ");
            int r = int.Parse(Console.ReadLine());
            int lp = 0;
            int ls = 0;
            int ll = 0; 
            int kpp = 0;
            int kl = 0;

            switch (bangunan)
            {
                case 1: Console.WriteLine("Luas Persegi Panjang"); break;
                case 2: Console.WriteLine("Luas Segitiga"); break;
                case 3: Console.WriteLine("Luas Lingkaran"); break;
                case 4: Console.WriteLine("Keliling Persegi Panjang"); break;
                case 5: Console.WriteLine("Keliling Lingkaran"); break;

            }
            if (bangunan == 1)
            {
                lp = p * l;
                Console.WriteLine("Luas Persegi Panjang  =  " + lp);
            }
            else if (bangunan == 2)
            {
                ls = 1 / 2 * a * t;
                Console.WriteLine("Luas Segitiga  =  " + ls);
            }
            else if (bangunan == 3)
            {
                ll = 22 / 7 * r * r;
                Console.WriteLine("Luas Lingkaran  =  " + ll);
            }
            else if (bangunan == 4)
            {
                kpp = 2 * p + 2 * l;
                Console.WriteLine("Keliling Persegi Panjang  =  " + kpp);
            }
            else 
            {
                kl = 2 * 22 / 7 * r;
                Console.WriteLine("Keliling Lingkaran  =  " + kl);
            }

        }

           
    }
}
