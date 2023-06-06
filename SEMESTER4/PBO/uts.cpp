#include <iostream>
#include <cstring>
using namespace std;

class Data{
  private:
    string nama, nim, kelas, prodi, gol_darah;
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
      gol_darah = goldar;
    }
    void setUsia(int Usia){
      usia = Usia;
    }

    //getter
    string getNama(){
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
    string getGolDar(){
      return gol_darah;
    }
    int getUsia(){
      return usia;
    }
};

int main(){
  //variabel
  string nama,nim,kelas,prodi,goldar;
  int usia;

  //input
  cout << "\t=== Program Biodata Mahasiswa ===" << endl;
  cout << "Masukkan Nama           : ";
  getline(cin, nama);
  cout << "Masukkan Nim            : ";
  getline(cin, nim);
  cout << "Masukkan Kelas          : ";
  getline(cin, kelas);
  cout << "Masukkan Prodi          : ";
  getline(cin, prodi);
  cout << "Masukkan Golongan Darah : ";
  cin >> goldar;
  cout << "Masukkan Usia           : ";
  cin >> usia;

  Data Biodata;
  Biodata.setNama(nama);
  Biodata.setNim(nim);
  Biodata.setKelas(kelas);
  Biodata.setProdi(prodi);
  Biodata.setGolDar(goldar);
  Biodata.setUsia(usia);

  cout << endl << endl;
  cout << "\t=== Biodata Telah Terinput ===" << endl;
  cout << "Nama                     : " << Biodata.getNama() << endl;
  cout << "Nim                      : " << Biodata.getNim() << endl;
  cout << "Kelas                    : " << Biodata.getKelas() << endl;
  cout << "Prodi                    : " << Biodata.getProdi() << endl;
  cout << "Golongan Darah           : " << Biodata.getGolDar() << endl;
  cout << "Usia                     : " << Biodata.getUsia() << endl;

  return 0;
}
