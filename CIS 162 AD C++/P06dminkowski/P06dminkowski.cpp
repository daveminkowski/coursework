
/* *******************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P06
Date:			02/24/2018
Description:	This program uses a function to to calculate gross pay
and taxes after obtaining a user's pay rate and hours, passing values 
instead by reference rather than value.
******************************************************************** */

#include "stdafx.h"
#include <stdlib.h>
#include <iostream>
using namespace std;

// functions and the values required to pass to them

void inputPayRate(double& payRate);									// pay rate function prototype			
void inputHoursWorked(int& hoursWorked);							// hours worked function prototype
void calcGross(double payRate, int hoursWorked, double& grossPay);	// gross pay function prototype
void calcTax(double grossPay, double taxRate, double *taxAmount);	// tax calculating function prototype - why do I not need to declare the taxRate variable?

// global constants - to be used by all functions of the program
const double OVERTIME_RATE = 1.5;

int main()
{
	// declaring local constants

	const double UNION_DUES = 10.00;
	const double FEDERAL_RATE = 0.15;
	const double FICA_RATE = 0.06;
	const double STATE_RATE = 0.05;

	// declaring local variables
	int hoursWorked;
	double payRate, grossPay, federalTax, stateTax, ficaTax;

	// double taxRate;   ----- not necessary, but I don't understand why. All the above local variables are used in the function calls below, and the constant rates are passed
	// as taxRate in the calcTax function. What am I missing?
	
	
	// decimal precision set to 2 places
	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	cout << "P06 - Dave Minkowski \n\n";

	inputPayRate(payRate);							// call the function to prompt for pay rate
	inputHoursWorked(hoursWorked);					// call the function to prompt for hours worked
	calcGross(payRate, hoursWorked, grossPay);		// call the function to calculate gross pay
	calcTax(grossPay, FEDERAL_RATE, &federalTax);	// call the function to calculate federal, state and fica taxes, using the same function and passing different values
	calcTax(grossPay, STATE_RATE, &stateTax);		// ""			""
	calcTax(grossPay, FICA_RATE, &ficaTax);			// ""			""

	double netPay = (grossPay - (federalTax + stateTax + ficaTax + UNION_DUES));	// setting value to netPay variable for display
	double netHourly = (netPay / hoursWorked);										// setting value to netHourly variable for display

	// display output table/values:

	cout << endl
		<< "Pay Rate:    \t$" << payRate << endl
		<< "Hours Worked: \t" << hoursWorked << endl
		<< "Gross Pay: \t$" << grossPay << endl << endl
		<< "Federal Tax: \t$" << federalTax << " at " << FEDERAL_RATE << endl
		<< "State Tax: \t$" << stateTax << " at " << STATE_RATE << endl
		<< "FICA Tax: \t$" << ficaTax << " at " << FICA_RATE << endl

		<< "Union Dues:\t$" << UNION_DUES << endl << endl

		<< "Net Pay: \t$" << netPay << endl
		<< "Net Hourly: \t$" << netHourly << endl << endl;

	return 0;
} // end of main



/////////////////////////////Funciton Definitions/////////////////////////////////////////

// obtaining pay rate
void inputPayRate(double& payRate)
{
	payRate = 0; // initializing a variable to hold the return value
	do
	{
		cout << "Enter your pay rate. This must be a value between $10.00 and $15.00 dollars. ";
		cin >> payRate;

	} while (payRate > 15.00 || payRate < 10.00); // end looping if hours fall within range (opposite of next loop)

	cout << endl;
	return; // return the user input
}

// obtaining hours worked

void inputHoursWorked(int& hoursWorked)
{
	
	while (hoursWorked < 1.0 || hoursWorked > 50.0)  // loop if hours outside of range
	{
		cout << "Enter a value between 1 and 50 hours worked. ";
		cin >> hoursWorked;
	}
	return; // return the user input
}

// calculating gross pay

void calcGross(double payRate, int hoursWorked, double& grossPay)
{
	if (hoursWorked > 40)
		grossPay = (((hoursWorked - 40) * (payRate * OVERTIME_RATE)) + (payRate * 40)); // rate of 1.5 x hours for the hours worked > 40, else: hours * payrate
	else
		grossPay = payRate * hoursWorked;
	return;
}

// calculating taxes 
// calculations based on tax rates and gross pay, using the same function for each of the three taxes
// each function call will pass a different reference (taxRate) and save the result (*taxAmount) as 
// a different value (for each of federal, state or fica taxes, in the above function calls (lines 52-54) as &federalTax, &stateTax or &ficaTax)

void calcTax(double grossPay, double taxRate, double *taxAmount)
{
	*taxAmount = grossPay * taxRate;
	return;
}
