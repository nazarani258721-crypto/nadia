using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._4_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Insialisasi variabel penghitung(counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur:");
            //2.Perulangan 'while'
            //KOndisi:Selama  nilai 'hitungan' lebih besar dari 0
            while (hitungan > 0)
            {
                //Blok kode di dalam perulangan 
                Console.WriteLine($"Hitungan: {hitungan}");

                //3.Update variabel penghitung (decrement/pengurangan)
                //ini PENTING agar perulangan tidak menjadi loop tak terbatas (infinite loop)
                hitungan = hitungan - 1;
                // atau bisa juga ditulis:hitungan--;
            }
            //kode setelah perulangan selesai 
            Console.WriteLine("selesai! Hitungan mundur telah berakhir. ");
        }
    }
}
