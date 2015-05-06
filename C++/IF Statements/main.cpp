#include <iostream>
#include <stdlib.h>

using namespace std;

int Calculation()
{
    cout << "ENTER UR INCOME FUGAT" << endl;
    double Income;
    double TaxRate;
    cin >> Income;
    cout << "U SUPPOSEDLY HAVE $" << Income << " YES?" << endl;
    int Answer;
    cin >> Answer;
    cout << Answer;
    if (((Answer) = (0))){
        if (Income < 11000) {
            TaxRate = 0.3;
        }
        else if (Income < 31000) {
            TaxRate = 0.5;
        }
        else if (Income < 100000) {
            TaxRate = 0.7;
        }
        else if (Income < 1000000) {
            TaxRate = 0.9;
        }
        else {
            cout << "U GOT 2 MUCH MUNY FUGAT" << endl;
        }
    }
    else {
    Calculation();
    }

    return 0;
}
int main()
{
    cout << "WEEEEE DEEEEEMAEEEEND MOEEEENEEEEEY" << endl;
    Calculation();

    return 0;
}
