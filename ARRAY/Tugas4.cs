using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas4_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Jumlah Karyawan : ");
            int jml = int.Parse(Console.ReadLine());

            double[] sales;
            string[] nama;
            string[] id;

            sales = new double[jml];
            nama = new string[jml];
            id = new string[jml];
            for (int i = 0; i < jml; i++)
            {
                Console.WriteLine("Input Data");
                Console.WriteLine("Karyawan ke - " + (i + 1));
                Console.Write("Nama     : ");
                nama[i] = Console.ReadLine();
                Console.Write("Sales ID : ");
                id[i] = Console.ReadLine();
                Console.Write("Sales    : ");
                sales[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("----------------------------");
            }

            for (int i = 0; i < jml; i++)
            {
                Console.WriteLine("Karyawan Ke- " + (i + 1));
                Console.WriteLine("ID Karyawan   : " + id[i]);
                Console.WriteLine("Nama Karyawan : " + nama[i]);
                Console.WriteLine("Sales         : " + sales[i]);
                Console.WriteLine("----------------------------");
            }
        }
    }
}
