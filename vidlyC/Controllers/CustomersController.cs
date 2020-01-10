using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidlyC.Models;
using vidlyC.ViewModels;

namespace vidlyC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        public ActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}