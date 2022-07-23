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
            Dictionary<string, string> mhs = new Dictionary<string, string>();
            
            mhs.Add("D411", "ALAN");
            mhs.Add("D412", "BUDI");
            mhs.Add("D413", "KELVIN");
            mhs.Add("D414", "GRAN");
            mhs.Add("D415", "NATE");

            //COUNT 
            Console.WriteLine("Jumlah Mahasiswa : " + mhs.Count + "");

            //Dictionary[Key] = new Value
            mhs["D412"] = "ROBERT";

            //REMOVE
            mhs.Remove("D414");

            //COUNT
            Console.WriteLine("Jumlah Mahasiswa : " + mhs.Count + "\n");
            foreach(KeyValuePair<string, string> m in mhs)
            {
                Console.WriteLine("Nim \t: " + m.Key);
                Console.WriteLine("Nama\t: " + m.Value);
                Console.WriteLine();
            }
        }
    }
}
