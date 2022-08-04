#include <iostream>
using namespace std;

int main(){
    int kode, harga, total, bayar, kembalian;
        cout << "               RUMAH MAKAN               " << endl;
        cout << "            NASI BALAP PUYUNG            " << endl;
        cout << "        Aplikasi kasir rumah makan       " << endl;
        cout << "============================================" << endl;
        cout << "" << endl;
        cout << "Menu Makanan        Harga" << endl;
        cout << "1. AYAM GORENG        Rp. 10.000" << endl;
        cout << "2. NASI GORENG        Rp.  8.000" << endl;
        cout << "3. MIE PANGSIT        Rp. 10.000" << endl;
        cout <<"MASUKKAN PILIHAN ANDA 1/2/3 : ";
        cin >> kode;

        int jml_ayam, jml_nasi, jml_pangsit;
        char tambah;
        
        //opsi 1
        if(kode == 1){
            cout << "Jumlah Ayam Goreng : ";
            cin >> jml_ayam;
            harga = 10000;
            total = harga * jml_ayam;
            cout << "Masih ada yang lain ? y/n : ";
            cin >> tambah;
            if(tambah == 'y' || tambah == 'Y'){
                cout << "Masukkan Pilihan 2/3 : ";
                cin >> kode;
                if(kode == 2){
                    cout << "Jumlah Nasi Goreng : ";
                    cin >> jml_nasi;
                    harga = 8000 * jml_nasi;
                    total += harga;
                    cout << "Ingin Memesan Pangsit Juga? y/n : ";
                    cin >> tambah;
                    if(tambah == 'y' || tambah == 'Y'){
                        cout << "Jumlah Mie Pangsit : ";
                        cin >> jml_pangsit;
                        harga = 10000 * jml_pangsit;
                        total += harga;
                    }
                }
                else if(kode == 3){
                    cout << "Jumlah Mie Pangsit : ";
                    cin >> jml_pangsit;
                    harga = 10000 * jml_pangsit;
                    total += harga;
                    cout << "Ingin Memesan Nasi Goreng Juga? y/n : ";
                    cin >> tambah;
                    if(tambah == 'y' || tambah == 'Y'){
                        cout << "Jumlah Nasi Goreng : ";
                        cin >> jml_nasi;
                        harga = 10000 * jml_nasi;
                        total += harga;
                    }
                }
            }
            
    }

    //opsi 2
    else if(kode == 2){
        cout << "Jumlah Nasi Goreng : ";
        cin >> jml_nasi;
            harga = 8000;
            total = harga * jml_nasi;
            cout << "Masih ada yang lain ? y/n : ";
            cin >> tambah;
            if(tambah == 'y' || tambah == 'Y'){
                cout << "Masukkan Pilihan 1/3 : ";
                cin >> kode;
                if(kode == 1){
                    cout << "Jumlah Ayam Goreng : ";
                    cin >> jml_ayam;
                    harga = 8000 * jml_ayam;
                    total += harga;
                    cout << "Ingin Memesan Pangsit Juga? y/n : ";
                    cin >> tambah;
                    if(tambah == 'y' || tambah == 'Y'){
                        cout << "Jumlah Mie Pangsit : ";
                        cin >> jml_pangsit;
                        harga = 10000 * jml_pangsit;
                        total += harga;
                    }
                }
                else if(kode == 3){
                    cout << "Jumlah Mie Pangsit : ";
                    cin >> jml_pangsit;
                    harga = 10000 * jml_pangsit;
                    total += harga;
                    cout << "Ingin Memesan Ayam Goreng Juga? y/n : ";
                    cin >> tambah;
                    if(tambah == 'y' || tambah == 'Y'){
                        cout << "Jumlah Ayam Goreng : ";
                        cin >> jml_ayam;
                        harga = 10000 * jml_ayam;
                        total += harga;
                    }
                }
            }
    }

    //opsi 3
    else if(kode == 3){
            cout << "Jumlah Mie Pangsit : ";
            cin >> jml_pangsit;
            harga = 10000;
            total = harga * jml_pangsit;
            cout << "Masih ada yang lain ? y/n : ";
            cin >> tambah;
            if(tambah == 'y' || tambah == 'Y'){
                cout << "Masukkan Pilihan 1/2 : ";
                cin >> kode;
                if(kode == 2){
                    cout << "Jumlah Nasi Goreng : ";
                    cin >> jml_nasi;
                    harga = 8000 * jml_nasi;
                    total += harga;
                    cout << "Ingin Memesan Ayam Goreng Juga? y/n : ";
                    cin >> tambah;
                    if(tambah == 'y' || tambah == 'Y'){
                        cout << "Jumlah Ayam Goreng : ";
                        cin >> jml_ayam;
                        harga = 10000 * jml_ayam;
                        total += harga;
                    }
                }
                else if(kode == 1){
                    cout << "Jumlah Ayam Goreng : ";
                    cin >> jml_ayam;
                    harga = 10000 * jml_ayam;
                    total += harga;
                    cout << "Ingin Memesan Nasi Goreng Juga? y/n : ";
                    cin >> tambah;
                    if(tambah == 'y' || tambah == 'Y'){
                        cout << "Jumlah Nasi Goreng : ";
                        cin >> jml_nasi;
                        harga = 10000 * jml_nasi;
                        total += harga;
                    }
                }
            }
            
    }

    //Akhir
    cout << endl << endl;
    cout << "  =====Total Keseluruhan Belanjaan =====" << endl;
    cout << "\tTotal Harga Pesanan : " << total << endl;
    cout << "\tBayar               : ";
    cin >> bayar;
    kembalian = bayar - total;
    cout << "\tKembalian           : " << kembalian << endl;
    cout << "\tTerima Kasih..." << endl;
}
