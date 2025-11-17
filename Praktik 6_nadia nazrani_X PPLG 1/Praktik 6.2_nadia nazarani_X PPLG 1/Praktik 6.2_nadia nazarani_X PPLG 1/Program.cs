using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._2_nadia_nazarani_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Membuat array integer dengan keyboard
            int[] angka = new int[5];

            //input elemen array dari keyboard
            Console.Write("masukkan angka -1 :");
            angka[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan angka -2 :");
            angka[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan angka -3 :");
            angka[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan angka -4 :");
            angka[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan angka -5 :");
            angka[4] = Convert.ToInt32(Console.ReadLine());

            //Menampilkan isi array tanpa perulangan
            Console.WriteLine("\nData yang anda masukkan:");
            Console.WriteLine("Nilai ke-1: " + angka[0]);
            Console.WriteLine("Nilai ke-2: " + angka[1]);
            Console.WriteLine("Nilai ke-3: " + angka[2]);
            Console.WriteLine("Nilai ke-4: " + angka[3]);
            Console.WriteLine("Nilai ke-5: " + angka[4]);
        }
    }
}
