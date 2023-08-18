#include <iostream>
#include <cstring>
using namespace std;

class Data{
    private:
    string nama, nim, kelas, prodi, golDarah;
    int usia;

    public:
    //setter
    void setNama(string Name){
        nama = Name;
    }
    void setNim(string Nim){
        nim = Nim;
    }
    void setKelas(string Kelas){
        kelas = Kelas;
    }
    void setProdi(string Prodi){
        prodi = Prodi;
    }
    void setGolDar(string goldar){
        golDarah = goldar;
    }
    void setUsia(int Usia){
        usia = Usia;
    }

    //Getter
    string getName(){
        return nama;
    }
    string getNim(){
        return nim;
    }
    string getKelas(){
        return kelas;
    }
    string getProdi(){
        return prodi;
    }
    string getGoldar(){
        return golDarah;
    }
    int getUsia(){
        return usia;
    }
};

int main(){
    string nama, nim, kelas, prodi, goldar;
    int usia;
    Data biodata;

    cout << "Program Biodata" << endl;
    cout << "Masukkan Nama              : "; getline(std::cin, nama);
    cout << "Masukkan Nim               : "; getline(std::cin, nim);
    cout << "Masukkan Kelas             : "; getline(std::cin, kelas);
    cout << "Masukkan Prodi             : "; getline(std::cin, prodi);
    cout << "Masukkan Golongan Darah    : "; getline(std::cin, goldar);
    cout << "Masukkan Usia              : "; cin >> usia;

    biodata.setNama(nama);
    biodata.setNim(nim);
    biodata.setKelas(kelas);
    biodata.setProdi(prodi);
    biodata.setGolDar(goldar);
    biodata.setUsia(usia);

    cout << endl << endl;
    cout << "Biodata Telah Di input" << endl;
    cout << "Nama           : " << biodata.getName() << endl;
    cout << "Nim            : " << biodata.getNim() << endl;
    cout << "kelas          : " << biodata.getKelas() << endl;
    cout << "Prodi          : " << biodata.getProdi() << endl;
    cout << "Golongan Darah : " << biodata.getGoldar() << endl;
    cout << "Usia           : " << biodata.getUsia() << endl;

    return 0;
}