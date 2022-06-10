using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nLets Play - Tebak Angka!\n");

            Random rdm = new Random();
            int answer = rdm.Next(1, 101);
            bool correct = false;
            while (correct == false)
            {
                Console.WriteLine("Tebak Angka anara 1 - 100 : ");
                int tebakan = int.Parse(Console.ReadLine());

                if(tebakan < answer)
                {
                    Console.WriteLine("Tebakan Terlalu Kecil, Coba Lagi...\n");
                }
                
                else if(tebakan > answer)
                {
                    Console.WriteLine("Tebakan Terlalu Besar, coba lagi...\n");
                }

                else if(tebakan == answer)
                {
                    Console.WriteLine($"SELAMAT !!, Tebakan Mu Benar, Jawabannya adalah {answer}\n");
                    correct = true;
                }
            }
        }
    }
}
