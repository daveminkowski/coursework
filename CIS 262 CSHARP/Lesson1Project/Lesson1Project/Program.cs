/***********************************************************************************************
Name:			David Minkowski
Course:			CIS 262AD - Summer 2018 - Class: 11766
Assignment:		Lesson 1 Project
Date:			05/22/2018
Description:	This program outputs basic info to the console while exhibiting fundamentals of
                user created classes and inheritance
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1Project
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
            personalAccount.invoiceBillingDate = (DateTime.Now);
            personalAccount.invoicePaymentDue = (DateTime.Now.AddDays(30));

            //set business account details
            Business businessAccount = new Business();
            businessAccount.businessName = "Imaginary Business Name";
            businessAccount.businessAddress = "123 E. North Street Mesa, AZ 85202";
            businessAccount.invoiceAmountDue = 9052.99M;
            businessAccount.invoiceBillingDate = (DateTime.Now);
            businessAccount.invoicePaymentDue = (DateTime.Now.AddDays(30));

            //output account details
            personalAccount.PersonalDetails();
            businessAccount.BusinessDetails();

            //wait for enter key to continue
            Console.ReadLine();
            
        }
    }
}
