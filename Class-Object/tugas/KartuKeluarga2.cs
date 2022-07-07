using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Keluarga kel1 = new Keluarga();
            Keluarga kel2 = new Keluarga();
            Keluarga kel3 = new Keluarga();
            Keluarga kel4 = new Keluarga();
            Keluarga kel5 = new Keluarga();

            Console.WriteLine("Program Kartu Keluarga...");

            Console.Write("Masukkan No KK                : ");
            kel1.setNo_KK(Console.ReadLine());

            Console.Write("Masukkan Nama Kepala Keluarga : ");
            kel2.setKepala_Keluarga(Console.ReadLine());

            Console.Write("Masukkan Jumlah Anggota       : ");
            int jml = int.Parse(Console.ReadLine());
            kel3.setJumlah_Anggota(jml);

            string[] nama = new string[jml];
            for(int i = 0; i < jml; i++)
            {
                Console.Write("Masukkan Nama             : ");
                nama[i] = Console.ReadLine();
            }
            kel4.addNama(nama);

            string[] nik = new string[jml];
            for(int i = 0; i < jml; i++)
            {
                Console.Write("Masukkan Nik              : ");
                nik[i] = Console.ReadLine();
                if(nik[i] = 0)
                {

                }
            }
            kel5.setNik(nik);

        }
    }
    class Keluarga
    {
        private string no_KK;
        private string kepala_keluarga;
        private int jumlah_anggota;
        private string[] name;
        private string[] nik;

        public void setNo_KK(string no)
        {
            no_KK = no;
        }

        public void setKepala_Keluarga(string kepala)
        {
            kepala_keluarga = kepala;
        }

        public void setJumlah_Anggota(int jumlah)
        {
            jumlah_anggota = jumlah;
        }

        public void addNama(string[] nama)
        {
            name = nama;
        }

        public void setNik(string[] nk)
        {
            nik = nk;
        }
    }
}
