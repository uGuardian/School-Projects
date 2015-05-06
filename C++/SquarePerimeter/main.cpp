#include <iostream>

using namespace std;

int main()
{
    int Width, Height, Answer;

    cout << "Please Enter Square Width." << endl;
    cin >> Width;
    cout << "Please Enter Square Height" << endl;
    cin >> Height;
    Answer = Width * 2 + Height * 2;
    cout << "The perimeter is " << Answer;
    return 0;
}
