using System;
using System.Collections.Generic;

namespace datacollect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> antrian = new Queue<string>();

            antrian.Enqueue("Bob");
            antrian.Enqueue("Rain");
            antrian.Enqueue("Jordan");
            antrian.Enqueue("John");

            while(antrian.Count > 0)
            {
                Console.WriteLine("Nex Item : " + antrian.Dequeue());
            }
        }
    }
}
