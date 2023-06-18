#include <iostream>
using namespace std;

class Point{
    private:
    int nilai;

    public:
    void setNilai(int nilai){
        this->nilai = nilai;
    }
    void Display(){
        cout << this->nilai;
    }
};

int main(){
    Point ptr;
    int nilai;
  
    cout << "Masukkan Nilai : "; cin >> nilai;
  
    ptr.setNilai(nilai);
    ptr.Display();
  
    cin.get();
    return 0;
}
