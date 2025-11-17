using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._3_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inisialisasi variabel untuk menyimpan input
            string inputUser = "";

            Console.WriteLine("Progam akan terus berjalan hingga nada mengetik 'Keluar' .");

            //Pertualangan selama isi variabel inputUser TIDAK SAMA DENGAN"keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar'untuk berhenti): ");
                inputUser = Console.ReadLine();//Baca input dari user 

                Console.WriteLine("Anda mengetik: " + inputUser);
            }

            Console.WriteLine("\nProgam selesai. Terima kasih!");
        }
    }
}
