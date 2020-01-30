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
    // personal class inherits account class
    public class Personal : Account
    {
        // variables unique to personal accounts
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string customerAddress { get; set; }

        // default constructor
        public Personal()
        {

        }

        public void PersonalDetails()
        {
            Console.WriteLine("Customer Name: " + this.firstName + " " + this.lastName);
            Console.WriteLine("Amount Due: " + this.invoiceAmountDue.ToString("C"));
            Console.WriteLine("Invoice Due Date: " + this.invoicePaymentDue);
            Console.WriteLine(""); 
        }

    }
}
