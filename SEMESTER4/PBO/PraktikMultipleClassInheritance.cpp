#include <iostream>
#include <string.h>
using namespace std;

class IBU{
    public:
    string warnaKulit = "Putih";

    void tampilWarnaKulitIbu(){
        cout << warnaKulit << endl;
    }
};

class BAPAK{
    public:
    string warnaKulit = "Coklat";

    void tampilWarnaKulitBapak(){
        cout << warnaKulit << endl;
    }
};

class ANAK: public IBU, public BAPAK{
    public:
    string warnaKulit = "Sawo Matang";

    void tampilWarnaKulitAnak(){
        cout << warnaKulit << endl;
    }
};

int main(){
    ANAK anak;
    
    cout << "Warna Kulit Ibu   : ";
    anak.tampilWarnaKulitIbu();
    cout << "Warna Kulit Bapak : ";
    anak.tampilWarnaKulitBapak();
    cout << "Warna Kulit Anak  : ";
    anak.tampilWarnaKulitAnak();

    cin.get();
    return 0;
}
