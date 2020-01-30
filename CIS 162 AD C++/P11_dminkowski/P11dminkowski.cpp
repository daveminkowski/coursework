/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P11
Date:			04/16/2018
Description:	This program is a driver to test the SalesPerson class.
				It is used to create 2 objects, which test the constructors
				and accessors. The objects created are saved to p11.txt.
*********************************************************************/

#include "stdafx.h"
#include <fstream>  // file processing
#include <iostream> // cin and cout
#include <iomanip>  // setw
#include <string>   // string class

using namespace std;
void displayContinuePrompt(); // press enter to continue

//Class definition -  the interface for the class
class SalesPerson{	// Start Class Definition

private:
	//private member variables require accessors
	int salesPersonId = 0;
	string firstName = "";
	string lastName = "";

public:
	

	// default constructor has no values
	SalesPerson::SalesPerson() {

	}

	// overloaded constructor with parameter names that are different from the class variable names
	SalesPerson::SalesPerson(int id, string fn, string ln) {
		salesPersonId = id;
		firstName = fn;
		lastName = ln;
	}

	//Destructor
	SalesPerson::~SalesPerson()
	{
		cout << "\nSalesPerson Object going out of scope. Id = "
			<< salesPersonId << endl;
		return;
	}

	// accessors
	// set accessors are used to assign a value to a private variable and have no return type. The value that will be assigned is passed
	// through the parameter (int id will change int salesPersonId) -  these are passed to the constructor

	void SalesPerson::setSalesPersonId(int id){
		salesPersonId = id;
	}

	void SalesPerson::setFirstName(string fn){
		firstName = fn;
	}

	void SalesPerson::setLastName(string ln){
		lastName = ln;
	}

	// get accessors are used to return the value stored in a private variable, so a parameter is NOT passed but we do declare the return type of the variable value we are
	// trying to "get"

	int SalesPerson::getSalesPersonId() {
		return salesPersonId;
	}

	string SalesPerson::getFirstName() {
		return firstName;
	}

	string SalesPerson::getLastName() {
		return lastName;
	}


	// input accessors prompt for get, and store a value in a private variable. There is no return value and no parameter is passed.
	void SalesPerson::inputSalesPersonId() {
		cout << "Enter Salesperson ID:";
		cin >> salesPersonId;
	}

	void SalesPerson::inputFirstName() {
		cout << "Enter First Name without spaces: ";
		cin >> firstName;
	}

	void SalesPerson::inputLastName() {
		cout << "Enter Last Name without spaces: ";
		cin >> lastName;
	}

};		// End class definition


		
//Application Starts here (prototypes, main(), and definitions for application)
//saves info to a file and displays to screen

void outputSalesInfo(ostream& target, SalesPerson& salesPersonObj);

//main driver to test SalesPerson class
int main()
{
	cout << "P11 - Dave Minkowski\n\n";
	//Open the file for output; if there are any errors, we need to 
	//display an error message.

	ofstream outFile;
	outFile.open("P11.txt");
	if (outFile.fail())
	{
		cout << "Error opening output file for sales information.\n"
			<< "Exiting program \n\n";
		return 0;
	}

	cout << "\nP11     Dave Minkowski  \n\n";

	//1001 Joe Smith - use default constructor and input functions
	SalesPerson salesPersonObj;
	salesPersonObj.inputSalesPersonId();
	salesPersonObj.inputFirstName();
	salesPersonObj.inputLastName();

	//Save the sales data to the file and display on the screen
	outputSalesInfo(outFile, salesPersonObj);

	//1002  Larry Jones - use set functions to change values.
	salesPersonObj.setSalesPersonId(1002);
	salesPersonObj.setFirstName("Larry");
	salesPersonObj.setLastName("Jones");

	//Save the sales data to the file and display on the screen
	outputSalesInfo(outFile, salesPersonObj);

	//1003 Paul Sailor - use overloaded constructor 
	SalesPerson salesPersonObj2(1003, "Paul", "Sailor");

	//Save the sales data to the file and display on the screen.
	outputSalesInfo(outFile, salesPersonObj2);

	displayContinuePrompt();

	// Close the output file and exit program
	outFile.close();
	return 0;

}//end main

 //save the order information to a file or display to screen.
 //target can be either cout or outFile because ofstream inherits ostream.
 //ofstream objects are also ostream objects.
 //also, must be ostream because cout is already declared as an ostream.

void outputSalesInfo(ostream& target, SalesPerson& salesPersonObj)
{
	//declare local variables
	int    salesPersonId;
	string lastName, firstName;

	//Have the class return the private values to the local variables.
	//Then store them in the file.
	salesPersonId = salesPersonObj.getSalesPersonId();
	firstName = salesPersonObj.getFirstName();
	lastName = salesPersonObj.getLastName();

	cout << "\n\nSales Person's Information Saved! \n";
	cout << salesPersonId
		<< "\t" << firstName
		<< "\t" << lastName
		<< endl;

	target.setf(ios::left);
	target << setw(6) << salesPersonId
		<< setw(18) << firstName
		<< setw(18) << lastName
		<< endl;
	target.unsetf(ios::left);

	return;
}

void displayContinuePrompt()
{
	char prompt;

	cout << "\n\nPress Enter to continue: ";
	cin.ignore();
	prompt = cin.get();

	system("cls");

	return;
}


