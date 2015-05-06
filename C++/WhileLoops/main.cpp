#include <iostream>
#include <stdlib.h>

using namespace std;

int main()
{
    int score[255];
    int settingloop = 0;
    while (settingloop < 256){
        score[settingloop] = 0;
        settingloop = settingloop + 1;
    }
    int entry;
    int arraymanager = 0;
    float average = 0;
    int repeat = 0;
    cout << "Enter any number of scores to average" << endl << "When you are done, enter 0" << endl;
    cin >> entry;
    while (entry != 0){
        score[arraymanager] = entry;
        arraymanager = arraymanager + 1;
        cin >> entry;
    }
    while (repeat <= arraymanager){
        average = average + score[repeat];
        repeat = repeat + 1;
    }

    ///Debug Lines
    //cout << endl << average << endl;

    if (arraymanager != 0) {
        average = average / arraymanager;
    } else cout << "You didn't enter anything" << endl;

    ///Debug Lines
    //cout << endl << entry << endl << arraymanager << endl << repeat << endl << endl;
    //cout << score[0] << " " << score[1] << " " << score[2] << " " << score[3] << " " << score[4] << " " << score[5] << " " << score[6] << " " << score[7] << " " << score[8] << endl << endl;

    cout << endl << average << endl;
    return 0;
}
