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
using System.ComponentModel.DataAnnotations;

namespace Lesson8Project.Models
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }

        [Display(Name = "Customer ID")]
        [Required]
        public int CustomerId { get; set; }

        [Display(Name = "Invoice Total")]
        [Required]
        public decimal Total { get; set; }

        [Display(Name = "Invoice Date")]
        [Required]
        public DateTime InvoiceDate { get; set; }
    }

    public class AllInvoicesModel
    {
        public List<InvoiceModel> Invoices { get; set; }
    }
}