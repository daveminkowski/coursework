/********************************************************************
Name:			David Minkowski
Course:			CIS 162AB - Spring 2018 - Section: 20704
Assignment:		P04
Date:			02/10/2018
Description:	Incorporate nested loops, data validation, arithmetic
				expressions and input/output to find calculate monthly
				pay for employees based on hours worked and overtime
				adjustment rates.
*********************************************************************/

#include "stdafx.h"
#include <stdlib.h>
#include <iostream>
using namespace std;

int main ()
{

// declare constants for adjustments to overtime pay rates
const double OVERTIME_RATE = 1.5, DOUBLETIME_RATE = 2.0;

// Declaring variables to store the # of employees to process and the count of each loop iteration :

int  employeeCount, loopCount;

// Declaring variables to store the # of hours worked each week and a variable for total hours worked:
int hoursWeek1, hoursWeek2, hoursWeek3, hoursWeek4, totalHoursWorked;

// Declaring variables to store pay rate and average employee salary
double payRate, avgSalary;

// Declaring the variables to store each week's calculated pay based on hours worked and overtime rates. These values will be displayed in an arrangment in the output.
double week1RegularTime, week1Overtime, week1Doubletime, week1GrossPay;
double week2RegularTime, week2Overtime, week2Doubletime, week2GrossPay;
double week3RegularTime, week3Overtime, week3Doubletime, week3GrossPay;
double week4RegularTime, week4Overtime, week4Doubletime, week4GrossPay;

// a boolean value for validating hourly inputs. This will initialize to false and will cause an error message and prompt if the hours worked are 
// < 0 or greater than 60

bool hourlyInputError;

// variables to store the sum of each pay category:
double monthlyRegularPaid, monthlyOvertimePaid, monthlyDoubletimePaid, monthlyTotalGross;

// Accumulators must be initialized to zero; these are running totals to save between each employee entered.

double reportRegularPayTotals = 0, reportOvertimePayTotals = 0, reportDoubletimePayTotals = 0, reportTotalGrossPay = 0;

// an accumulator for the total horus worked for each employee

int reportTotalMonthlyHoursWorked = 0;

// holding a variable which will store the character the user must press to continue with stage 2 of the program. cin.get specifically waits for the user to press enter to store the 
// last character into the char variable (I think)
char prompt;
// ====================================================================================================================================================


//Set decimal formatting to 2 places
cout.setf(ios::fixed);
cout.setf(ios::showpoint);
cout.precision(2);

cout << "P04 - Dave Minkowski\n\n";

// get employee count

// do-while is processed until a valid employeeCount is entered (0 or greater)
do
{
	cout
		<< "Enter the number of employees to process. \n"
		<< "Enter 0 (zero) to exit: ";

	cin >> employeeCount;

	if (employeeCount < 0)
		cout << "Error: The number of employees must be 0 or greater."
		<< " Enter 0 (zero) to exit: ";
} while (employeeCount < 0);

// Set the loopCounter to one so the next while-loop can continue calculating or return false (0)

loopCount = 1;

// Processing employees - while loop is controlled by the number of employees to process
// if zero was entered, then the loop is skipped.

while (loopCount <= employeeCount) // continue to loop until a number of loops equal to the number of employees entered have successfully occurred.
{
	// Display which employee we are currently processing
	cout << "\nP04 - Dave Minkowski                  \t\tEmployee: " << loopCount 
		<< endl << endl;

	// Get a valid pay rate
	do
	{
		cout << "Enter a pay rate between $5.25 and $30.00: \n";
		cin >> payRate;

		if (payRate < 5.25 || payRate > 30.00)
			cout << "Error: The rate must be between $5.25 and $30.00. "
			<< "Try Again...\n\n";

	} while (payRate < 5.25 || payRate > 30.00); // continue looping if values out of range (not between 5.25 and 30)

	/*
	Getting input for the number of hours worked for each of fours week. These values can be 0 but cannot exceed 60, nor can
	these values be negative. If a value is negative or > 60, an error message will be shown and the user will be prompted
	for input again.
	*/
	do
	{
		hourlyInputError = false;  // assume correct values will be entered
		cout << "\nP04 - Dave Minkowski\n";
		cout << "\nEnter the number of hours logged for every month (four work weeks). Separate each value with a space. \n";
		cin >> hoursWeek1 >> hoursWeek2 >> hoursWeek3 >> hoursWeek4; // take each space-delimited value and save as a variable

		if ((hoursWeek1 < 0) || (hoursWeek2 < 0) || (hoursWeek3 < 0) || (hoursWeek4 < 0))
		{
			cout << "Error: Negative values are not valid. Try Again...\n\n"; // validating for  negative numbers
			hourlyInputError = true;
		}
		if ((hoursWeek1 > 60) || (hoursWeek2 > 60) || (hoursWeek3 > 60) || (hoursWeek4 > 60))
		{
			cout << "Error: Values may not exceed 60. Try Again...\n\n"; // validating for hours > 60
			hourlyInputError = true;
		}
	} while (hourlyInputError);


	//Process the overtime rate (if aplicable) for each weekly hourly amount

	// calculating week 1: 

	if (hoursWeek1 < 41) // for all weeks worked with hours < 41 (0-40)
	{
		week1RegularTime = hoursWeek1 * payRate; // number of hours <= 40 x regular pay
		week1Overtime = 0;
		week1Doubletime = 0;
	}
	else // for all weeks worked with hours > 40 but < 51
	{
		if (hoursWeek1 < 51)
		{
			week1RegularTime = 40 * payRate; // number of hours <= 40 x regular pay
			week1Overtime = (payRate * (hoursWeek1 - 40)) * OVERTIME_RATE; // number of hours between 41 and 50 x regular pay x 1.5
			week1Doubletime = 0;
		}
		else // for all weeks with # of hours worked >= 51 (51-60)
		{
			week1RegularTime = 40 * payRate; // number of hours <= 40 x regular pay
			week1Overtime = (payRate * 10) * OVERTIME_RATE; // the hours between 41 and 50 (10 total hours) are paid at their pay rate and multiplied by 1.5
			week1Doubletime = (hoursWeek1 - 50) * (payRate * DOUBLETIME_RATE);	// the remaining hours (> 51) are paid at their pay rate x 2 (this should always be no more than 
																				// 10 hours due to the input validation implemented earlier
		}
	}

	// calculating week 2
	if (hoursWeek2 < 41)
	{
		week2RegularTime = hoursWeek2 * payRate;
		week2Overtime = 0;
		week2Doubletime = 0;
	}
	else
	{
		if (hoursWeek2 < 51)
		{
			week2RegularTime = 40 * payRate;
			week2Overtime = (payRate * (hoursWeek2 - 40)) * OVERTIME_RATE;
			week2Doubletime = 0;
		}
		else
		{
			week2RegularTime = 40 * payRate;
			week2Overtime = (payRate * 10) * OVERTIME_RATE;
			week2Doubletime = (hoursWeek2 - 50) * (payRate * DOUBLETIME_RATE);
		}
	}

	// calculating week 3
	if (hoursWeek3 < 41)
	{
		week3RegularTime = hoursWeek3 * payRate;
		week3Overtime = 0;
		week3Doubletime = 0;
	}
	else
	{
		if (hoursWeek3 < 51)
		{
			week3RegularTime = 40 * payRate;
			week3Overtime = (payRate * (hoursWeek3 - 40)) * OVERTIME_RATE;
			week3Doubletime = 0;
		}
		else
		{
			week3RegularTime = 40 * payRate;
			week3Overtime = (payRate * 10) * OVERTIME_RATE;
			week3Doubletime = (hoursWeek3 - 50) * (payRate * DOUBLETIME_RATE);
		}
	}

	// calculating week 4
	if (hoursWeek4 < 41)
	{
		week4RegularTime = hoursWeek4 * payRate;
		week4Overtime = 0;
		week4Doubletime = 0;
	}
	else
	{
		if (hoursWeek4 < 51)
		{
			week4RegularTime = 40 * payRate;
			week4Overtime = (payRate * (hoursWeek4 - 40)) * OVERTIME_RATE;
			week4Doubletime = 0;
		}
		else
		{
			week4RegularTime = 40 * payRate;
			week4Overtime = (payRate * 10) * OVERTIME_RATE;
			week4Doubletime = (hoursWeek4 - 50) * (payRate * DOUBLETIME_RATE);
		}
	}

			//Sum the monthly totals (going across the columns)
			week1GrossPay = week1RegularTime + week1Overtime + week1Doubletime;
			week2GrossPay = week2RegularTime + week2Overtime + week2Doubletime;
			week3GrossPay = week3RegularTime + week3Overtime + week3Doubletime;
			week4GrossPay = week4RegularTime + week4Overtime + week4Doubletime;

			//Sum the totals of each pay category (going down the columns)
			monthlyRegularPaid = week1RegularTime + week2RegularTime + week3RegularTime + week4RegularTime;
			monthlyOvertimePaid = week1Overtime + week2Overtime + week3Overtime + week4Overtime;
			monthlyDoubletimePaid = week1Doubletime + week2Doubletime + week3Doubletime + week4Doubletime;
			monthlyTotalGross = week1GrossPay + week2GrossPay + week3GrossPay + week4GrossPay;

			totalHoursWorked = hoursWeek1 + hoursWeek2 + hoursWeek3 + hoursWeek4;

			//Accumulate the report totals

			//Shorthand notation  += and -=
			//+= means to add the value in the variable on the left to the one on the right
			//and to store the result back in the variable on the left.

			reportRegularPayTotals += monthlyRegularPaid;
			reportOvertimePayTotals += monthlyOvertimePaid;
			reportDoubletimePayTotals += monthlyDoubletimePaid;
			reportTotalGrossPay += monthlyTotalGross;

			reportTotalMonthlyHoursWorked += totalHoursWorked;

			//Display Headings
			cout << "\nP04 - Dave Minkowski\n";
			cout << endl
				<< "Week \tRate \tHours \tRegular \tOvertime \tDoubletime \tGross \n\n"

				//Display Employee Details
				<< "Week 1\t" << payRate << "\t" << hoursWeek1 << "\t" << week1RegularTime << "\t\t"
				<< week1Overtime << "\t\t" << week1Doubletime << "\t\t" << week1GrossPay << endl

				<< "Week 2\t" << payRate << "\t" << hoursWeek2 << "\t" << week2RegularTime << "\t\t"
				<< week2Overtime << "\t\t" << week2Doubletime << "\t\t"<< week2GrossPay << endl 

				<< "Week 3\t" << payRate << "\t" << hoursWeek3 << "\t" << week3RegularTime << "\t\t"
				<< week3Overtime << "\t\t" << week3Doubletime << "\t\t" << week3GrossPay << endl 

				<< "Week 4\t" << payRate << "\t" << hoursWeek4 << "\t" << week4RegularTime << "\t\t"
				<< week4Overtime << "\t\t" << week4Doubletime << "\t\t" << week4GrossPay << endl
				<< endl

				//Display employee Totals
				<< "Total Hours:\t" << totalHoursWorked
				<< "\t" << monthlyRegularPaid
				<< "\t\t" << monthlyOvertimePaid
				<< "\t\t" << monthlyDoubletimePaid
				<< "\t\t" << monthlyTotalGross
				<< endl << endl

				<< "Press Enter to process the next salesperson or Report Totals: ";

			cin.ignore();
			prompt = cin.get();

			system("cls");        //clear screen for next employee

								  //Increment the count controlling the loop
			loopCount++;        //Shorthand: ++ increments the variable by one.
		} //end of while (loopCount < salespersonCount)

		  //Before dividing by employeeCount, make sure it is not equal to zero.
		if (employeeCount > 0)
			avgSalary = reportTotalGrossPay / employeeCount;
		else
			avgSalary = 0;

		//Display Report Totals
		cout << "\nP04 - Dave Minkowski\n";
		cout << endl
			<< "Number of employees processed: \t" << employeeCount << endl <<endl
			<< "Total Monthly Employee Hours:\t" << reportTotalMonthlyHoursWorked << endl
			<< "Total regular salary: \t\t" << reportRegularPayTotals << endl
			<< "Total overtime salary: \t\t" << reportOvertimePayTotals << endl
			<< "Total double time salary: \t" << reportDoubletimePayTotals << endl << endl
			<< "Total gross payout: \t\t" << reportTotalGrossPay << endl
			<< "Average employee Salary: \t" << avgSalary << endl << endl
			<< endl << endl;

		return 0;
	}