//Pustaka Yang Disisipkan
#include <iostream>
#include <cstring>
using namespace std;

//inisialisasi Class Manusia
class Manusia{
  private:
    string nama;
    int usia;

                          //private dan public adalah accessor yang jika private tidak dapat di akses oleh pihak luar
  public:
    //setter
    void setNama(string nam){
      nama = nam;
    }
    void setUsia(int usi){
      usia = usi;
    }

    //getter
    string getNama(){
      return nama;
    }
    int getUsia(){
      return usia;
    }
};

int main(){
                                                  //Code By SC4RECROWx
                                                  
  //inisialisasi var
  string name;
  int usia1;

  //include class
  Manusia orang;

  //Memasukkan Data
  cout << "Masukkan Nama : ";
  getline(cin,name);
  cout << "Masukkan Usia : ";
  cin >> usia1;

  system("clear");
  //Set Data
  orang.setNama(name);
  orang.setUsia(usia1);

  //Show Data
  cout << "DATA ANDA : " << endl;
  cout << "Nama : " << orang.getNama() << endl;
  cout << "Usia : " << orang.getUsia() << endl;
  return 0;
}
