#include <iostream>
using namespace std;

//DEKLARASI VARIABEL
int usia = 27;
int panjang = 7;
int lebar = 9;
int luas;

//Fungsi tanpa kembalian
void Belajar(){
  cout << usia;
}

//Fungsi dengan nilai kembalian
int Luas_SegiEmpat(){
 return luas = panjang * lebar;
}

//Fungsi Parameter
int Luas_SegiEmpat2(int p, int l){
  panjang = p;
  lebar = l;
  return luas = p * l;
}

//MAIN PROGRAM
int main(){
  Belajar();
  cout << endl;
  cout << Luas_SegiEmpat() << endl;
  cout << Luas_SegiEmpat2(panjang, lebar) << endl;

  return 0;
}
