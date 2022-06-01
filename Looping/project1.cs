using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double harga = 1;
            while(harga >= 1)
            {
                double diskon;
                string persen;

                Console.Write("Input Harga : ");
                harga = double.Parse(Console.ReadLine());

                if(harga <= 0)
                {
                    Console.WriteLine("INPUTAN KOSONG");
                }
                else if (harga > 0)
                {
                    if (harga < 100)
                    {
                        diskon = harga * 0.12;
                        persen = "12%";
                    }
                    else
                    {
                        diskon = harga * 0.18;
                        persen = "18%";
                    }
                    double net = harga - diskon;

                    Console.WriteLine("Harga  : " + harga);
                    Console.WriteLine("Persen : " + persen);
                    Console.WriteLine("Nett   : " + net);
                }
            }
        }
    }
}
