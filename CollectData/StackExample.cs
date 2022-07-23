using System;
using System.Collections.Generic;

namespace datacollect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> tumpukan = new Stack<string>();

            tumpukan.Push("ACER");
            tumpukan.Push("MSI");
            tumpukan.Push("LENOVO");
            tumpukan.Push("ASUS");
            tumpukan.Push("RAZOR");

            while(tumpukan.Count > 0)
            {
                Console.WriteLine(tumpukan.Pop());
            }
            Console.WriteLine("Done");
        }
    }
}
