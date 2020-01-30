
/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P05
Date:			02/21/2018
Description:	This program uses a function to to calculate gross pay
				and taxes after obtaining a user's pay rate and hours.
*********************************************************************/

#include "stdafx.h"
#include <stdlib.h>
#include <iostream>
using namespace std;

// global constants - to be used by all functions of the program
const double OVERTIME_RATE = 1.5;
const double UNION_DUES = 10.00;
const double FEDERAL_RATE = 0.15;
const double FICA_RATE = 0.06;
const double STATE_RATE = 0.05;

// function and the values required to pass to them
double inputPayRate();
double inputHoursWorked();
double calcGross(double payRate, double hoursWorked);
double calcTax(double grossPay, double taxRate);
double calcNetPay(double grossPay, double federalTax, double ficaTax, double stateTax);

int main()
{	
	// declaring local variables
	double hoursWorked, payRate, grossPay;

	// decimal precision set to 2 places
	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	cout << "P05 - Dave Minkowski \n\n";

	// get input values - the functions below will prompt for input then assign that input to the 2 variables payRate and hoursWorked:

	// call the function to obtain payRate from $10-$15, storing it as payRate
	payRate = inputPayRate(); 

	// function call to obtain hours worked for the week (1-50), storing it as hoursWorked
	hoursWorked = inputHoursWorked(); 


	// function call to the pay calculator which will calculate regular hours and overtime (> 40 hours per week), storing this as grossPay
	// Must call this function after obtaining values for payRate and hoursWorked
	grossPay = calcGross(payRate, hoursWorked);

	// declaring and initializing taxd value variables
	//	calculating taxes based on tax rates and gross pay, using the same function for each of the three taxes
	// The values changed based on the rate values passed to the calcTax function ie: FEDERAL_RATE, STATE_RATE and FICA_RATE)
	double federalTax = calcTax(grossPay, FEDERAL_RATE);
	double ficaTax = calcTax(grossPay, FICA_RATE);
	double stateTax = calcTax(grossPay, STATE_RATE);


	// a calculation to store net pay for display below (the paycheck variable). I know this could have been much simpler math and performed on its own
	// here in main, but i wanted to create the function for practice. 
	// in case you didnt want this, what I would have done is:

	// double netPay = grossPay - (federalTax + ficaTax + stateTax + UNION_DUES)     ///////////////////////////////////////////////////////////////////

	// then in the output below, I would have replaced the paycheck variable with netPay

	double paycheck = calcNetPay(grossPay, federalTax, ficaTax, stateTax);
	double netHourly = paycheck / hoursWorked; // average hourly pay rate for TAKE HOME pay

	// I didn't know this as i was doing this part, but we don't have to pass global constant values to a function, which now that I thihnk about it, makes sense that 
	// a function wouldn't need to have a value of a constant passed to it, since its... constant.

	//Display the results
	cout << endl
		<< "Pay Rate:    \t$" << payRate << endl
		<< "Hours Worked: \t" << hoursWorked << endl
		<< "Gross Pay: \t$" << grossPay << endl << endl
		<< "Federal Tax:\t$" << federalTax << " at " << FEDERAL_RATE << " %" << endl
		<< "FICA Tax: \t$" << ficaTax << " at " << FICA_RATE << " %" << endl
		<< "State Tax: \t$" << stateTax << " at " << STATE_RATE << " %" << endl
		<< "Union Dues:\t$" << UNION_DUES << endl << endl

		<< "Net Pay:\t$" << paycheck /* netPay*/ << endl
		<< "Net Hourly:\t$" << netHourly << endl << endl;

//		<< "\nThank you!\n\n";


	return 0;
} // end of main



/////////////////////////////Funciton Definitions/////////////////////////////////////////

	// obtaining pay rate
	double inputPayRate()
	{
		double payRate = 0; // initializing a variable to hold the return value
		do
		{
			cout << "Enter your pay rate. This must be a value between $10.00 and $15.00 dollars. "; 
			cin >> payRate;

		} while (payRate > 15.00 || payRate < 10.00); // end looping if hours fall within range (opposite of next loop)

		cout << endl;
		return (payRate); // return the user input
	}

	// obtaining hours worked

	double inputHoursWorked()
	{
		double hoursWorked = 0.0; // initializing a variable to hold the return value
		while (hoursWorked < 1.0 || hoursWorked > 50.0)  // loop if hours outside of range
		{
			cout << "Enter a value between 1 and 50 hours worked. ";
			cin >> hoursWorked;
		}
		return (hoursWorked); // return the user input
	}

	// calculating gross pay

	double calcGross(double payRate, double hoursWorked)
	{
		double calcPay; // declaring a variable to hold the return value 112.5

		// I see what you meant here... woops. should be (hoursWorked - 40 * overtime rate) PLUS (40 * regular rate)
		if (hoursWorked > 40)
			calcPay = (((hoursWorked - 40) * (payRate * OVERTIME_RATE)) + (payRate * 40)); // rate of 1.5 x hours for the hours worked > 40, else: hours * payrate
		else
			calcPay = payRate * hoursWorked;
		return (calcPay);
	}

	// calculating taxes

	double calcTax(double grossPay, double taxRate)
	{
		double totalTaxed; // declaring a variable to hold the return value

		totalTaxed = grossPay * taxRate; 
		
		// the variable totalTaxed will be different for each function that passes a different taxRate variable. 
		// there is no variabel named taxRate outside of this function, and its value will be determined by the constant used in its place.
		
		return (totalTaxed);
	}

	double calcNetPay(double grossPay, double federalTax, double ficaTax, double stateTax)  // an additional function to calculate net pay for practice.
	{
		double net;

		net = grossPay - (federalTax + ficaTax + stateTax + UNION_DUES); // did not need to pass UNION_DUES to this function
		return (net);
	}








	




























