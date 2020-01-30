/***********************************************************************************************
Name:			David Minkowski
Course:			CIS 262AD - Summer 2018 - Class: 11766
Assignment:		Lesson 4 Project
Date:			06/20/2018
Description:	This program reads and writes comma delimited entries to a text file, adding
                records when necessary.
************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lesson4Project
{
    public class Program
    {
        public static string dirPath = @"C:\Projects";
        public static string filePath = @"C:\Projects\Accounts.txt";

        static void Main(string[] args)
        {
            CheckFile();
            ShowMenu();
        } // end main

        public static void ShowMenu()
        {
            Console.WriteLine("This program will allow you to create a text file then read or add client records to it. Choose from the following options:");
            Console.WriteLine(" ");
            Console.WriteLine("1. View all saved client information.");
            Console.WriteLine("2. Enter a new client record");
            Console.WriteLine("3. Exit Program");
            Console.WriteLine("");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ReadFile();
                    ShowMenu();
                    break;

                case "2":
                    WriteFile();
                    ShowMenu();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Invalid choice, please select option 1, 2 or 3:");
                    Console.WriteLine("Press 'Enter' to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    ShowMenu();
                    return;
            }

        } // END ShowMenu()

        public static void CheckFile()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("{0} does not exist!", filePath);
                Console.WriteLine("");
                Console.WriteLine("Would you like to create it now? (Y)es or (N)o?");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Y":
                    case "y":
                        Console.WriteLine("Creating your file at " + filePath);
                        Console.WriteLine("");
                        Directory.CreateDirectory(dirPath);
                        File.Create(filePath).Close();
                        return;
                    case "N":
                    case "n":
                        Console.WriteLine("Ok then. Goodbye!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry, please choose Y for yes or N for No. Returning to main menu...");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                }

                Console.WriteLine("Press 'Enter' to continue...");
                Console.ReadLine();
                Console.Clear();
                return;
            }


            if (new FileInfo(filePath).Length == 0)
            {
                Console.WriteLine("No records found in file: " + filePath + ". Let's add one now...");
                WriteFile();
                return;
            }
            else
            {
                try
                {
                    List<Contact> clientList = new List<Contact>();
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    foreach (string line in lines)
                    {
                        string[] entries = line.Split(',');

                        Contact newContact = new Contact();
                        newContact.AccountName = entries[0];
                        newContact.InvoiceDate = Convert.ToDateTime(entries[1]);
                        newContact.DueDate = Convert.ToDateTime(entries[2]);
                        newContact.AmtDue = Convert.ToDecimal(entries[3]);
                        clientList.Add(newContact);

                    }
                    foreach (var client in clientList)
                    {
                        Console.WriteLine($"{client.AccountName} owes a total amount of: {client.AmtDue.ToString("C")}.");
                        Console.WriteLine($"Account first billed on: {client.InvoiceDate.ToShortDateString()}. Payment due on: {client.DueDate.ToShortDateString()}");
                        Console.WriteLine("");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);
                }
            }
        }

        public static void ReadFile()
        {
            Console.WriteLine("");
            Console.WriteLine("Viewing client records:");
            Console.WriteLine("");

            CheckFile();

            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WriteFile()
        {
            Console.WriteLine("");
            Console.WriteLine("Adding a new client...");
            Console.WriteLine("");
            try
            {
                Console.WriteLine("Enter the name of the primary Account Holder/Entity:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the Invoice Date in the format MM/DD/YYYY. The due date is automatically set to 30 days past the invoice date.");
                string invoice = Console.ReadLine();

                DateTime invoiceDate;
                DateTime dueDate = DateTime.Now;

                if (DateTime.TryParse(invoice, out invoiceDate))
                {
                    dueDate = invoiceDate.AddDays(30);
                }
                else
                {
                    invoiceDate = DateTime.Now;
                    dueDate = invoiceDate.AddDays(30);
                    Console.WriteLine("Error with date input formatting. Remember to use the format MM/dd/yyyy. Invoice date set to today. ");
                    Console.WriteLine("");
                }
                Console.WriteLine("Enter the total Amount Due:");
                string amtdue = Console.ReadLine();
                double amountDue = 0.00;
                if (Double.TryParse(amtdue, out amountDue))
                {
                    Console.WriteLine("");
                }
                else
                {
                    amountDue = 0.00;
                    Console.WriteLine("Invalid entry for Amount Due. Balance set to $0.00.");
                    Console.WriteLine("");
                }

                List<string> lines = File.ReadAllLines(filePath).ToList();

                lines.Add(name + "," + invoiceDate.ToShortDateString() + "," + dueDate.ToShortDateString() + "," + amountDue);

                File.WriteAllLines(filePath, lines);

                Console.WriteLine($"Record Saved with the following entries...");
                Console.WriteLine($"Account Name: {name}");
                Console.WriteLine($"Amount Due: {amountDue.ToString("C")}");
                Console.WriteLine($"Invoice Date: {invoiceDate.ToShortDateString()}");
                Console.WriteLine($"Due Date: {dueDate.ToShortDateString()}");
                Console.WriteLine("");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Entry. Error: " + ex.Message);
                Console.WriteLine("Closing Program...");
            }
            Console.WriteLine("Press 'Enter' to continue...");
            Console.ReadLine();
            Console.Clear();

        }// End WriteToFile

    } // end class
} // end nanmespace
