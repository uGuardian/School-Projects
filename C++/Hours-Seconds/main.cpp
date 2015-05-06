#include <iostream>

using namespace std;

int main()
{
    float Hours;
    int Seconds;
    cout << "This program will convert Hours to Seconds" << endl << endl;
    cout << "Enter Hours" << endl;
    cin >> Hours;
    Seconds = 3600 * Hours;
    cout << "That equals " << Seconds <<" Seconds" << endl;
    return 0;
}
