/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P10
Date:			04/08/2018
Description:	This excercise helps to define a class using a UML class
				diagram. In this exercise, only the class definition is
				written. 
*********************************************************************/

#include "stdafx.h"
#include <fstream>  // file processing
#include <iostream> // cin and cout
#include <cctype>   // toupper
#include <iomanip>  // setw
#include <cstring>  // cstring functions strlen, strcmp, strcpy stored in string.h
#include <string>   // string class

using namespace std;


//Class definition -  the interface for the class

class SalesPerson	// Start Class Definition
{
private:
//private member variables require accessors
	int salesPersonId;
	string firstName;
	string lastName;


public:
// default constructor has no values
	SalesPerson();

// overloaded constructor with parameter names that are different from the class variable names
	SalesPerson(int id, string fn, string ln);

// destructor
	~SalesPerson();

// accessors
// set accessors are used to assign a value to a private variable and have no return type. The value that will be assigned is passed
// through the parameter (int id will change int salesPersonId) -  these are passed to the constructor

	void setSalesPersonId(int id);
	void setFirstName(string fn);
	void setLastName(string ln);

// get accessors are used to return the value stored in a private variable, so a parameter is NOT passed but we do declare the return type of the variable value we are
// trying to "get"

	int getSalesPersonId(); // return int salesPersonId
	string getFirstName();	// return string firstName
	string getLanstName();	// return string lastName

// input accessors prompt for get, and store a valeu in a private variable. There is no return value and no parameter is passed.
	void inputSalesPersonId();
	void inputFirstName();
	void inputLastName();

};		// End class definition


//Need empty main so program will compile 
int main()
{
	cout << "P10 - Dave Minkowski\n\n";
	return 0;
}

