using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.program_percabangan_pembayaran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program untuk mempermudah pembayaran di suatu bioskop
            Console.WriteLine("=== PROGRAM PEMBAYARAN BIOSKOP ===");
            Console.WriteLine("Pilih jenis film");
            Console.WriteLine("1. horor");
            Console.WriteLine("2. romantic");
            Console.Write("Masukan pilihan (1/2) = ");
            int jenis = int.Parse(Console.ReadLine());
            int harga = 0;
            string judul = "";

            // pilihan untuk film horor
            if (jenis == 1)
            {
                Console.WriteLine("\n--- Daftar film horor ---");
                Console.WriteLine("1. kang solah from kang mak x nenek gayung \t Rp 300000");
                Console.WriteLine("2. Death whisperer 3 \t Rp 35000");
                Console.WriteLine("3. rest area \t\t Rp 40000");
                Console.Write("pilih nomor film  =  ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "kang soleh form kang mak x nenek gayung";
                    harga = 30000;
                }
                else if (pilih == 2)
                {
                    judul = "Death whisperer 3";
                    harga = 35000;
                }
                else if (pilih == 3)
                {
                    judul = "Rest area";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid!");
                    return;
                }
            }
            // pilihan untuk film romantic
            else if (jenis == 2)
            {
                Console.WriteLine("\n--- daftar film romantic ---");
                Console.WriteLine("1. The architecture of love \r\n\t\t Rp 35000");
                Console.WriteLine("2. Sampai nanti, hanna!\t            Rp 30000");
                Console.WriteLine("3. Love for sale\t\t                 Rp 40000");
                Console.Write("pilih nomor film  =  ");
                int pilih = int.Parse(Console.ReadLine());

                if (pilih == 1)
                {
                    judul = "The architecture of love";
                    harga = 35000;
                }
                else if (pilih == 2)
                {
                    judul = "Sampai nanti, hanna!";
                    harga = 30000;
                }
                else if (pilih == 3) 
                {
                    judul = "Love for sale";
                    harga = 40000;
                }
                else
                {
                    Console.WriteLine("Pilihan jenis film tidak valid!");
                    return;
                }

                // menampilkan hasil 
                Console.WriteLine("\n======================================");
                Console.WriteLine("Judul film\t: " + judul);
                Console.WriteLine("Harga tiket\t:" + harga);
                Console.WriteLine("========================================");
                Console.WriteLine("Terima kasih telah membeli tiket! ");
            }

        }
    }
}
