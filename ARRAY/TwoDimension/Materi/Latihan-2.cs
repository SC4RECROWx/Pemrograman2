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
            int i, j = 0;
            int varb = 0;
            Random rdm = new Random();

            int n = rdm.Next(5, 16);

            int[,] varB = new int[n, n];

            for(i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    varB[i, j] = rdm.Next(0, 100);
                    varb = varB[i, j];
                }
            }

            Console.WriteLine("Isi Var B : " + varb);

            //code belum lengkap
        }
    }
}
