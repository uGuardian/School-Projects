#include <iostream>

using namespace std;

int main()
{
    float Kilometers;
    float Miles;
    cout << "This program will convert Kilometers to Miles" << endl << endl;
    cout << "Enter Kilometers" << endl;
    cin >> Kilometers;
    Miles = .621371 * Kilometers;
    cout << "That equals " << Miles <<" Miles" << endl;
    return 0;
}
