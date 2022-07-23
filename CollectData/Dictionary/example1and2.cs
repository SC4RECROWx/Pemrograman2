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
            //cara 1
            Dictionary<int, string> dict01 = new Dictionary<int, string>();
            dict01.Add(1, "ASUS");
            dict01.Add(2, "MSI");
            dict01.Add(3, "AlienWare");
            dict01.Add(4, "Acer");
            dict01.Add(5, "Lenovo");

            //cara 2
            Dictionary<int, string> dict02 = new Dictionary<int, string>()
            {
                { 1, "ASUSSS" },
                { 2, "MSI" },
                { 3, "AlienWare"},
                { 4, "Acer"},
                { 5, "Lenovo"},
            };
            foreach(KeyValuePair<int, string> item in dict01)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine();
            foreach (KeyValuePair<int, string> item in dict02)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
