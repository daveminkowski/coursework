/***********************************************************************************************
Name:			David Minkowski
Course:			CIS 262AD - Summer 2018 - Class: 11766
Assignment:		Lesson 10 Project
Date:			07/23/2018
Description:	In this assignment I've created a user interface which allows users to view, 
                edit, insert (add) and delete data from the customer and invoice tables of the 
                chinook database.
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Dal
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public decimal Total { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
