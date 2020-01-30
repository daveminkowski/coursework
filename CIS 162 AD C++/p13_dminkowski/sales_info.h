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
//P13  SalesInfo 
//Interface file - sales_info.h  - function prototypes

#ifndef SALES_INFO_H
#define SALES_INFO_H

#include "sales_person.h"   //SalesPerson definition required for inheritance

class SalesInfo : public SalesPerson{

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
};


#endif  // End of SALES_INFO_H