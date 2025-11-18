using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Program_percabangan_karakter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program untuk mengetahui karakter yang diinputkan,
            // apakah huruf besar, huruf kecil, spasi, digit, atau yang lainnya
            Console.Write("Masukan karakter  =  ");
            char karakter = Console.ReadKey().KeyChar; // membaca 1 karakter
            Console.WriteLine(); // Pindah baris

            if (char.IsUpper(karakter))
            {
                Console.WriteLine("karakter yang diinputkan adalah huruf besar. ");
            }
            else if (char.IsLower(karakter))
            {
                Console.WriteLine("karakter yang diinputkan adalah huruf kecil. ");
            }
            else if (char.IsWhiteSpace(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalah spasi. ");
            }
            else if (char.IsDigit(karakter))
            {
                Console.WriteLine("Karakter yang diinputkan adalaah digit (angka). ");
            }
            else
            {
                Console.WriteLine("karakter yang diinputkan adalah karakter laainnya (simbol). ");
            }
        }
    }
}
