using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._5_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Insialisasi variabel penghitung (counter)
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20:");

            //2. Blok 'do-while'
            do
            {
                // Tampilkan nilai variabel 'angka' saat ini 
                Console.WriteLine(angka);

                //Tambahan nilai 'angka' sebanyak 1 (increment)
                angka++;
                //Uji kondisi:Loop berlajut selama'angka' kurang dari atau sama dengan
            } while (angka <= 20);

            Console.WriteLine("selesai.");
        }
    }
}
