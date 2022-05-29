using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas3_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int i;
            Console.Write("Input N : ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (i = 0; i < n; i++)
            {
                int ran = rand.Next(1, 10);
                a[i] = ran;
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Print A : " + a[i]);
            }

            Console.WriteLine();

            int j = n - 1;
            for (i = 0; i < j; i++)
            {
                int Temp = a[i];
                a[i] = a[j];
                a[j] = Temp;
                j -= 1;
            }

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Print A : " + a[i]);
            }
        }
    }
}
