using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1_if_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan angka  =  ");
            int angka = int.Parse(Console.ReadLine());

            if (angka >= 100)
            {
                Console.WriteLine("Lebih besar dari 100");
            }
           
        }
    }
}
