#include <iostream>
using namespace std;

void insertionSort(int array[], int size){
    for(int step = 1; step < size; step++){
        int key = array[step];
        int j = step - 1;
        while(key < array[j] && j >= 0){
            array[j + 1] = array[j];
            --j;
        }
        array[j + 1] = key;
    }
}

void before(int array[], int size){
    cout << "Before Sorted : " << endl;
    for(int i = 0; i < size; i++){
        cout << array[i] << " ";
    }
    cout << endl << endl;
}

void printArray(int array[], int size){
    for(int i = 0; i < size; i++){
        cout << array[i] << " ";
    }
    cout << endl;
}

int main(){
    int data[] = {9, 5, 1, 4, 3};
    int size = sizeof(data) / sizeof(data[0]);
    before(data, size);
    insertionSort(data, size);
    
    
    cout << "Sorted Array in ascending order : " << endl;
    printArray(data, size);
}
