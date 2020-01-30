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
using System.Web;
using System.Web.Mvc;
using Lesson8Project.Models;
using Lesson8.Dal;

namespace Lesson8Project.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            CustomerAdapter adapter = new CustomerAdapter();
            List<Customer> customers = adapter.GetAll();
            AllCustomersModel model = new AllCustomersModel();
            List<CustomerModel> customerModels = new List<CustomerModel>();
            foreach (Customer customer in customers)
            {
                CustomerModel customerModel = new CustomerModel();
                customerModel.CustomerId = customer.CustomerId;
                customerModel.FirstName = customer.FirstName;
                customerModel.LastName = customer.LastName;
                customerModel.Country = customer.Country;
                customerModel.Email = customer.Email;
                customerModels.Add(customerModel);
            }
            model.Customers = customerModels;
            return View(model);
        }

        public ActionResult Add()
        {
            CustomerModel model = new CustomerModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                CustomerAdapter customerAdapter = new CustomerAdapter();
                Customer customer = new Customer();
                customer.FirstName = model.FirstName;
                customer.LastName = model.LastName;
                customer.Country = model.Country;
                customer.Email = model.Email;
                bool returnValue = customerAdapter.InsertCustomer(customer);
                if (returnValue)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Edit(int customerId)
        {
            CustomerAdapter customerAdapter = new CustomerAdapter();
            Customer customer = customerAdapter.GetById(customerId);
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                CustomerModel model = new CustomerModel();
                model.CustomerId = customer.CustomerId;
                model.FirstName = customer.FirstName;
                model.LastName = customer.LastName;
                model.Country = customer.Country;
                model.Email = customer.Email;
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Edit(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                CustomerAdapter customerAdapter = new CustomerAdapter();
                Customer customer = new Customer();
                customer.FirstName = model.FirstName;
                customer.LastName = model.LastName;
                customer.CustomerId = model.CustomerId;
                customer.Country = model.Country;
                customer.Email = model.Email;
                bool returnValue = customerAdapter.UpdateCustomer(customer);
                if (returnValue)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Delete(int customerId)
        {
            CustomerAdapter customerAdapter = new CustomerAdapter();
            bool returnValue = customerAdapter.DeleteCustomer(customerId);
            return RedirectToAction("Index");
        }
    }
}