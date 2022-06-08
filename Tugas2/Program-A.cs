using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama  : Nur Muhammad Akbar");
            Console.WriteLine("Kelas : TI. 208");
            Console.WriteLine("Nim   : 20212205078");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("Program A");
            Console.Write("Masukkan Harga Buku : ");
            var harga = Convert.ToInt32(Console.ReadLine());
            float discount = 0;
            string persen = "";

            if (harga <= 0)
            {
                Console.WriteLine("Invalid Price!!");
            }
            else if (harga < 85000)
            {
                discount = Convert.ToSingle(harga * 0.10);
                persen = "10%";
            }
            else if (harga >= 85000)
            {
                discount = Convert.ToSingle(harga * 0.18);
                persen = "18%";
            }

            double Net = harga - discount;
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Harga Buku  : " + harga);
            Console.WriteLine("Discount    : " + persen);
            Console.WriteLine("Total Harga : " + Net);

        }
    }
}
