#include <iostream>
using namespace std;

class Komputer {
    private:
    void hidupkanKomputer(string pemilik="Anto", string merk="DELL"){
        cout << pemilik << endl;
        cout << merk << endl;
    }
    public:
    void panggilHidupkanKomputer(){
        hidupkanKomputer();
    }
};

class Laptop: public Komputer{
    void panggilHidupkanKomputerDariClassTurunan(){
        panggilHidupkanKomputer();
    }
};

int main(){
    Komputer komputeranto;
    Laptop laptopanto;
    
    komputeranto.panggilHidupkanKomputer();
    laptopanto.panggilHidupkanKomputer();

    return 0;
}
