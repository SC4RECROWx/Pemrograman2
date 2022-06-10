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
            Console.WriteLine("       OPERASI PENJUMLAHAN MATRIKS        ");
            Console.WriteLine("       ---------------------------        ");
            Console.WriteLine();

            int baris, kolom;

            Console.Write("Jumlah Baris Matrik : ");
            baris = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Kolom Matrik : ");
            kolom = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("MATRIKS A");
            Console.WriteLine("------------");

            int[,] matrikA = new int[baris, kolom];

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("MATRIKS A [{0}][{1}] : ", i + 1, j + 1);
                    matrikA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("MATRIKS B");
            Console.WriteLine("------------");

            int[,] matrikB = new int[baris, kolom];

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("MATRIKS B [{0}][{1}] : ", i + 1, j + 1);
                    matrikB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Hasil Penjumlahan Matrik A & B");
            Console.WriteLine("---------------------------------");


            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    int[,] hasil = new int[baris, kolom];
                    hasil[i, j] = matrikA[i, j] - matrikB[i, j];
                    Console.Write("{0}\t", hasil[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
