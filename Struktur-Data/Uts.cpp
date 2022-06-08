#include <iostream>
#include <cstdlib>
#include <stdio.h>
#define MAC 14
using namespace std;

int main(){
        cout << endl << "Nama  : Nur Muhammad Akbar" << endl;
        cout << "Nim   : 20212205078" << endl;
        cout << "Kelas : TI/208" << endl << endl;
        cout << "Program Mencari Bilangan Sembarang" << endl;
        cout << "Code By SC4RECROWx(NurAkbar)" << endl;
        cout << "Press Any Key To Start....";
        getchar();
        system("cls");
        
        int random;
        
        for (int i = 0; i < MAC; i++){
            random = rand() % 9;
            cout << random << endl;
        }
        int cari = random;
        int data[MAC] = {9,6,0,5,0,9,2,3,6,7,6,1,3,2};

        cout << "Data Sembarang = " << cari << endl << endl;

        for (int i = 0; i < MAC; i++){
            if (cari == data[i]){
                cout << i+1 << ". " << data[i] << " = Adalah Data Yang Dicari" << endl;
            }
            else{
                cout << i+1 << ". " << data[i] << " = Bukan Data Yang dicari" << endl;
            }
        }

    return 0;
}
