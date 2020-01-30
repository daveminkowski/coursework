/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P08
Date:			03/25/2018
Description:	This program uses a simple array and a data file to 
				loads, sort and search a partially filled array of 
				employee ID's (integers).
*********************************************************************/

#include "stdafx.h"
#include <stdlib.h> // system()
#include <fstream>  // where the commands to do file processing are defined
#include <iostream> // cin and cout
#include <cctype>   // toupper (will avoid case issues during user input)
#include <iomanip>  // setw

using namespace std; 

//Global Constants
//When using to declare arrays, must be defined with const modifier
const int  ARRAY_SIZE = 20;

//Declare arrays as global so we don't have to pass the arrays to each function.
//Normally we wouldn't declare variables that change values a global.

int  employeeId[ARRAY_SIZE];	//employeeID array with a size tbd by the declared constant
int  numberOfEmps;	//count of how many employees were loaded into arrays

void loadArray();

void sortArrayAscending();

void sortArrayDescending();

void displayArray();

void searchArray();

void displayContinuePrompt();


//Program starts here   
int main()
{
	cout << "P08 - Dave Minkowski\n\n";

	char   choice;	//char variable to hold the user choice for the switch statement
							 
	loadArray();	//Load the arrays with data

	//check to see what the user wants to do
	do    //will execute at least once then loop is choice is a, b, c, or d (not x)
	{
		cout << "P08   Dave Minkowski   \n\n";

		cout << "Enter the letter of the desired menu option. \n"
			<< "Press the Enter key after entering the letter. \n \n"

			<< "  A: Display Employee Id (current order) \n"
			<< "  B: Display Employee Id Ascending Order \n"
			<< "  C: Display Employee Id Descending Order \n"
			<< "  D: Search Employee Id List \n"

			<< "  X: Exit the program \n \n"

			<< "Choice: ";

		cin >> choice; //take the user input, save as char choice

		choice = toupper(choice); //ensure char choice can be entered as lower or upper case

		switch (choice) // switch statement dependent on the char choice variable, matching the menu above
		{
		case 'A':	// display array as entered, prompt for user action
			cout << "Current order of Employee Ids:\n";
			displayArray();								
			displayContinuePrompt();
			break;
		case 'B':	// sort array (ascending) then display array as sorted, prompt for user action
			cout << "Employee Ids sorted ascending:\n";
			sortArrayAscending();					
			displayArray();
			displayContinuePrompt();
			break;
		case 'C':	// sort array (descending) then display array as sorted, prompt for user action
			cout << "Employee Ids sorted descending:\n";
			sortArrayDescending();
			displayArray();
			displayContinuePrompt();
			break;
		case 'D':	// search array for a specific employee Id
			searchArray();
			displayContinuePrompt();
			break;
		case 'X':	// end loop, exit program, no user prompt
			cout << "Now exiting. Please wait...\n\n";
			break;
		default:
			cout << "\a \n\n Invalid Option Entered - Please try again. \n\n";

		} // end of switch

	} while (choice != 'X'); // proceed as long as char choice is not x, else terminate

	return 0;
} // end of main


  //Function Definitions
void loadArray()
{

	//Students must code the rest of this function

	//Open the file for input. If there are any errors, display error message and return.
	ifstream inFile; // instream object 'inFile'
	inFile.open("p08.txt"); // open text file as the inFile object

	if (inFile.fail())																// if inFile fails to open the txt file above,
	{
		cout << endl << endl << "Error: Input file NOT found. " << endl << endl;	// display this error,
		numberOfEmps = 0;															// and set numberOfEmps to 0.
		return;
	}

	cout << "Loading up to " << ARRAY_SIZE << " whole numbers.\n";	// announcing how many array elements the program can load to display and sort, 
																	// depending on the declared ARRAY_SIZE constant (currently 20)

	//Declare index and initialize to zero for counting array elements
	int  i = 0;

	//Read the first record into array 

	inFile >> employeeId[i];	// each array element [i] is taken from each line listed in the p08 text file

	//Use while loop to process file, because while loops handle empty files.

	while (!inFile.eof()) // while the infile is not at the end of file (while it has a text to parse, not an empty line)
	{
		i++;							// incrememt array element counter by 1
		if (i < ARRAY_SIZE)				// if array element counter is less than the maximum size of the array
			inFile >> employeeId[i];	// read each line of the text file and store the value as the next array element's value
		else
			break; // break the loop when i reaches ARRAY_SIZE
	}
	
	numberOfEmps = i + 1;	// 1 is added to i here because it was initialized from 0 and we cant have 0 employees entered WITH a valid input from the file.

	cout << "Closing File...\n\n";
	inFile.close();	// closing file

	return;
}


void sortArrayAscending()
{
	int minIndex, minValue, holdValue;

	for (int i = 0; i < numberOfEmps; i++)				// loop for each array element in the array
	{
		minIndex = i;									// lowest index starts as 0, increments by each index processed
		minValue = employeeId[i];						// lowest value starts as the first value collected, incrementing by each value processed

		for (int j = i + 1; j < numberOfEmps; j++)
		{
			if (employeeId[j] < minValue)				// for each array element cycled above, this inner loop checks if the current array value is less than the previous "low"
			{
				minIndex = j;							// if it is, the new "lowest" index is the index of the new lowest value
				minValue = employeeId[j];				// and the currently processing array value becomes the new lowest value
			}
		}

		holdValue = employeeId[i];				// holdValue is assigned with the index of employeeId[i]
		employeeId[i] = employeeId[minIndex];	// the index of the employeeId array is assigned with the lowest array index (employeeId[minIndex])
		employeeId[minIndex] = holdValue;		// the lowest index of the array is assigned with the holdValue value
	}
	return;
}

void sortArrayDescending()								//	functionally identical to the above loop except for the greater sign in line 193 and the variables declared in line 184 -
{														//  It searches for the highest values rather than the lowest
	int maxIndex, maxValue, holdValue;

	for (int i = 0; i < numberOfEmps; i++)				// loop for each array element in the array
	{                                                
		maxIndex = i;									// lowest index starts as 0, increments by each index processed
		maxValue = employeeId[i];						// lowest value starts as the first value collected, incrementing by each value processed

		for (int j = i + 1; j < numberOfEmps; j++)
		{                                            
			if (employeeId[j] > maxValue)				// for each array element cycled above, this inner loop checks if the current array value is more than the previous "high"
			{
				maxIndex = j;							// if it is, the new "highest" index is the index of the new highest value
				maxValue = employeeId[j];				// and the currently processing array value becomes the new highest value
			}
		}

		holdValue = employeeId[i];                  //swap the values
		employeeId[i] = employeeId[maxIndex];
		employeeId[maxIndex] = holdValue;
	}

	return;
}


void displayArray() // displaying the sorted position, index and value held in each array element
{
	cout << endl;
	cout.setf(ios::right);  //already on by default for numbers

	for (int i = 0; i < numberOfEmps; i++)
	{
		cout << "position =";
		cout << setw(3) << (i + 1); // position must be at least 1 when counting from 0

		cout << "  index =";
		cout << setw(3) << i;		// don't add 1 to the actual index #

		cout << "  value = ";
		cout << setw(4) << employeeId[i]	// the employee id #
			<< endl;
	}
	return;
}

//Early exit - an early exit from a search can occur when we know that
//the value we are looking for will not be found in the array.  To
//implement an early exit, the array must be sorted ascending.
//If  we can determine that a value will not be found, we should
//not search the remainder of the array.

void searchArray()
{
	//array must be sorted ascending for early exit logic to work  
	sortArrayAscending();

	int  searchId;		// value for employeeId to search for
	bool numberFound = false;	// boolean trigger

	cout << "Enter Employee Id to search for: ";
	cin >> searchId;	// input searchId value

	for (int i = 0; i < numberOfEmps; i++)		// process array for the searchId entered
	{
		if (searchId == employeeId[i])      //check if the value entered is equal to the current array value being processed
		{                                        
			numberFound = true;										// if the searchId matches the array value, set the bool numberFound to true,
			cout << endl
				<< searchId << " is stored in array position "		// display the ID and its position in the array,
				<< i + 1
				<< " and is \nreferenced with an index value of "	// and display its array index.
				<< i << ". \n\n";
			break;	// exit loop
		}
		else if (searchId < employeeId[i])
		//Early exit - since the array is pre-sorted, any search value that is less than the lowest value of the sorted array 
		// can be ignored and the search can be terminated. (Example: if the array values were integers 20-50 and we searched for, say, 15.... 
		// we would never find 15 in a search)
		{
			cout << endl << "Early exit...";
			break;	// exit loop
		}
	}

	if (false == numberFound)							 // if numberFound is still false
		cout << searchId << " is not on the list.\n";	 // output a "not found" message

	return;
}

void displayContinuePrompt() // the pause between command input and proceeding through the program
{
	char prompt;

	cout << "\n\nProcedure completed. Press Enter to continue: ";
	cin.ignore();
	prompt = cin.get();

	system("cls");

	return;
}
//End of program

