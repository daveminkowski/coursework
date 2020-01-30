using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project6.Models;

namespace Project6.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomer(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success", model);
            }
            return View(model);
        }

        public ActionResult Success(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}