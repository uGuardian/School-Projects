#include <iostream>

using namespace std;

int main()
{
    float Dollars;
    float Euros;

    cout << "This program will convert Dollars to Euros" << endl << endl;
    cout << "Enter Dollars" << endl;
    cin >> Dollars;
    Euros = .75 * Dollars;
    cout << "That equals " << Euros <<" Euros" << endl;
    return 0;
}
