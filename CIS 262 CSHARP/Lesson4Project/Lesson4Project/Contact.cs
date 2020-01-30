/***********************************************************************************************
Name:			David Minkowski
Course:			CIS 262AD - Summer 2018 - Class: 11766
Assignment:		Lesson 4 Project
Date:			06/20/2018
Description:	This program reads and writes comma delimited entries to a text file, adding
                records when necessary.
************************************************************************************************/

using System;

namespace Lesson4Project
{
    public class Contact
    {
        public string AccountName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal AmtDue { get; set; }

    }
}
