#include <iostream> //Library
using namespace std; 

/*
    Data Types are  string, char, int, float/double, bool
*/
int main(){
    string name = "Paul joshua emperador";
    string address = "Sto.nino";
    int age = 20;
    string number = "0909090909";
    char gender = 'm';
    double height = 55.29;
    

    cout << "My name is: " << name << endl << "I live in: " << address << endl;
    cout << "Age is " << number << endl;

    return 0;
}






//referencing pointers &(ampersand)
/*
void update(int* ptr){
    *ptr = 20;
}

int main(){
    int x = 10;
    update(&x);
    cout << x;

    return 0;
} */


