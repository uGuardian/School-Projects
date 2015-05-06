#include <iostream>
#include <windows.h>

using namespace std;

int main()
{
    int Number1;
    int Number2;
    int Answer;
    Answer = 0;

    cout << "Enter 2 Numbers" << endl;
    cin >> Number1;
    cin >> Number2;
    Answer = Number1 + Number2;
    cout << "The answer is " << Answer << endl;
    system("pause");
    return 0;
}
