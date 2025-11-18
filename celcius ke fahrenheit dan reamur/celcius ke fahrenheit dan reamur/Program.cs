using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celcius_ke_fahrenheit_dan_reamur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Program Mengubah Suhu Dari Celcius Ke Fahrenheit Dan Reamur ===");

            Console.Write("Masukan suhu celcius untuk diubah ke dalam fahrenheit dan reamur:  ");
            int c = Convert.ToInt32(Console.ReadLine());
            int fh = (c * 9 / 5) + 32;
            Console.WriteLine("Suhu Fahrenheit:  " + fh + "°F" );
            int rm = (c * 4 / 5);
            Console.WriteLine("Suhu Reamur:      " + rm + "°Re");

            Console.WriteLine("===================================================================");
            Console.WriteLine("Suhu Celcius    :  " + c  + "°C");
            Console.WriteLine("Suhu Fahrenheit :  " + fh + "°F");
            Console.WriteLine("Suhu Reamur     :  " + rm + "°Re");

        }
    }
}
