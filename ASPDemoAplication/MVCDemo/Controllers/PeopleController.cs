using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Pepe", LastName = "Amaya", Age = 24 });
            people.Add(new PersonModel { FirstName = "Miguel", LastName = "Mata", Age = 25 });
            people.Add(new PersonModel { FirstName = "Valentina", LastName = "Morales", Age = 26 });
            people.Add(new PersonModel { FirstName = "Omar", LastName = "Negrete", Age = 27 });
            people.Add(new PersonModel { FirstName = "Lupe", LastName = "Jimenez", Age = 28 });

            return View(people);
        }
    }
}