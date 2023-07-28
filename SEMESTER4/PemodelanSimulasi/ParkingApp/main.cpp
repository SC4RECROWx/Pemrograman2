#include <iostream>
#include <vector>
#include <cstring>
#include <algorithm>
#include "simulator_park.cpp"
using namespace std;

int main() {
    int kapasitas_parkir = 5;
    ParkirSimulator parkir(kapasitas_parkir);

    while (true) {
        cout << "\nMenu:\n"
                     "1. Parkir Mobil\n"
                     "2. Keluarkan Mobil\n"
                     "3. Status Parkir\n"
                     "4. Keluar\n";

        cout << "Masukkan pilihan Anda (1/2/3/4): ";
        char pilihan;
        cin >> pilihan;

        if (pilihan == '1') {
            string mobil;
            cout << "Masukkan nomor mobil: ";
            cin >> mobil;
            string hasil = parkir.parkir_mobil(mobil);
            cout << hasil << endl;
        } else if (pilihan == '2') {
            string mobil;
            cout << "Masukkan nomor mobil: ";
            getline(cin, mobil);
            string hasil = parkir.keluarkan_mobil(mobil);
            cout << hasil << endl;
        } else if (pilihan == '3') {
            string status = parkir.status_parkir();
            cout << status << endl;
        } else if (pilihan == '4') {
            cout << "Terima kasih telah menggunakan aplikasi simulasi parkir!" << std::endl;
            break;
        } else {
            cout << "Pilihan tidak valid. Silakan coba lagi." << endl;
        }
    }

    return 0;
}