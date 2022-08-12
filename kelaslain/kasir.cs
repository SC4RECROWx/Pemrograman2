using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variabel
            int jml_ayam = 0;
            int jml_nasi = 0;
            int jml_mie = 0;
            int harga = 0;
            int total = 0;
            int bayar = 0;
            int kembalian = 0;
            char tambah;

            Console.WriteLine("               RUMAH MAKAN               ");
            Console.WriteLine("            NASI BALAP PUYUNG            ");
            Console.WriteLine("        Aplikasi kasir rumah makan       ");
            Console.WriteLine("============================================");
            Console.WriteLine();

            Console.WriteLine("Menu Makanan        Harga");
            Console.WriteLine("1. AYAM GORENG        Rp. 10.000");
            Console.WriteLine("2. NASI GORENG        Rp.  8.000");
            Console.WriteLine("3. MIE PANGSIT        Rp. 10.000");
            Console.Write("MASUKKAN PILIHAN ANDA 1/2/3 : ");
            int kode = int.Parse(Console.ReadLine());

            //opsi 1
            if(kode == 1){
                Console.Write("Jumlah Ayam Goreng : ");
                jml_ayam = int.Parse(Console.ReadLine());
                harga = 10000;
                total = harga * jml_ayam;
                Console.Write("Masih Ada yang lain? Y/n : ");
                tambah = char.Parse(Console.ReadLine());
                if(tambah == 'y' || tambah == 'Y'){
                    Console.Write("Masukkan Pilihan 2/3 : ");
                    kode = int.Parse(Console.ReadLine());
                    if(kode == 2){
                        Console.Write("Jumlah Nasi Goreng : ");
                        jml_nasi = int.Parse(Console.ReadLine());
                        harga = 8000 * jml_nasi;
                        total += harga;
                        Console.Write("Ingin Memesan Pangsit Juga? Y/n : ");
                        tambah = char.Parse(Console.ReadLine());
                        if(tambah == 'y' || tambah == 'Y'){
                            Console.Write("Jumlah Pangsit : ");
                            jml_mie = int.Parse(Console.ReadLine());
                            harga = 10000 * jml_mie;
                            total += harga;
                        }
                    }
                    else if(kode == 3){
                        Console.Write("Jumlah Mie Pangsit : ");
                        jml_mie = int.Parse(Console.ReadLine());
                        harga = 10000 * jml_mie;
                        total += harga;
                        Console.Write("Ingin Nasi Goreng Juga? Y/n : ");
                        tambah = char.Parse(Console.ReadLine());
                        if(tambah == 'y' || tambah == 'Y'){
                            Console.Write("Jumlah Nasi Goreng : ");
                            jml_nasi = int.Parse(Console.ReadLine());
                            harga = 10000 * jml_nasi;
                            total += harga;
                        }
                    }
                }
            }

            //opsi 2
            else if(kode == 2){
                Console.Write("Jumlah Nasi Goreng : ");
                jml_nasi = int.Parse(Console.ReadLine());
                harga = 8000;
                total = harga * jml_nasi;
                Console.Write("Masih Ada yang lain? Y/n : ");
                tambah = char.Parse(Console.ReadLine());
                if(tambah == 'y' || tambah == 'Y'){
                    Console.Write("Masukkan Pilihan 1/3 : ");
                    kode = int.Parse(Console.ReadLine());
                    if(kode == 1){
                        Console.Write("Jumlah Ayam Goreng : ");
                        jml_nasi = int.Parse(Console.ReadLine());
                        harga = 10000 * jml_ayam;
                        total += harga;
                        Console.Write("Ingin Memesan Pangsit Juga? Y/n : ");
                        tambah = char.Parse(Console.ReadLine());
                        if(tambah == 'y' || tambah == 'Y'){
                            Console.Write("Jumlah Pangsit : ");
                            jml_mie = int.Parse(Console.ReadLine());
                            harga = 10000 * jml_mie;
                            total += harga;
                        }
                    }
                    else if(kode == 3){
                        Console.Write("Jumlah Mie Pangsit : ");
                        jml_mie = int.Parse(Console.ReadLine());
                        harga = 10000 * jml_mie;
                        total += harga;
                        Console.Write("Ingin Ayam Goreng Juga? Y/n : ");
                        tambah = char.Parse(Console.ReadLine());
                        if(tambah == 'y' || tambah == 'Y'){
                            Console.Write("Jumlah Ayam Goreng : ");
                            jml_ayam = int.Parse(Console.ReadLine());
                            harga = 10000 * jml_ayam;
                            total += harga;
                        }
                    }
                }
            }

            //opsi 3
            else if(kode == 3){
                Console.Write("Jumlah Mie Pangsit : ");
                jml_mie = int.Parse(Console.ReadLine());
                harga = 10000;
                total = harga * jml_mie;
                Console.Write("Masih Ada yang lain? Y/n : ");
                tambah = char.Parse(Console.ReadLine());
                if(tambah == 'y' || tambah == 'Y'){
                    Console.Write("Masukkan Pilihan 1/2 : ");
                    kode = int.Parse(Console.ReadLine());
                    if(kode == 2){
                        Console.Write("Jumlah Nasi Goreng : ");
                        jml_nasi = int.Parse(Console.ReadLine());
                        harga = 8000 * jml_nasi;
                        total += harga;
                        Console.Write("Ingin Memesan Ayam Goreng Juga? Y/n : ");
                        tambah = char.Parse(Console.ReadLine());
                        if(tambah == 'y' || tambah == 'Y'){
                            Console.Write("Jumlah Ayam Goreng : ");
                            jml_ayam = int.Parse(Console.ReadLine());
                            harga = 10000 * jml_ayam;
                            total += harga;
                        }
                    }
                    else if(kode == 1){
                        Console.Write("Jumlah Ayam Goreng : ");
                        jml_ayam = int.Parse(Console.ReadLine());
                        harga = 10000 * jml_ayam;
                        total += harga;
                        Console.Write("Ingin Nasi Goreng Juga? Y/n : ");
                        tambah = char.Parse(Console.ReadLine());
                        if(tambah == 'y' || tambah == 'Y'){
                            Console.Write("Jumlah Nasi Goreng : ");
                            jml_nasi = int.Parse(Console.ReadLine());
                            harga = 10000 * jml_nasi;
                            total += harga;
                        }
                    }
                }
            }

            bool pas = false;
            do{
                Console.WriteLine("\n");
                Console.WriteLine("  =====Total Keseluruhan Belanjaan =====");
                Console.WriteLine("\tTotal Harga Pesanan : " + total);
                Console.Write("\tBayar                   : ");
                bayar = int.Parse(Console.ReadLine());
                if(bayar < total){
                    Console.WriteLine("\tMaaf Uang Anda Kurang Silahkan cukupi harga total...");
                }
                else if(bayar >= total){
                    pas = true;
                }
            }while(!pas);

            kembalian = bayar - total;

            if(bayar > total){
                Console.WriteLine($"\tKembalian           : {kembalian}");
            }

            Console.WriteLine("Terima Kasih....");
        }
    }
}
