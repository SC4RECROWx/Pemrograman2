using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Console.Write("Input : ");
            int k = Convert.ToInt32(Console.ReadLine());

            int[] data = new int[k];
            int i;

            for (i = 0; i < k; i++)
            {
                int num = n.Next(1, 9);
                data[i] = num;
            }

            Console.Write("Data : { ");
            for (i = 0; i < k; i++)
            {
                Console.Write(data[i] + ", ");
            }
            Console.WriteLine("}");

            //sum
            int sum = data[i] + k;
            Console.WriteLine("Sum : " + sum);
        }
    }
}
