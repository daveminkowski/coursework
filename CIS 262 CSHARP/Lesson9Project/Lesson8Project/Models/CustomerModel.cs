using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson8Project.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
    }

    public class AllCustomersModel
    {
        public List<CustomerModel> Customers { get; set; }
    }
}