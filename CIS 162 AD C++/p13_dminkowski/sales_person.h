/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P13
Date:			04/29/2018
Description:	This program is a driver to test SalesInfo, which
inherits SalesPerson. It is used to create 2 objects,
which test the constructors and accessors. The objects
created are saved to p13.txt
*********************************************************************/

#pragma once
//P13 SalesPerson     
//Interface file - sales_person.h  - class definition

#ifndef SALES_PERSON_H
#define SALES_PERSON_H

#include <string>  // string class
using namespace std;

class SalesPerson{

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
};


#endif   // End of SALES_PERSON_H