#include <iostream>

using namespace std;

int main()
{
    int Base;
    int Square;
    int Cube;

    cout << "This program will square and cube the inputted answer" << endl << endl;
    cout << "Please enter a number" << endl;
    cin >> Base;
    Square = Base * Base;
    Cube = Base * Base * Base;
    cout << "Squared = " << Square << endl << "Cubed = " << Cube << endl;
    return 0;
}
