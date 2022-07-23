using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacollect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cara Deklarasi List
            //cara 1
            var names1 = new List<string>();
            names1.Add("Casey");
            names1.Add("Catherine");
            names1.Add("Kevin");
            names1.Add("Robert");
            names1.Add("Leslie");
            names1.Add("John");

            //cara 2
            var names2 = new List<string>()
            {
                "Casey", "John", "Stewart", "Clark", "Bruce", "Leslie"
            };

            //display
            foreach (string d in names1)
            {
                Console.WriteLine("Nama1 : " + d);
            }

            Console.WriteLine();

            foreach (string d in names2)
            {
                Console.WriteLine("Nama2 : " + d);
            }
            names2.Remove("John");

            Console.WriteLine("Jumlah Data Sebelum Dirubah : " + names1.Count);

            //Contains
            Console.WriteLine(names2.Contains("John"));

            //Remove, RemoveAT, Count
            names1.Remove("Catherine");
            names1.RemoveAt(2);
            Console.WriteLine("Jumlah Data Sesudah Dirubah : " + names1.Count);
        }
    }
}
