using System;
using System.Threading.Tasks;

namespace latihan1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Masukkan Jumlah Data : ");
            int jml_data = Convert.ToInt32(Console.ReadLine());
            string[] nama = new string[jml_data];
            float[] total = new float[jml_data];

            for(int i = 0; i < jml_data; i++)
            {
                int jumlah = 0;
                Console.WriteLine($"-- Data Ke-{(i+1)} --");
                //input nama
                Console.Write($"Masukkan Nama Ke-{(i+1)} : ");
                nama[i] = Console.ReadLine();
                //input nilai
                Console.Write("Masukkan Jumlah Nilai : ");
                int jml_nilai = Convert.ToInt32(Console.ReadLine());
                float[] nilai = new float[jml_nilai];
                for(int j = 0; j < jml_nilai; j++)
                {
                    Console.Write($"Nilai Ke-{(j+1)} : ");
                    jumlah = Convert.ToInt32(Console.ReadLine());
                    nilai[j] = jumlah + nilai[j];
                }
                total[i] = ((nilai.Sum()) / jml_nilai) ;
            }
            
            Console.WriteLine();
            Console.WriteLine();
            
            for(int i = 0; i < jml_data; i++)
            {
                Console.WriteLine($"-- Data Ke-{(i+1)} --");
                Console.WriteLine("Nama      : " + nama[i]);
                Console.WriteLine("Rata-Rata : " + total[i]);
            }
        }
    }
}
