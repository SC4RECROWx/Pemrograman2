using System;
using System.Threading.Tasks;

public class arei
{
    public static void arei2D()
    {
        Console.Write("Masukkan Jumlah Baris : ");
        int baris = int.Parse(Console.ReadLine());
        int kolomm = 2;
        int[,] dataa = new int[baris, kolomm];

        for(int i = 0; i < baris; i++){
            for(int j = 0; j < kolomm; j++){
                Console.Write("Masukkan Jumlah Data yang lulus : ");
                dataa[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nTampil Data Lulus");
        Console.WriteLine("Tahun  TE   TK");

        for(int i = 0; i < baris; i++){
            Console.Write($"Th ke - {(i + 1)}   ");
            for(int j = 0; j < kolomm; j++){
                Console.Write(dataa[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
