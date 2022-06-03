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
            Console.WriteLine("Aritmatic 2 buah array N x N");
            Console.WriteLine("Addition");
            Console.Write("Input Angka Pertama : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input Angka Kedua   : ");
            int m = int.Parse(Console.ReadLine());
            int[,] arayb = new int[3, 3];
            int[,] araya = new int[3, 3];
            int[,] hasil = new int[3, 3];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    araya[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arayb[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    hasil[i, j] = araya[i, j] + arayb[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(hasil[i, j]);
                }
            }
        }
    }
}
