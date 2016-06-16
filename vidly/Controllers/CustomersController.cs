using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>()
        {
            new Customer {Id = 1 ,Name = "customer 1"},
            new Customer {Id = 2 ,Name = "customer 2"}
        };
            var viewmodel = new RandomMovieViewModel
            {
                Customers = customers
            };
            return View(viewmodel);
        }
        public ActionResult Details(int id)
        {
           
            return View();
        }
    }
}