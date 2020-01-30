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
        // GET: Customer
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
                customerModels.Add(customerModel);
            }
            model.Customers = customerModels;
            return View(model);
        }
    }
}