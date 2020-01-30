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
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }
    }

    public class AllCustomersModel
    {
        public List<CustomerModel> Customers { get; set; }
    }
}