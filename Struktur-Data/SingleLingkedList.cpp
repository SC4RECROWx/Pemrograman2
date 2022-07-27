#include<iostream>
#include <conio.h>
#include <cstdlib>
using namespace std;

typedef struct node* simpul;
struct node{
  char isi;
  simpul Next;
};

int main(){
  simpul awal, akhir, baru, cetak;

  cout << "== Operasi Pada Single Linked List ==" << endl << endl;
  cout << "Penyisipan Simpul Di Depan" << endrl << endl;

  for(int n = 0; n < 5; n++){
    simpul baru;
    baru = (simpul) malloc(sizeof(simpul));
    cout << "Masukkan Huruf : ";
    cin >> baru -> isi;
    if(awal == NULL){
      awal = baru;
      akhir = baru;
    }
    else{
      baru -> Next = awal;
      awal = baru;
    }
  }
  cout << endl << endl;

  cout << "data : ";
  if(awal == NULL){
    cout << "Linked List Kosong...";
  }
  else{
    cetak = awal;
    while(cetak -> Next -> Next != NULL){
      cout << cetak -> isi << "-->";
      cetak = cetak -> Next;
    }
    cout << cetak -> isi;
  }
  return 0;
}
