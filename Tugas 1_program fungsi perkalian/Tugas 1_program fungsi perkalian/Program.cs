using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1_program_fungsi_perkalian
{
    internal class Program
    {
        static int Kali(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukan angka pertama  :  ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan angka kedua    :  ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan angka ketiga   :  ");
            int z = Convert.ToInt32(Console.ReadLine());

            int hasil = Kali(x, y, z);
            Console.WriteLine("Hasil perkalian    :  " + hasil);
        }
    }
}
