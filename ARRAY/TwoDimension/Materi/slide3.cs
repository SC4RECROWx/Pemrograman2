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
            int[,] grades = new int[4, 5];

            int[,] ages =
            {
                {4,1,4,6,6}, {5,4,1,3,1}
            };

            Console.WriteLine(grades[0, 2]);
            Console.WriteLine(ages[1, 3]);
            
            string[,] names =
            {
                {"B", "U", "D", "I" },
                {"A", "N", "T", "O", "N"},
                {"N", "A", "D", "I", "N", "E"},
                {"S", "P", "E", "C", "T", "R", "E"},
                {"M", "A", "R", "K"};
            }
        }
    }
}
