using System;
using System.Threading.Tasks;

namespace basic1
{
    class arraymulti
    {
        public static void multi()
        {
            int[,,] data_jual = new int[2,3,2];

            for(int i = 0; i < 2; i++){
                for (int j = 0; j < 3; j++){
                    for(int k = 0; k < 2; k++){
                        Console.WriteLine("Data Tahun Ke - " + (i+1));
                        Console.WriteLine("Data Ke - " + (j+1) + " " + (k+1));
                        data_jual[i,j,k] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Data Penjualan Pertahun");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Tahun Hasil Tahun Penjualan Ke. ");
            Console.WriteLine("Ke. Ke. ----------------");
            Console.WriteLine(" 1 2 ");
            Console.WriteLine("---------------------------------");

            /*
            for(int i = 0; i < 2; i++){
                for(int j = 0; j < 3; j++){
                    Console.Write()
                }
            }
            */
        }
    }
}
