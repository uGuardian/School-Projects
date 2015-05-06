#include <iostream>
#include <string>
#include <windows.h>
#include <math.h>
#include <windowsx.h>
#include <d3d9types.h>
using namespace std;

void define();
void display();
void input();
void repeat();
bool seats[11][11];
double cost = 0;
char buffer;
bool cont = 0;
int col = 1;
int row = 0;
int main()
{
	define();
	display();

	do {
	input();
	cout << endl << "You owe $" << cost << endl;
	cout << "Continue? (y/n)" << endl;
	cin >> buffer;
	} while (buffer == 'y' or buffer == 'Y');

	cout << endl;
	return 0;
}

void define()
{
	int def1 = 0;
	int def2 = 0;
	while (def2 < 12)
	{
	seats[def1][def2] = 0;
	def1 = def1 + 1;

	if (def1 == 12)
	{
		def2 = def2 + 1;
		def1 = 0;
	}
	}
}

void display()
{
	int def1 = 0;
	int def2 = 0;
	int line = 1;
	system("cls");

	cout << "0 123456789" << endl << endl << "1 ";

	while (def2 < 9)
	{

	if (seats[def1][def2] == 0)
	{
	cout << "O";
	}
	else
	{
	cout << "X";
	}

	def1 = def1 + 1;

	if (def1 == 9)
	{
		line = line + 1;
		if (line != 10)
		{
		cout << endl << line << " ";
		}
		def2 = def2 + 1;
		def1 = 0;
	}

	}
}

void input()
{
	int choice = 0;
	bool finished = 0;
	cout << endl << endl << "Please Enter what kind of seat you want" << endl << "1 - Prices of seats are" << endl << "2 - Adult: $5.00" << endl << "3 - Child: $3.50" << endl << "4 - Senior: $∞" << endl;
	do {
	cin >> choice;
		switch (choice)
			{
			case 1:
				cout << endl << "Did you just... Really?" << endl << "Please enter something else" << endl;
				break;
			case 2:
				cout << endl << "That will be $5.00" << endl << endl;
				cost = cost + 5;
				finished = 1;
				break;
			case 3:
				cout << endl << "That will be $3.50" << endl << endl;
				cost = cost + 3.5;
				finished = 1;
				break;
			case 4:
				cout << endl << "That will be all the money" << endl << endl;
				finished = 1;
				break;
			default:
				cout << endl << "Please enter something else" << endl;
				break;
			}
	} while (finished == 0);
	cout << "You are getting ";
	switch (choice)
		{
		case 2:
			cout << "an adult";
			break;
		case 3:
			cout << "a child";
			break;
		case 4:
			cout << "a senior";
			break;
		}
	cout << " seat" << endl;
	cout << "Please enter column, then press enter and enter row" << endl;
	int cont = 0;
	repeat();
	seats[row][col] = 1;
	display();
}

void repeat()
{
	cin >> col;
	cin >> row;
	col = col - 1;
	row = row - 1;
	if (seats[row][col] == 1)
		{
		cont = 1;
		cout << "That seat is already taken, pick another" << endl;
		repeat();
		}
	if (row > 8 or col > 8)
		{
		cont = 1;
		cout << "That seat doesn't exist, pick another" << endl;
		repeat();
		}
}
