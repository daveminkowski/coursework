/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P09
Date:			04/01/2018
Description:	This excercise computes the average of hours worked
				after taking values from a parallel array and processing
				the array per entry.
*********************************************************************/

#include "stdafx.h"
#include <fstream>  // file processing
#include <iostream> // cin and cout
#include <cctype>   // toupper
#include <iomanip>  // setw
#include <cstring>  // cstring functions strlen, strcmp, strcpy stored in string.h
#include <string>   // string class

using namespace std;

//Disable warning messages C4267 C4996.
//To see the warnings, comment out the following line.
#pragma warning( disable : 4267 4996)

//Warning C4267: conversion from size_t to int, possible lost of data
//size_t is a data type defined in  and is an unsigned integer.
//The function strlen returns a value of the type size_t, but in 
//searchByName we assign the returned value to an int. 
//We could also declare the variable as size_t instead of int.
//   size_t stringLength;

//Warning C4996: strnicmp strcpy, stricmp was declared deprecated, means
//the compiler encountered a function that was marked with deprecated. 
//The deprecated function may no longer be supported in a future release.


//Global Constants
//When using to declare arrays, must be defined with const modifier
//  HOURS_SIZE = 4,
const int  ARRAY_SIZE = 20, HOURS_SIZE = 4, NAME_SIZE = 16;

//Declare arrays as global so we don't have to pass the arrays to each function.
//Normally we wouldn't declare variables that change values a global.
int    employeeId[ARRAY_SIZE];
string firstName[ARRAY_SIZE];
char   lastName[ARRAY_SIZE][NAME_SIZE];
double rate[ARRAY_SIZE];
int    hours[ARRAY_SIZE][HOURS_SIZE];
int    numberOfEmps;    //count of how many employees were loaded into arrays

int   sumHours[ARRAY_SIZE] = { 0 }; //initialize arrays to zero by providing a   
double avgHours[ARRAY_SIZE] = { 0 }; //value for the first element in the array

									 //Function Prototypes

void loadArray();
void sumAndComputeAvgHours();

void listByName();
void searchByName();
void sortByName();
void swapValues(int i, int minIndex);

void listEmployees();
void listEmployeesHeadings();
void listEmployeesDetails(int i);
void listEmployeesTotals();

void displayContinuePrompt();


//Program starts here   
int main()
{
	cout << "P09 - Dave Minkowski	\n\n";
	//Declare and initialize local main variables
	char   choice;            //menu option

							  //Load the arrays with data
	loadArray();

	//Sum and compute the average hours
	sumAndComputeAvgHours();

	//check to see what the user wants to do
	do  // while (choice != 'X')
	{
		cout << "P09   Dave Minkowski  \n\n";

		cout << "Enter the letter of the desired menu option. \n"
			<< "Press the Enter key after entering the letter. \n \n"

			<< "  A: List Payroll Information by Employee Name \n"
			<< "  B: Search Payroll Information by Name \n\n"

			<< "  X: Exit the Payroll Information Module \n \n"

			<< "Choice: ";

		cin >> choice;
		choice = toupper(choice);

		switch (choice)
		{
		case 'A':
			listByName();
			break;
		case 'B':
			searchByName();
			break;
		case 'X':
			cout << "\n\nNow exiting Payroll Information...please wait.\n\n";
			break;
		default:
			cout << "\a\n\n Invalid Option Entered - Please try again. \n\n";

		} // end of switch

	} while (choice != 'X');

	return 0;
} // end of main


  //Function Definitions
void loadArray()
{
	//Open the file for input; 
	ifstream fileIn;
	fileIn.open("p09.txt");
	//If there are any errors, display an error message and return.
	if (fileIn.fail())
	{
		cout << endl << endl
			<< "Error: Input file NOT found. " << endl << endl;
		displayContinuePrompt();
		numberOfEmps = 0;
		return;
	}

	//Intialize index to load the 1st record into the 1st row of the array 
	int i = 0;

	//Read the first record.  Reads into the arrays
	fileIn >> employeeId[i] >> lastName[i] >> firstName[i] >> rate[i]
		>> hours[i][0] >> hours[i][1] >> hours[i][2] >> hours[i][3];

	//Process the remaining records if any
	while (!fileIn.eof())
	{
		i++;
		if (i == ARRAY_SIZE)
		{
			cout << endl << endl
				<< "Warning: Array Size Exceeded! Size = " << ARRAY_SIZE
				<< "Processing will continue.  Proceed with caution." << endl << endl;
			break;  // get out of while loop
		}
		fileIn >> employeeId[i] >> lastName[i] >> firstName[i] >> rate[i]
			>> hours[i][0] >> hours[i][1] >> hours[i][2] >> hours[i][3];
	}

	//Save the number of records loaded
	numberOfEmps = i + 1;

	//close the file
	fileIn.close();

	return;
}


//To be implemented by student 
//If done efficiently, you'll only need to write 5 lines of code to complete the assignment
void sumAndComputeAvgHours()
{
	for (int i = 0; i < numberOfEmps; i++) // loop for each employee entered in the record
	{
		for (int j = 0; j < HOURS_SIZE; j++)					// second loop for the 2nd placeholder in the parallel array, to increment i and j 									
		{														// independently (since the hours array has two "columns")

			sumHours[i] = sumHours[i] + hours[i][j];	// I wasn't sure if this was what you meant when you said accumulate. Every consecutive element in the sumHours array is simply
														// the previous value added to the next value in the hours array. In this case, it works since the cout expressions below
														// display the value of sumHours[i], which led me to believe that I only needed a placeholder for the values and I wasn't actually
														// going to be averaging the sum of all the values in the array. Does that make sense? Basically, by adding the elements to the array in this
														// fashion, the act of merely placing the elements ended up doing the addition for me. I didn't know if this was right, but it was the only 
														// way I could properly get the totals to display.
		}
		avgHours[i] = (double)sumHours[i] / HOURS_SIZE;		// each element in the average array is the value of sumHours[i]/HOURS_SIZE. The static cast here can be used on the 
															// array or the constant.
	}
	return;
}


//Opt A: List by Name
void listByName()
{
	sortByName();
	listEmployees();
	displayContinuePrompt();
	return;
}

//Students are NOT required to do any coding involving cstrings, but
//they are required to understand how to use them.  Below are a few
//examples of the functions used to manipulate cstrings. 

//Opt B: Search by Name
void searchByName()
{
	//To facilitate the early exit logic, data must be sorted by name 
	sortByName();

	//declare searching variables
	int  stringLength;
	char searchName[NAME_SIZE];
	bool recordFound = false;
	bool headingsDisplayed = false;

	//Since we are supporting a wildcard search, there could be more than
	//one lastName that matches the search criteria.  However, we only 
	//want to display the headings after the first match and not for the
	//subsequent matches.  We use headingsDisplayed for this logic.

	cout << "\n\nEnter the Employee Name to search for: ";
	cin >> searchName;

	//We only compare upto the length of the search string
	stringLength = strlen(searchName);     // '\0' not included in length

										   //strncmp is case sensitive and strnicmp ignores case 
	for (int i = 0; i < numberOfEmps; i++) //walk through the array
	{
		if (strnicmp(lastName[i], searchName, stringLength) == 0)
		{
			if (!headingsDisplayed)
			{
				listEmployeesHeadings();   //display the headings to cout 
				headingsDisplayed = true;  //only after 1st match
			}                               //display the record found
			recordFound = true;
			listEmployeesDetails(i);
			//don't get out of the for-loop, because there may be more matches
		}
		else if (strnicmp(lastName[i], searchName, stringLength) > 0)  //early exit 
		{
			cout << endl << "Early exit...";
			break;                            //get out of for-loop
		}
	}

	if (false == recordFound)
	{
		cout << "Employee Name not on file. \n";
	}

	displayContinuePrompt();
	return;
}


void sortByName()
{
	//First for-loop walks through the entire array 
	//The current entry is saved as the min value

	//Second for-loop looks for values lower than the
	//current value.  If one is found, then all values are swapped.
	int    minIndex;
	char   minName[NAME_SIZE];

	for (int i = 0; i < numberOfEmps; i++)
	{
		minIndex = i;
		strcpy(minName, lastName[i]);

		for (int i2 = i + 1; i2 < numberOfEmps; i2++)
		{
			if (stricmp(lastName[i2], minName) < 0) //if str1 < str2  
			{                                     //a neg number returned 
				minIndex = i2;
				strcpy(minName, lastName[i2]);
			}
		}
		swapValues(i, minIndex);
	}
	return;
}


void swapValues(int i, int minIndex)
{
	//temp holding variables
	int    holdInt;
	char   holdName[NAME_SIZE];
	string holdStr;
	double holdDbl;

	holdInt = employeeId[i];
	employeeId[i] = employeeId[minIndex];
	employeeId[minIndex] = holdInt;

	//lastName is a cstring - use functions to manipulate
	strcpy(holdName, lastName[i]);
	strcpy(lastName[i], lastName[minIndex]);
	strcpy(lastName[minIndex], holdName);

	//firstName is a string object - use overloaded operators
	holdStr = firstName[i];
	firstName[i] = firstName[minIndex];
	firstName[minIndex] = holdStr;

	holdDbl = rate[i];
	rate[i] = rate[minIndex];
	rate[minIndex] = holdDbl;

	holdInt = hours[i][0];
	hours[i][0] = hours[minIndex][0];
	hours[minIndex][0] = holdInt;

	holdInt = hours[i][1];
	hours[i][1] = hours[minIndex][1];
	hours[minIndex][1] = holdInt;

	holdInt = hours[i][2];
	hours[i][2] = hours[minIndex][2];
	hours[minIndex][2] = holdInt;

	holdInt = hours[i][3];
	hours[i][3] = hours[minIndex][3];
	hours[minIndex][3] = holdInt;

	holdInt = sumHours[i];
	sumHours[i] = sumHours[minIndex];
	sumHours[minIndex] = holdInt;

	holdDbl = avgHours[i];
	avgHours[i] = avgHours[minIndex];
	avgHours[minIndex] = holdDbl;

	return;
}


void listEmployees()
{
	listEmployeesHeadings();

	for (int i = 0; i < numberOfEmps; i++)
	{
		listEmployeesDetails(i);
	}

	listEmployeesTotals();
	return;
}


void listEmployeesHeadings()
{
	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	cout << "\n\nP09    Your Name Here     \n\n"
		<< "Employee  Last name        F.     "
		<< "Rate   Wk1   Wk2   Wk3   Wk4   Total  Average\n\n";
	return;
}


void listEmployeesDetails(int i)
{
	cout << setw(6) << employeeId[i] << "    ";

	cout.setf(ios::left);
	cout << setw(17)
		<< lastName[i]
		<< firstName[i][0] << ".";
	cout.unsetf(ios::left);

	cout << setw(9) << rate[i];

	for (int i2 = 0; i2 < HOURS_SIZE; i2++)  // i2 = 0,1,2,3
	{
		cout << setw(6) << hours[i][i2];
	}
	cout << setw(7) << sumHours[i]
		<< setw(9) << avgHours[i]
		<< endl;

	return;
}


void listEmployeesTotals()
{
	cout << "\nRecords Listed: " << numberOfEmps << endl << endl;
	return;
}


void displayContinuePrompt()
{
	char prompt;

	cout << "\n\nProcedure completed. Press Enter to continue: ";
	cin.ignore();
	prompt = cin.get();

	system("cls");   //clear screen - DOS

	return;
}
//End of program
