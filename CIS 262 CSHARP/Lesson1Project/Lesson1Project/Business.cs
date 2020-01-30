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
    // business class inherits account class
    public class Business : Account
    {
        // variables unique to business accounts
        public string businessName { get; set; }
        public string businessAddress { get; set;}

        // default constructor
        public Business()
        {

        }

        public void BusinessDetails()
        {
            Console.WriteLine("Company Name: " + this.businessName);
            Console.WriteLine("Amount Due: " + this.invoiceAmountDue.ToString("C"));
            Console.WriteLine("Invoice Due Date: " + this.invoicePaymentDue);
            Console.WriteLine("");
        }

    }

    
}
