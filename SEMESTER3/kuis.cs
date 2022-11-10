using System;
using System.Threading.Tasks;

namespace basic1
{
    class kuiss
    {
        public static void quis()
        {
            Console.Write("Masukkan Jumlah Data : ");
            int ata = int.Parse(Console.ReadLine());
            string[] name = new string[ata];
            float[] totall = new float[ata];
            char[] grade = new char[ata];

            for(int i = 0; i < ata; i++)
            {
                Console.Write($"Masukkan Nama Ke- {(i+1)}  : ");
                name[i] = Console.ReadLine();
                Console.WriteLine("------------------------------------------------");
                Console.Write("Masukkan Jumlah Mata Kuliah : ");
                int jml_makul = int.Parse(Console.ReadLine());
                string[] nama_makul = new string[jml_makul];
                float[] nilaii = new float[jml_makul];
                for(int j = 0; j < jml_makul; j++)
                {
                    Console.Write($"Masukkan Nama Mata Kuliah Ke- {(j+1)} : ");
                    nama_makul[j] = Console.ReadLine();
                    Console.Write($"Masukkan Nilai Ke- {(j+1)} : ");
                    nilaii[j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("------------------------------------------------\n");
                totall[i] = ((nilaii.Sum()) / jml_makul);
                if(totall[i] >= 80)
                {
                    grade[i] = 'A';
                }
                else if(totall[i] >= 70)
                {
                    grade[i] = 'B';
                }
                else if(totall[i] >= 60)
                {
                    grade[i] = 'C';
                }
                else if(totall[i] >= 50)
                {
                    grade[i] = 'D';
                }
                else if(totall[i] < 50)
                {
                    grade[i] = 'E';
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Hasil.....");
            Console.WriteLine("------------------------------------------------");
            for(int i = 0; i < ata; i++)
            {
                Console.WriteLine($"Nama Ke- {(i+1)} : " + name[i]);
                Console.WriteLine("Rata Rata Nilai   : " + totall[i]);
                Console.WriteLine("Grade             : " + grade[i]);
                Console.WriteLine("------------------------------------------------\n");
            }

            Console.WriteLine("Ketentuan\n");
            Console.WriteLine("A = 80 - 100");
            Console.WriteLine("A = 70 - 79");
            Console.WriteLine("A = 60 - 69");
            Console.WriteLine("A = 50 - 59");
        }
    }

    class arraymulti
    {
        public static void kis()
        {
            kuiss.quis();
        }
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
