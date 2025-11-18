using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TUGAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== INPUT BIODATA SISWA ===");
            Console.Write("Nama Lengkap        : ");
            string nm = Console.ReadLine();
            Console.Write("Nama Panggilan      : ");
            string nma = Console.ReadLine();
            Console.Write("Jenis Kelamin       : ");
            string jk = Console.ReadLine();
            Console.Write("Agama               : ");
            string ag = Console.ReadLine();
            Console.Write("umur                : ");
            string um = Console.ReadLine();
            Console.Write("Kelas               : ");
            string kl = Console.ReadLine();
            Console.Write("Jurusan             : ");
            string jr = Console.ReadLine();
            Console.Write("Alamat              : ");
            string al = Console.ReadLine();
            Console.Write("Hobi                : ");
            string hb = Console.ReadLine();
            Console.Write("Cita-cita           : ");
            string ct = Console.ReadLine();
            Console.WriteLine("======================");
            Console.WriteLine("=== BIODATA SISWA ===");
            Console.WriteLine($"Nama Lenngkap  : {nm}");
            Console.WriteLine($"Nama Panggilan : {nma}");
            Console.WriteLine($"Jenis Kelamin  : {jk}");
            Console.WriteLine($"Agama          : {ag}");
            Console.WriteLine($"Umur           : {um}");
            Console.WriteLine($"Kelas          : {kl}");
            Console.WriteLine($"Jurusan        : {jr}");
            Console.WriteLine($"Alamat         : {al}");
            Console.WriteLine($"Hobi           : {hb}");
            Console.WriteLine($"Cita-cita      : {ct}");
            Console.WriteLine("======================");
        }
    }
}
