#include <iostream>
#include <cstring>
using namespace std;

class MANUSIA{
  public:
  int usia;
  string nama;
  char golDarah;

  void Tampil(){
    cout << usia << endl;
    cout << nama << endl;
    cout << golDarah << endl;
  }
};

int main(){
  MANUSIA orang;
  orang.nama = "Akbar";
  orang.usia = 22;
  orang.golDarah = 'A';

  orang.Tampil();
  return 0;
}
