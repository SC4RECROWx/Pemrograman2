#include <iostream>
using namespace std;

class ISI{
    public:
    int nilai;
    int isiNilai(int input){
        nilai = input;
        return nilai;
    }
};

int tampilNilai(ISI isi1, int input){
    isi1.isiNilai(input);
    return isi1.nilai;
}

int main(){
    ISI isi2;
    cout << tampilNilai(isi2 , 90);
    cin.get();
    return 0;
}
