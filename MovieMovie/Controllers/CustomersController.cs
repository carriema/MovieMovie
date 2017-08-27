using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieMovie.Models;
using MovieMovie.ViewModels;

namespace MovieMovie.Controllers
{
    [RoutePrefix("Customers")]
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("")]
        public ActionResult Index()
        {
            var customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Jim King" },
                new Customer() { Id = 2, Name = "Carrie Ma" }
            };
            CustomerListViewModel customerListView = new CustomerListViewModel() {
                Customers = customers

            };

            return View(customerListView);
            
        }
        [Route("Detail/{id}")]
        public ActionResult Detail(int id)
        {
            if (id == 1)
            {
                return View(new Customer() { Name = "Jim King" });
            } else if (id == 2)
            {
                return View(new Customer() { Name = "Carrie Ma"});
            } else
            {
                return HttpNotFound();
            }
        }
    }
}