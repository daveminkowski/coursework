/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P12
Date:			04/23/2018
Description:	This program is a driver to test SalesInfo class, which
				inherits SalesPerson. It is used to create 2 objects,
				which test the constructors and accessors. The objects
				created are saved to P12.txt
*********************************************************************/

#include "stdafx.h"
#include <fstream>  // file processing
#include <iostream> // cin and cout
#include <iomanip>  // setw
#include <string>   // string class

using namespace std;

void displayContinuePrompt(); // press enter to continue

class SalesPerson {	// Start Class Definition

protected:

	//private member variables require accessors
	int salesPersonId = 0;
	string firstName = "";
	string lastName = "";

public:

	// default constructor has no values
	SalesPerson();

	// overloaded constructor with parameter names that are different from the class variable names
	SalesPerson(int id, string fn, string ln);

	//Destructor
	~SalesPerson();

	// accessors
	// set accessors are used to assign a value to a private variable and have no return type. The value that will be assigned is passed
	// through the parameter (int id will change int salesPersonId) -  these are passed to the constructor
	void setSalesPersonId(int id);
	void setFirstName(string fn);
	void setLastName(string ln);

	// get accessors are used to return the value stored in a private variable, so a parameter is NOT passed but we do declare the return type of the variable value we are
	// trying to "get"

	int getSalesPersonId();
	string getFirstName();
	string getLastName();

	// input accessors prompt for get, and store a value in a private variable. There is no return value and no parameter is passed.
	void inputSalesPersonId();
	void inputFirstName();
	void inputLastName();

};		// End SalesPerson definition

class SalesInfo : public SalesPerson
{
private:
	double rate;
	int    qty;

public:
	// default constructor has no values
	SalesInfo();

	// overloaded constructor - since salesInfo inherits SalesPerson, it must also list the variables in the base class (id, fn, ln). The values will be passed to the constructor in the base class
	SalesInfo(int id, string fn, string ln, double rt, int qt);

	//Destructor
	~SalesInfo();

	// accessors
	// set accessors are used to assign a value to a private variable and have no return type. The value that will be assigned is passed
	// through the parameter (int qt will change int qty) -  these are passed to the constructor
	void setRate(double rt);
	void setQty(int qt);

	// get accessors are used to return the value stored in a private variable, so a parameter is NOT passed but we do declare the return type of the variable value we are
	// trying to "get"

	double getRate();
	int getQty();

	// input accessors prompt for get, and store a value in a private variable. There is no return value and no parameter is passed.
	void inputRate();
	void inputQty();

};		// End SalesInfo Definition


//This function saves sales info to a file or displays to screen (cout)
void outputSalesInfo(ostream& target, SalesInfo& salesInfoObj);


int main()
{
	cout << "P12 - Dave Minkowski\n\n";

	//Open the file for output

	ofstream outFile;
	outFile.open("P12.txt");
	if (outFile.fail())
	{
		cout << "Error opening output file for sales information.\n"
			<< "Exiting program \n\n";
		return 0;
	}

	cout << "\nP12 Dave Minkowski \n\n";


	//1001 Joe Smith 5.00, 25 - use default constructors and input functions
	SalesInfo salesInfoObj;
	salesInfoObj.inputSalesPersonId();
	salesInfoObj.inputFirstName();
	salesInfoObj.inputLastName();


	//Save the sales data as a record to the file and display on the screen.
	outputSalesInfo(outFile, salesInfoObj);



	//1002 Larry Jones - use set methods to change values.
	salesInfoObj.setSalesPersonId(1002);
	salesInfoObj.setFirstName("Larry");
	salesInfoObj.setLastName("Jones");
	salesInfoObj.setRate(10.00);
	salesInfoObj.setQty(50);

	//Save the sales data as a record to the file and display on the screen..
	outputSalesInfo(outFile, salesInfoObj);


	//1003 Paul Sailor - use overloaded constructors 
	SalesInfo salesInfoObj2(1003, "Paul", "Sailor", 15.00, 150);

	//Save the sales data as a record to the file and display on the screen..
	outputSalesInfo(outFile, salesInfoObj2);

	displayContinuePrompt();
	// Close the output file and exit program
	outFile.close();
	return 0;
}//end of main

//save the order information to a file or display on screen
void outputSalesInfo(ostream& target, SalesInfo& salesInfoObj)
{
	//declare local variables
	int salesPersonId;
	string lastName, firstName;
	double rate;
	int qty;

	//set the precision for rate
	target.setf(ios::fixed);
	target.setf(ios::showpoint);
	target.precision(2);
	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	//Have the class return the private values to the local variables.
	//Then store them in the file.
	salesPersonId = salesInfoObj.getSalesPersonId();
	firstName = salesInfoObj.getFirstName();
	lastName = salesInfoObj.getLastName();
	rate = salesInfoObj.getRate();
	qty = salesInfoObj.getQty();


	cout << "\n\nSalesPerson's Information Saved! \n";
	cout.setf(ios::left);
	cout << setw(6) << salesPersonId
		<< setw(18) << firstName
		<< setw(18) << lastName;
	cout.unsetf(ios::left);

	cout << setw(6) << rate;
	cout << setw(4) << qty;
	cout << endl;

	target.setf(ios::left);
	target << setw(6) << salesPersonId
		<< setw(18) << firstName
		<< setw(18) << lastName;
	target.unsetf(ios::left);

	target << setw(6) << rate;
	target << setw(4) << qty;
	target << endl;

	return;
}	//end of application code


//================================================== SalesPerson Function Definitions ==================================================\\                               

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

void SalesPerson::setSalesPersonId(int id) {
	salesPersonId = id;
}

void SalesPerson::setFirstName(string fn) {
	firstName = fn;
}

void SalesPerson::setLastName(string ln) {
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
	cout << "Enter Salesperson ID: ";
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

//================================================== SalesInfo Function Definitions ==================================================\\

//default constructor- the input functions should be called from here
SalesInfo::SalesInfo()
	: SalesPerson()        //call constructor in base class 
{
	inputRate();
	inputQty();
}

//overloaded constructor - arguments assigned to members
//use base initialize list to call constructor in base class
SalesInfo::SalesInfo(int id, string fn, string ln, double rt, int qt)
	: SalesPerson(id, fn, ln)
{
	rate = rt;
	qty = qt;
}

//destructor
SalesInfo::~SalesInfo()
{
	cout << endl << "SalesInfo   Object going out of scope. Id = "
		<< salesPersonId;
}

// set accessors are used to assign a value to a private variable and have no return type. The value that will be assigned is passed
// through the parameter
void SalesInfo::setRate(double rt) {

	rate = rt;
}

void SalesInfo::setQty(int qt) {

	qty = qt;
}

// accessors to return values in private variables

double SalesInfo::getRate() {

	return rate;
}

int SalesInfo::getQty() {

	return qty;
}

// input accessors

void SalesInfo::inputRate()
{//Normally set and input functions would include validation and would throw an exception if an error was found.
	do
	{
		cout << "Enter a bonus rate between $5.00 and $10: ";
		cin >> rate;

		if (rate < 5.0 || rate > 10.00)
			cout << "Error: The rate must be between $5.00 and $10.00. "
			<< "Try again...\n\n";

	} while (rate < 5.0 || rate > 10.00);
	return;
}


void SalesInfo::inputQty()
{
	do
	{
		cout << "Enter a quantity between 0 and 200:       ";

		cin >> qty;

		if (qty < 0 || qty > 200)
			cout << "Error: The quantity must be between 0 and 200. "
			<< "  Try again...\n\n";

	} while (qty < 0 || qty > 200);
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