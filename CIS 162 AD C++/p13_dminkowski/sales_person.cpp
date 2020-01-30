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

//Implementation file - sales_person.cpp - function definitions

#include "stdafx.h"
#include <iostream>        // cout and cin
#include "sales_person.h"  // SalesPerson

using namespace std;

//Functions for class SalesPerson include:

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

// End of implementation file  sales_person.cpp