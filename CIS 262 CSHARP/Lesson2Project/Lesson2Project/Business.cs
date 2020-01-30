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
    // business class inherits account class
    public class Business : Account , IPayMyBill
    {
        // variables unique to business accounts
        public string businessName { get; set; }
        public string businessAddress { get; set; }

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

        // Method overrides the account.BillCustomer method and defines what the method does. In the business class, the due date is 60 days from the invoice date.
        public override void BillCustomer()
        {
            invoiceBillingDate = DateTime.Now;
            invoicePaymentDue = (DateTime.Now.AddDays(60));
        }

        // the pay method is inherited from the IPayMyBill interface and sets the amount due to $0.00. This MUST be defined in the class since the interface is implemented.
        public void Pay()
        {
            this.invoiceAmountDue = 0;
        }
    }
}
