#include <iostream>

using namespace std;

int main()
{
    string fname;
    int age;

    cout << "What is our name?" << endl;

    cin >> fname;

    cout << endl;

    cout << "Okay " << fname << ", how old are you?";

    cin >> age;

    cout << endl;

    cout << fname << " says they are " << age << " years old.";
    return 0;
}
