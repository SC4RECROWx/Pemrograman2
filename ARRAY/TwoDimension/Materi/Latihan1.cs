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
            int[,] multi_table = new int[10, 10];

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    multi_table[i - 1, j - 1] = i * j;
                }
            }

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write(multi_table[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //bug cs line 27
        }
    }
}
