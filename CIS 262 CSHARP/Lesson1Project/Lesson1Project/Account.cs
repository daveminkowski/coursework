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
    public abstract class Account
    {
        // these three properties (invoice amount, billing date and due date) are common to both account types and will be inherited by the child classes
        public decimal invoiceAmountDue { get; set; }
        public DateTime invoiceBillingDate { get; set; }
        public DateTime invoicePaymentDue { get; set; }

        //default constructor
        public Account()
        {

        }
        
        //this function is never called, use for initial testing
        public void AccountDetails()
        {           
            Console.WriteLine(this.invoiceAmountDue.ToString("C"));
            Console.WriteLine(this.invoiceBillingDate);
            Console.WriteLine(this.invoicePaymentDue);
        }

    }
}
