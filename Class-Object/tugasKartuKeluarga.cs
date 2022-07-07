using System;

namespace SandBox
{
    class Program
    {
        static void Main()
        {
            string[] Nama = new string[11];
            string[] Nik = new string[11];

            Console.Write("Masukkan Jumlah Anggota    : ");
            int jumlah = int.Parse(Console.ReadLine());
            Console.Write("Input Nama Kepala Keluarga : ");
            string kepala_keluarga = Console.ReadLine();
            Console.Write("Input No KK                : ");
            string No_KK = Console.ReadLine();

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write("Masukkan Nama : ");
                Nama[i] = Console.ReadLine();

                Console.Write("Masukkan Nik : ");
                Nik[i] = Console.ReadLine();
            }

            //display
            Console.WriteLine($"Jumlah Anggota  : {jumlah}");
            Console.WriteLine($"No KK           : {No_KK}");
            Console.WriteLine($"Kepala Keluarga : {kepala_keluarga}");
            Console.WriteLine("ANGGOTA KELUARGA");
            for(int i = 0; i < jumlah; i++)
            {
                Console.WriteLine("Nama   : " + Nama[i]);
                Console.WriteLine("Nik    : " + Nik[i]);
            }
        }
    }

    /*
    class Keluarga
    {
        private string no_KK;
        private string[] nama;
        private string kepala_keluarga;
        private string[] nik;
        private int jumlah_anggota;

        public void Nama(string[] nam)
        {
            nama = nam;
        }

        public void Nik(string[] ik)
        {
            nik = ik;
        }

        public string getKepala_Keluarga()
        {
            
        }

        public void display()
        {

        }
    }
    */
}
