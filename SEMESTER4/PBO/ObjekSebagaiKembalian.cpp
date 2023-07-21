#include <iostream>
using namespace std;

class Doc{
  public:
    int nilaii;
    void isiNilai(int nilai){
      nilaii = nilai;
      cout << nilaii;
    }
};

Doc isiObjek(){
  Doc doc1;
  doc1.isiNilai(100);
  return doc1;
}

int main(){
  isiObjek();
  return 0;
}
