#include <iostream>
using namespace std;

int (*p) (int, int);
int a = 10;
int b = 20;
int hitung (int x, int y){
    return(x+y);
}

//main program
int main(){
    p=hitung;
    cout << (*p) (a,b);
    cin.get();
    return 0;
}
