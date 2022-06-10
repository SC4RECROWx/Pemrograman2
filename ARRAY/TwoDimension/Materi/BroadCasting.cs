using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    internal class Program
    {
        //Random
        public static int[,] arrandomizer(int M, int N)
        {
            int[,] a = new int[M, N];
            Random rdm = new Random();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = rdm.Next(0, 10);
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create Array");
            Console.WriteLine("Input Size M : ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Size N : ");
            int N = int.Parse(Console.ReadLine());

            int[,] array_a = arrandomizer(M, N);

            //Print Array
            Console.WriteLine("Array A");
            display(array_a);

            //BroadCast
            Console.WriteLine("\nArray B");
            int[,] array_b = broadcast(array_a, 2, M, N);
            display(array_b);
        }

        //UTILITIES
        //DISPLAY ARRAY
        static void display(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //BroadCast
        static int[,] broadcast(int[,] a, int b, int M, int N)
        {
            Console.WriteLine("BroadCasting (addition) : " + b);
            int[,] c = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < M; i++){
                for (int j = 0; j < N; j++)
                {
                    c[i, j] = a[i, j] + b;        
                }
            }
            return c;
        }
    }
}
