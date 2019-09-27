using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomer();

            //var customer = new Customer() { Id = 1, Name = "Pepe Amaya" };
            return View(customers);
        }

        public IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer() { Id = 1, Name = "Pepe Amaya"},
                new Customer() { Id = 2, Name = "Emiliano Amaya"}
            };
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomer().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}