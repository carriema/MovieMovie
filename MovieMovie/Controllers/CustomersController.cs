using System;
using System.Data.Entity;
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

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route("")]
        public ActionResult Index()
        {
            var customers = _context.customers.Include(c => c.Membership).ToList();
           
            CustomerListViewModel customerListView = new CustomerListViewModel() {
                Customers = customers

            };

            return View(customerListView);
            
        }
        [Route("Detail/{id}")]
        public ActionResult Detail(int id)
        {
            var customer = _context.customers.Include(c => c.Membership).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}