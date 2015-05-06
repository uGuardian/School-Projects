#include <iostream>
#include <stdlib.h>
#include <cstdlib>      //atoi
#include <stdio.h>      //printf, fgets

using namespace std;

int main()
{
    char menuitemtemp[256];
    int menuitem;
    while (menuitem != 1 and menuitem != 2)
    {
        cout << "Dinner Menu" << endl << endl;
        cout << "1 - Prime Rib with Asparagus" << endl;
        cout << "2 - Caesar Salad with Beef and Potato Soup" << endl << endl;
        fgets (menuitemtemp, 256, stdin);
        menuitem = atoi (menuitemtemp);

        switch (menuitem)
        {
        case 1:
            cout << endl << "That will be $2.00" << endl << endl;
            break;
        case 2:
            cout << endl << "That will be $1.50" << endl << endl;
            break;
        default:
            system("cls");
            cout << endl << "Please enter something else" << endl << endl;
            break;
        }
    }
    return 0;
}
