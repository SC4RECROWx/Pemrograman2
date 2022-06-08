using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama  : Nur Muhammad Akbar");
            Console.WriteLine("Kelas : TI. 208");
            Console.WriteLine("Nim   : 20212205078");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Program 3");
            Console.Write("Masukkan Tahun : ");
            var tahun = Int16.Parse(Console.ReadLine());
            bool kabisat = true;

            if (tahun % 400 == 0)
            {
                kabisat = true;
            }
            else if (tahun % 100 == 0)
            {
                kabisat = false;
            }
            else if (tahun % 4 == 0)
            {
                kabisat = true;
            }
            else if (tahun % 4 != 0)
            {
                kabisat = false;
            }

            if (kabisat == false)
            {
                Console.WriteLine(tahun + " = Bukan Tahun Kabisat");
            }
            else if (kabisat == true)
            {
                Console.WriteLine(tahun + " = Adalah Tahun Kabisat");
            }
        }
    }
}
