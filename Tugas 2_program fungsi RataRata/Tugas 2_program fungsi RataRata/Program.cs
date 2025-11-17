using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_2_program_fungsi_RataRata
{
    internal class Program
    {
        static double RataRata(double a, double b, double c)
        {
            double rata = (a + b + c) / 3;
            return rata;
        }
        static void Main(string[] args)
        {
            Console.Write("masukan nilai pertama  :  ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("masukan nilai kedua    :  ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("masukan nilai ketiga   :  ");
            double z = Convert.ToDouble(Console.ReadLine());

            double hasil = RataRata(x, y, z);
            Console.WriteLine("Hasil dari nilai rata-rata adalah  :  " + hasil);
        }
    }
}
