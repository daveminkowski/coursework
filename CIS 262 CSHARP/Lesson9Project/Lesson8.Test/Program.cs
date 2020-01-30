/***********************************************************************************************
Name:			David Minkowski
Course:			CIS 262AD - Summer 2018 - Class: 11766
Assignment:		Lesson 9 Project
Date:			07/16/2018
Description:	This program uses SQL to read and display database values, now with a user prompt
                which allows insertion of records, deletion of records and the ability to edit 
                existing database records.
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson8.Dal;
using System.Data;
using System.Data.SqlClient;

namespace Lesson8.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("Would you like to edit (C)ustomer records, (I)nvoice records, or (Q)uit?");
                string menuMain = Console.ReadLine();
                switch (menuMain.ToLower())
                {
                    case "c":
                        {
                            Console.WriteLine("Would you like to (A)dd a record, (E)dit a record, (D)elete a record, (V)iew the list of customer records or (Q)uit?");
                            string menuCustomer = Console.ReadLine();
                            switch (menuCustomer.ToLower())
                            {
                                case "a":
                                    {
                                        AddCustomer();
                                        break;
                                    }
                                case "e":
                                    {
                                        EditCustomer();
                                        break;

                                    }
                                case "d":
                                    {
                                        DeleteCustomer();
                                        break;
                                    }
                                case "v":
                                    {
                                        ViewCustomerRecords();
                                        break;
                                    }
                                case "q":
                                    {
                                        keepLooping = false;
                                        break;
                                    }
                            }
                            break;
                        }
                        case "i":
                        {
                            Console.WriteLine("Would you like to (A)dd a record, (E)dit a record, (D)elete a record, (V)iew the list of invoices or (Q)uit?");
                            string menuInvoice = Console.ReadLine();
                            switch (menuInvoice.ToLower())
                            {
                                case "a":
                                    {
                                        AddInvoice();
                                        break;
                                    }
                                case "e":
                                    {
                                        EditInvoice();
                                        break;

                                    }
                                case "d":
                                    {
                                        DeleteInvoice();
                                        break;
                                    }
                                case "v":
                                    {
                                        ViewInvoiceRecords();
                                        break;
                                    }
                                case "q":
                                    {
                                        keepLooping = false;
                                        break;
                                    }
                            }
                            break;
                        }
                        case "q":
                        {
                            keepLooping = false;
                            break;
                        }
                }
            }
        }
        public static void AddCustomer()
        {
            Console.WriteLine("Gathering new customer information...");
            Console.WriteLine("Enter Customer's First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Customer's Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Customer's Country:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter Customer's Email Address:");
            string email = Console.ReadLine();

            Customer insertNewCustomer = new Customer
            {
                FirstName = fname,
                LastName = lname,
                Country = country,
                Email = email
            };

            CustomerAdapter adapter = new CustomerAdapter();
            adapter.InsertCustomer(insertNewCustomer);
            Console.WriteLine("");
            Console.WriteLine("Customer Added...");
            Console.WriteLine("");
        }

        public static void EditCustomer()
        {
            Console.WriteLine("Editing existing account information...");
            Console.WriteLine("Enter the Customer ID:");
            string idToChange = Console.ReadLine();
            Int32.TryParse(idToChange, out int changeThisID);
            Console.WriteLine("Enter Customer's First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Customer's Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Customer's Country:");
            string country = Console.ReadLine();
            Console.WriteLine("Enter Customer's Email Address:");
            string email = Console.ReadLine();

            Customer editExistingCustomer = new Customer
            {
                FirstName = fname,
                LastName = lname,
                Country = country,
                Email = email,
                CustomerId = changeThisID
            };

            CustomerAdapter adapter = new CustomerAdapter();
            adapter.UpdateCustomer(editExistingCustomer);
            Console.WriteLine("");
            Console.WriteLine("Records Updated...");
            Console.WriteLine("");
        }

        public static void DeleteCustomer()
        {
            Console.WriteLine("Enter customer ID to be deleted");
            string idToDelete = Console.ReadLine();
            Int32.TryParse(idToDelete, out int deleteThisID);

            CustomerAdapter adapter = new CustomerAdapter();
            adapter.DeleteCustomer(deleteThisID);
            Console.WriteLine("");
            Console.WriteLine("Successfully deleted customer ID No. " + deleteThisID);
            Console.WriteLine("");
        }

        public static void ViewCustomerRecords()
        {
            CustomerAdapter adapter = new CustomerAdapter();
            List<Customer> customers = adapter.GetAll();

            Console.WriteLine("Customer Records:");
            Console.WriteLine("");

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.CustomerId + " - Name: " + customer.FirstName + " " + customer.LastName + " - Country: " + customer.Country + " - Email: " + customer.Email);
            }
            Console.WriteLine("");
            Console.ReadLine();
        }

        public static void AddInvoice()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter Customer ID:");
            string idToChange = Console.ReadLine();
            Int32.TryParse(idToChange, out int changeThisID);
            Console.WriteLine("");
            Console.WriteLine("Enter invoice total:");
            string amountToChange = Console.ReadLine();
            decimal.TryParse(amountToChange, out decimal totalAmount);
            Console.WriteLine("");
            Console.WriteLine("Enter invoice date:");
            string date = Console.ReadLine();
            DateTime.TryParse(date, out DateTime invoiceDate);


            Invoice insertNewInvoice = new Invoice
            {
                CustomerId = changeThisID,
                Total = totalAmount,
                InvoiceDate = invoiceDate
            };

            InvoiceAdapter adapter = new InvoiceAdapter();
            adapter.InsertInvoice(insertNewInvoice);
            Console.WriteLine("");
            Console.WriteLine("Invoice Created...");
            Console.WriteLine("");
        }

        public static void EditInvoice()
        {
            Console.WriteLine("Updating invoice records...");
            Console.WriteLine("Enter Invoice ID:");
            string idToChange = Console.ReadLine();
            Int32.TryParse(idToChange, out int changeThisID);
            Console.WriteLine("");
            Console.WriteLine("Enter invoice total:");
            string amountToChange = Console.ReadLine();
            decimal.TryParse(amountToChange, out decimal totalAmount);
            Console.WriteLine("");
            Console.WriteLine("Enter invoice date:");
            string date = Console.ReadLine();
            DateTime.TryParse(date, out DateTime invoiceDate);


            Invoice editNewInvoice = new Invoice
            {
                InvoiceId = changeThisID,
                Total = totalAmount,
                InvoiceDate = invoiceDate
            };

            InvoiceAdapter adapter = new InvoiceAdapter();
            adapter.UpdateInvoice(editNewInvoice);
            Console.WriteLine("");
            Console.WriteLine("Records updated...");
            Console.WriteLine("");
        }

        public static void DeleteInvoice()
        {
            Console.WriteLine("Enter invoice ID to be deleted:");
            string idToDelete = Console.ReadLine();
            Int32.TryParse(idToDelete, out int deleteThisID);
            InvoiceAdapter adapter = new InvoiceAdapter();
            adapter.DeleteInvoice(deleteThisID);
            Console.WriteLine("");
            Console.WriteLine("Successfully deleted invoice ID No. " + deleteThisID);
            Console.WriteLine("");
        }

        public static void ViewInvoiceRecords()
        {
            InvoiceAdapter adapter = new InvoiceAdapter();
            List<Invoice> invoices = adapter.GetAll();

            Console.WriteLine("");
            Console.WriteLine("Invoice Records:");
            Console.WriteLine("");

            foreach (Invoice invoice in invoices)
            {
                Console.WriteLine("Invoice ID: " + invoice.InvoiceId + " - Customer ID: " + invoice.CustomerId + " - Total: " + invoice.Total + " - Invoice Date: " + invoice.InvoiceDate.ToShortDateString());
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
