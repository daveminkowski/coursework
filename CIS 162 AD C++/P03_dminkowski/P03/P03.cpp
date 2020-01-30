/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P03
Date:			02/10/2018
Description:	This program uses loops and branching to determine a 
				user's weekly net pay based on their hourly rate and 
				the number of hours they worked. 
*********************************************************************/

#include "stdafx.h"
#include <iostream>
using namespace std;


int main()
{
	// declaring constants for each of these unchanging rates and amounts. They will remain the same for all calculations which use them
	// and are identified by their capitalized variable names. These could also have been assigned in a single statement separated by 
	// commas but I prefer to list each variable separately. Example: const double CONSTANT1 = 5.5, CONSTANT2 = 1.4; ...and so on.

	const double UNION_DUES = 10.00;
	const double FICA_RATE = 0.06;
	const double FEDERAL_RATE = 0.15;
	const double STATE_RATE = 0.05;
	const double OVERTIME_RATE = 1.5;

	// declaring the variables to hold the values entered by the user for the net pay calculation. For the comment descriptions, these variables will be initialized
	// later in the program.

	double payRate;				// the hourly pay rate for the user
	double hoursWorked;			// total hours worked by the user
	double overtimeHours = 0;	// to store the number of overtime hours worked, if applicable.
	double grossPay;			// If hoursWorked <= 40, this is the calculation of payRate * hoursWorked. If hoursWorked > 40, grossPay = (payrate * 40) + (overtimeHours * OVERTIME_RATE)
	double netPay;				// If union member, this is the calculation of grossPay - taxWithheld - UNION_DUES. Otherwise just grossPay - taxWithheld.
	double ficaTax;				// the calculation of grossPay * FICA_RATE
	double federalTax;			// the calculation of grossPay * FEDERAL_RATE
	double stateTax;			// the calculation of grossPay * STATE_RATE
	double totalTaxWithheld;	// optional: for adding the total taxes withheld as a single output value.
	double netHourlyPay;		// stores a user's take-home per-hour

	// formatting to 2 decimal places (since dealing with currency)

	cout.setf(ios::fixed);
	cout.setf(ios::showpoint);
	cout.precision(2);

	// DO-WHILE LOOP
	// This is a do-while loop to get a payRate value from the user. The loop will check for validation at the end of the loop, executing at least once.
	// The do section of the loop will save the input as a a variable value. The while portion of the loop ischecking for valid input. 
	// If the input value falls outside the range of 10.00-15.00, this will restart the loop (fulfilling the requirement to restart the loop) and 
	// again prompts the user for a valid input.

	cout << "P03 - Dave Minkowski\n\n"; 

	do
	{
		cout << "Enter your pay rate. This must be a value between $10.00 and $15.00\n";	// prompting for input
		cin >> payRate; // saving input value to the payRate variable if between 10-15

	} while (payRate < 10.00 || payRate > 15.00); // checking the value, continue looping if value < 10 or > 15
	cout << endl; // end loop if value doesn't fulfill loop requirement (value between 10-15 entered)

	// WHILE LOOP
	// This is a while loop to get a hoursWorked value from the user. The loop validates at the beginning, so the variable must be initialized though it's already been declared.
	// The do section of the loop will save the input as a a variable value. The while portion of the loop ischecking for valid input. 

	hoursWorked = 0; // initializing to a value of 0 to fulfill the loop requirement. This could be set to any number < 1 or > 50 in the case of this 'or' requirement. -98, 130, etc
	while (hoursWorked < 1 || hoursWorked > 50) // validating input. Loop again if values are outside the range of this statement.
	{
		cout << "Enter the total hours you worked this week. This must be a positive value no greater than 50.\n"; // prompt user for valid input
		cin >> hoursWorked; // save input value to the hoursWorked variable if between 1-50
	}

	// IF-ELSE STATEMENT
	// This statement changes the value of grossPay based on the hours worked to allow for overtime hours to be calculated and added to the grossPay.
	// a. If hours > 40, subtract 40 from total hours worked, save as variable overtimeHours. multiply that result by the overtime rate.
	// b. add the product of the overtime hours and the overtime rate to the product of the payrate and 40 straight-time hours.
	//	OTHERWISE: grossPay is the product of the hoursWorked and the payRate (if hoursWorked < 40)

	if (hoursWorked > 40)
	{
		overtimeHours = hoursWorked - 40;
		grossPay = (overtimeHours * OVERTIME_RATE) + (payRate * 40);
	}
	else
		grossPay = (payRate * hoursWorked);

	

	// initializing values for each of the individual taxes withheld from grossPay by multiplying each tax rate constant by the gross pay calculated above.

	ficaTax = grossPay * FICA_RATE;
	federalTax = grossPay * FEDERAL_RATE;
	stateTax = grossPay * STATE_RATE;
	totalTaxWithheld = ficaTax + federalTax + stateTax;

	// netpay is the sum of grossPay - all taxes - 10 dollar union dues.
	netPay = grossPay - totalTaxWithheld - UNION_DUES;
	// netHourlyPay is simply netpay/hoursWorked to show a user how much take-hom per-hour they earn.
	netHourlyPay = netPay / hoursWorked;

	//Display the values stored in input variables, constants rates and tax variables on their own lines.

	cout << endl
		<< "Pay Rate:\t\t $" << payRate << endl
		<< "Regular Hours Worked:\t " << hoursWorked << endl
		<< "Overtime Hours Worked:\t " << overtimeHours << endl
		<< "Gross Pay:\t\t $" << grossPay << endl << endl // each of these double endlines is just to break up the list, visually

		<< "Federal Tax Withheld:\t $" << federalTax << " at " << FEDERAL_RATE << endl
		<< "State Tax Withheld:\t $" << stateTax << " at " << STATE_RATE << endl
		<< "FICA Tax Withheld:\t $" << ficaTax << " at " << FICA_RATE << endl
		<< "Total tax withheld:\t $" << totalTaxWithheld << endl <<endl // each of these double endlines is just to break up the list, visually

		<< "Union Dues\t\t $" << UNION_DUES << endl << endl // each of these double endlines is just to break up the list, visually

		<< "Net Pay:\t\t $" << netPay << endl
		<< "Net Hourly:\t\t $" << netHourlyPay << endl << endl
		<< "Thank you! - Dave Minkowski - P03\n\n";

	return 0;
}

