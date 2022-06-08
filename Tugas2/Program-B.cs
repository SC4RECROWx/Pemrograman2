using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_B
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
            int n1, n2, n3;
            int Nilai = 0;
            Console.Write("Masukkan Nilai 1 : ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan Nilai 2 : ");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan Nilai 3 : ");
            n3 = Convert.ToInt16(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Nilai = Math.Max(0, n1);
                }
                else
                {
                    Nilai = Math.Max(0, n3);
                }
            }
            else if (n3 > n2)
            {
                Nilai = Math.Max(0, n3);
            }
            else if (n2 > n3)
            {
                Nilai = Math.Max(0, n2);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Nilai Terbesar : " + Nilai);
        }
    }
}
