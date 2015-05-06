#include <iostream>

using namespace std;

int main()
{
    int num;
    int i;
    cout << "Enter a number to count up to" << endl;
    cin >> num;
    cout << endl;
    for (i = 0; i <= num; i++){
        cout << i << " ";
    }
    cout << endl;
    return 0;
}
