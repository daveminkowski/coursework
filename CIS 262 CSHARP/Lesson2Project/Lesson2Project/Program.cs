/***********************************************************************************************
Name:			David Minkowski
Course:			CIS 262AD - Summer 2018 - Class: 11766
Assignment:		Lesson 2 Project
Date:			05/29/2018
Description:	This program outputs basic info to the console while exhibiting fundamentals of
                user created classes, inheritance, interfaces and abstraction
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // set personal account details
            Personal personalAccount = new Personal();
            personalAccount.firstName = "David";
            personalAccount.lastName = "Minkowski";
            personalAccount.customerAddress = "1000 N. West Street Chandler, AZ 85225";
            personalAccount.invoiceAmountDue = 450.00M;
            personalAccount.BillCustomer();

            //set business account details
            Business businessAccount = new Business();
            businessAccount.businessName = "Imaginary Business Name";
            businessAccount.businessAddress = "123 E. North Street Mesa, AZ 85202";
            businessAccount.invoiceAmountDue = 9052.99M;
            businessAccount.BillCustomer();

            //output account details
            personalAccount.PersonalDetails();
            businessAccount.BusinessDetails();
            personalAccount.Pay();
            businessAccount.Pay();

            // a console out to show the difference in the amount due after the Pay() method.
            Console.WriteLine(businessAccount.invoiceAmountDue.ToString("C"));
            Console.WriteLine(personalAccount.invoiceAmountDue.ToString("C"));

            //wait for enter key to continue
            Console.ReadLine();
        }
    }
}
