/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P07
Date:			03/16/2018
Description:	This program will process and save payroll information
				to a file. The program uses a switch statement to allow
				the user to create a new file, input new information into
				a new or existing file and display information saved to 
				that file.
*********************************************************************/

#include "stdafx.h"
#include <stdlib.h>
#include <fstream>  // where the commands to do file processing are defined
#include <iostream> // cin and cout
#include <cctype>   // toupper (will avoid case issues during user input)
#include <iomanip>  // setw

using namespace std;

//menu options... listing them here is called function.. prototypes I think?
//Opt A: 
void createNewFile();

//Opt B: 
void enterInfo();

//Opt C:    
void listInfo();

//Supporting functions
void displayContinuePrompt();


//Program starts here   
int main()
{
	cout << "P07 - Dave Minkowski\n\n";
	//Declare local variable to store menu option selected
	char   choice;

	//Check to see what the user wants to do
	do  //while (choice != 'X')
	{
		cout << "P07   Main Menu   \n\n";

		cout << "Enter the letter of the desired menu option. \n"
			<< "Press the Enter key after entering the letter. \n\n"

			<< "  A: Create a new file for Payroll Information  \n"
			<< "  B: Enter Payroll Information  \n"
			<< "  C: List Payroll Information   \n\n"

			<< "  X: Exit the Payroll Information Module \n\n"

			<< "Choice: ";

		cin >> choice; // where choice is A, B, C, or X (the choice variable will accept other values, but the value is subject to the switch controls below)
		cout << "\n\n";

		choice = toupper(choice); //convert to uppercase

		switch (choice)
		{
		case 'A':
			createNewFile();	// call the createNewFile function
			break;
		case 'B':
			enterInfo();		// call the enterInfo function
			break;
		case 'C':
			listInfo();			// call the listInfo function
			break;

		case 'X':
			cout << "Now exiting Payroll Information...please wait.\n\n";
			break;
		default:
			cout << "\a"; // the defautl option for the switch statement, displaying an error if the choice is not a, b, c, or x
			cout << "Invalid Option Entered - Please try again. \n\n";

		}//end of switch

	} while (choice != 'X');	// do while loops execute at least once, so the menu will be presented initially (at least once) to the user. Should the user choose 'x'
								// which has been described to the user as the exit control, the program will terminate

	return 0;
}//end of main


 // ========================================================================= \\ Function Definitions // ========================================================================= \\
 
void createNewFile()
{
	//Declare local variables
	char answer;	// holds a char (y or n) which will control the behavior of the function - functionally identical to the choice variable in main(), though the
					// control of the function is now handled with an if statement since only 2 options are available to the user. 

	cout << "Dave Minkowski P07     Create new file for Payroll Information \n\n";

	//Prompt the user if they want to create a new file- "yes or no"
	cout << "Creating a new file will delete any existing information. \n";
	cout << "Do you want to proceed with creating a new file? (Y/N) ";
	cin >> answer;

	if (toupper(answer) == 'Y')	// if answer is y or Y, then:
	{
		ofstream outFile; // define an output file stream (ofstream) object called outFile
		outFile.open("p07payroll.txt"); // function call to the open method (contained in fstream?) using the stream defined above (outFile) 
										// and associating the outFile with p07payroll.txt... as I understand this: "use p07payroll.txt to save the info entered in outFile"
		if (outFile.fail()) // If there are any errors, display an error message and return... outFile.fail() is a boolean returning true if there is an output error, nothing else
							// for us to define in this case. 
			{
				cout << "\n  Error: Output file could NOT be created. "; // error message
				displayContinuePrompt(); // The "Procedure completed. Press enter to continue" method below. (a pause in the execution)
				return;
			} // end innner if
		cout << "\n  New file created successfully! "; // else display message that a file was created successfully
		outFile.close(); //Close the file
	} // end outer if
	
	else{	//else display a message that a new file was NOT created
		cout << "\n  New file NOT created.";
	}

	//Call displayContinue to pause
	displayContinuePrompt();
	return;
}


void enterInfo()
{
	//Declare local variables
	int employeeId;
	double rate;
	int w1Hours, w2Hours, w3Hours, w4Hours;
	char answer;

	cout << "Dave Minkowski P07     Enter Payroll Information \n\n";

	//Open the file for output
		ofstream outFile;
		outFile.open("p07payroll.txt", ios::app); //  ios:app = append - instead of creating a new file, we are adding entries to the end of the existing file.
	//If there are any errors display an error message and return.
		if (outFile.fail()) // .fail() again, boolean true or false
		{
			cout << "  Error: Output file NOT found. ";
			displayContinuePrompt();
			return;
		}

	//Set output to 2 decimal positions for file
		outFile.setf(ios::fixed);
		outFile.setf(ios::showpoint);
		outFile.precision(2);

	//Use a do-while loop to get input
		do
		{
	//  Display prompt and get the data
			cout << "  Enter the 4-digit Employee ID, hourly pay rate and each weekly hourly total in the format:\n\n";
			cout << "  EmployeeID PayRate Wk1 Wk2 Wk3 Wk4\n\n  ";
			cin >> employeeId >> rate >> w1Hours >> w2Hours >> w3Hours >> w4Hours;
	//  Write data to file and format using setw manipulators
			
			outFile << setw(5) << employeeId;	// this took forever to figure out, this also formats the text file with whitespace! the powerpoint describes it and I just kept glancing over it
			outFile << setw(7) << rate;			// not understanding, I assumed the function to read the file REQUIRED a single space delimited file and I see now that it doesn't.   
			outFile << setw(4) << w1Hours;		// I had a problem with my employeeId and rate values being mashed together and written as a single value in the text file, which
			outFile << setw(4) << w2Hours;		// was being reading back in cout. Anyway, I think I fully understand this part of setw now.
			outFile << setw(4) << w3Hours;		
			outFile << setw(4) << w4Hours;		// no justification formatting is set because numeric output is right justified by default. 
			outFile << endl;

	//  Prompt user if they want to add another employee
			cout << "\n\n    Would you like to add another employee? (Y/N) ";
			cin >> answer;
	//  Do loop again if they don't enter N
		} while (toupper(answer) != 'N');
	//end do-while loop

	//Close the file
		outFile.close();

	//Call displayContinue to pause
	displayContinuePrompt();
	return;
}


void listInfo()
{
	//Declare local variables
	int employeeId;
	double rate;
	int w1Hours, w2Hours, w3Hours, w4Hours;

	cout << "Dave Minkowski P07      List Payroll Information \n\n";

	//Open the file for input  
	ifstream inFile; // define an input file stream (ifstream) object called inFile
	inFile.open("p07payroll.txt"); // read to infile from p07payroll.txt
	if (inFile.fail()) //If there are any errors opening the txt file, then
	{
		cout << "  Error: Input file NOT found. "; // error message to display
		displayContinuePrompt();
		return;
	}
	//Set output to 2 decimal positions for cout
	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	//Display headings
	cout << "Employee   Rate	  Week 1   Week 2   Week 3   Week 4 \n\n";

	// read the first record
	inFile >> employeeId >> rate >> w1Hours >> w2Hours >> w3Hours >> w4Hours;

	//Use while loop to process file, because while loops handle empty files.
	while (!inFile.eof()) // while not @ end of file, continue looping
	{
		cout << setw(6) << employeeId; 		// Display record/format using setw manipulators
		cout << setw(9) << rate;			// this was easier to understand than the file formatting for some reason, probably because I could immediately see the effect that setw was
		cout << setw(7) << w1Hours;			// having on the output.
		cout << setw(9) << w2Hours;
		cout << setw(9) << w3Hours;
		cout << setw(9) << w4Hours;
		cout << endl;

		// read next record
		inFile >> employeeId >> rate >> w1Hours >> w2Hours >> w3Hours >> w4Hours;
	}

	inFile.close(); // close file

	displayContinuePrompt();

	return;
}

void displayContinuePrompt()
{
	//Declare local variables
	char prompt;

	cout << "\n\nProcedure completed. Press Enter to continue: "; // prompt to wait and continue between steps of the program
	cin.ignore();
	prompt = cin.get();

	system("cls");   //clear screen - DOS

	return;
}
//End of program