using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Randome(){
        
        var movie = new Movie() { Name = "Game of Throne" };
        var customers = new List<Customer>()
        {
            new Customer {Name = "customer 1"},
            new Customer {Name = "customer 2"}
        };
        var viewModel = new RandomMovieViewModel()
        {
            Movie = movie,
            Customers=customers
        };
            return View(viewModel);
        }




















        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if(string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name"; 
            }
            return Content(String.Format("pageindex = {0} $ sortBy = {1}", pageIndex, sortBy));
        }
        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult Byreleasedate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}