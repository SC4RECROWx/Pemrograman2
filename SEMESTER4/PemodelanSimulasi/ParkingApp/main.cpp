#include <iostream>
#include <vector>
#include <cstring>
#include <algorithm>
#include <conio.h>
#include "simulator_park.cpp"
using namespace std;

int main() {
    system("cls");
    int kapasitas_parkir = 5;
    ParkirSimulator parkir(kapasitas_parkir);

    cout << "\nSIMULASI PARKING APP\nCode By Kelompok 4 Pemodelan dan Simulasi" << endl;
    cout << "1. Nur Muhammad Akbar 20212205078" << endl;
    cout << "2. Rangga Saputra " << endl;
    cout << "3. Lukmanul Hakim 20212205226" << endl;

    while (true) {
        cout << "\nMenu:\n" << "1. Parkir Mobil\n2. Keluarkan Mobil\n3. Status Parkir\n4. Keluar\n";

        cout << "Masukkan pilihan Anda (1/2/3/4): ";
        char pilihan;
        cin >> pilihan;

        if (pilihan == '1') {
            string mobil;
            cout << "Masukkan nomor mobil: ";
            cin >> mobil;
            string hasil = parkir.parkir_mobil(mobil);
            cout << hasil << endl;
            cout << "Tekan Enter untuk Melanjutkan...";
            getche();
            system("cls");
        } else if (pilihan == '2') {
            string mobil;
            cout << "Masukkan nomor mobil: ";
            cin >> mobil;
            string hasil = parkir.keluarkan_mobil(mobil);
            cout << hasil << endl;
            cout << "Tekan Enter untuk Melanjutkan...";
            getche();
            system("cls");
        } else if (pilihan == '3') {
            string status = parkir.status_parkir();
            cout << status << endl;
        } else if (pilihan == '4') {
            cout << "Terima kasih telah menggunakan aplikasi simulasi parkir!" << std::endl;
            cout << "Tekan apapun untuk Keluar...";
            getche();
            system("cls");
            break;
        } else {
            cout << "Pilihan tidak valid. Silakan coba lagi." << endl;
        }
    }

    return 0;
}
