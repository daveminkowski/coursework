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
    public abstract class Account // account class is now abstract as we have an abstract method to set the invoice date and billing date
    {
        // these three properties (invoice amount, billing date and due date) are common to both account types and will be inherited by the child classes
        public decimal invoiceAmountDue { get; set; }
        public DateTime invoiceBillingDate;
        public DateTime invoicePaymentDue;

        //default constructor
        public Account()
        {

        }
        
        // BillCustomer is an abtract method defined in the personal and business classes
        public abstract void BillCustomer();

        //this function is never called, use for initial testing
        public void AccountDetails()
        {
            Console.WriteLine(this.invoiceAmountDue.ToString("C"));
            Console.WriteLine(this.invoiceBillingDate);
            Console.WriteLine(this.invoicePaymentDue);
        }

    }
}
