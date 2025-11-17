using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._1_nadia_nazarni_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Membuat array dengan 5 elemen tipe data string
            string[] siswa = new string[5];

            //Mengisi elemen array
            siswa[0] = "Andi";
            siswa[1] = "Budi";
            siswa[2] = "vano";
            siswa[3] = "adit";
            siswa[4] = "bambang";

            //Menampilkan isi array tanpa perulangan
            Console.WriteLine("Daftar Nama siswa:");
            Console.WriteLine("Siswa Ke-1: " + siswa[0]);
            Console.WriteLine("Siswa Ke-2: " + siswa[1]);
            Console.WriteLine("Siswa Ke-3: " + siswa[2]);
            Console.WriteLine("Siswa Ke-4: " + siswa[3]);
            Console.WriteLine("Siswa Ke-5: " + siswa[4]);
        }
    }
}
