using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transpose of an Array");

            Console.Write("Size Of M : ");
            int M= int.Parse(Console.ReadLine());
            Console.Write("Size Of N : ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Create Array A");
            int[,] A =new int[M,N];
            A = randomize(A);
            disparray(A);

            Console.WriteLine("\nTranspose Of Array A");
            int[,] A_T = transposer(A);
            disparray(A_T);
        }

        static int[,] transposer(int[,] a)
        {
            int[,] a_t = new int[a.GetLength(1), a.GetLength(0)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a_t[j, i] = a[i,j];
                }
            }
            return a_t;
        }

        static int[,] randomize(int[,] a)
        {
            Random rdm = new Random();
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rdm.Next(0, 1000);
                }
            }
            return a;
        }

        static void disparray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
