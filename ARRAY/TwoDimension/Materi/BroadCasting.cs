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

            //Program Masih Error
            Console.WriteLine("Create Array");
            Console.Write("Input Size M : ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Size N : ");
            int N = int.Parse(Console.ReadLine();

            int[,] array_a = arrandomizer(M, N);

            //Print Array
            Console.WriteLine("Array A");
            display(array_a);

            //broadcast
            Console.WriteLine("\nArray B");
            int[,] array_b = broadcast(array_a, 2);
            display(array_b);
        }

        //Random
        int[,] arrandomizer(int M, int N)
        {
            int[,] a = new int[M, N];
            Random rdm = new Random();

            for (int i = 0; i < M; i++)
            {
                for (int J = 0; J < N; J++)
                {
                    a[i, J] = rdm.Next(0, 10);
                }
            }

            return a;
        }

        //display array
        void display(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //broad
        int[,] broadcast(int[,] a, int b)
        {
            Console.WriteLine("BroadCasting (addition) : " + b);
            int[,] c = new int[a.GetLength(0), a.GetLength];

            for (int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    c[i, j] = a[i, j] + b;
                }
            }

            return c;
        }
    }
}
