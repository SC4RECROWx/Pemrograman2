#include <iostream>
#define TEN 15
using namespace std;

//Metode shellsort
int shellsort(int arr[], int N) 
{ 
    for (int l = N/2; l > 0; l /= 2){ 
        for (int i = l; i < N; i += 1) {  
            int temp = arr[i]; 
            int j; 
            for (j = i; j >= l && arr[j - l] > temp; j -= l){
                arr[j] = arr[j - l];
            } 
            arr[j] = temp; 
            } 
        } 
        return 0; 
} 

int main(){
    //Deklarasi isi Array dan jarak array
    int array[TEN] = {15,45,77,90,10,55,14,66,48,78,44,63,98,77,41};
    int N = TEN;

    cout << "Nama  : Nur Muhammad Akbar" << endl;
    cout << "Kelas : T.208" << endl;
    cout << "Nim   : 20212205078" << endl;
    cout << "sebelum terurut..." << endl;
    for (int i = 0; i < N; i++){
        cout << array[i] << " ";
    }
    cout << endl << endl;

    //pemanggilan fungsi shell sort
    shellsort(array, N);

    cout << "Setelah Terurut..." << endl;
    for (int i = 0; i < N; i++){
        cout << array[i] << " ";
    }
    return 0;
}
