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

#include "stdafx.h"
#include <fstream>  // file processing
#include <iostream> // cin and cout
#include <iomanip>  // setw
#include <string>   // string class
#include "sales_person.h" // SalesPerson
#include "sales_info.h" // SalesInfo also includes SalesPerson,

using namespace std;

//This function saves sales info to a file or displays to screen (cout)
void outputSalesInfo(ostream& target, SalesInfo& salesInfoObj);

int main(){
	cout << "P13 - Dave Minkowski\n\n";

	//Open the file for output

	ofstream outFile;
	outFile.open("p13.txt");
	if (outFile.fail())
	{
		cout << "Error opening output file for sales information.\n"
			<< "Exiting program \n\n";
		return 0;
	}

	cout << "\nP13 Dave Minkowski \n\n";


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
}

//end of application code

