using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.DMWMB._2024.Models;
using FirstProject.DMWMB._2024.Models.VIewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProject.DMWMB._2024.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Movie m = new Movie
            { Id = 1, Name = "Movie 1" };
            CustomersMovieVM c = new CustomersMovieVM()
            {
                movie = m,
                customers = GetAll()
            };
            return View(c);
        }
        public IActionResult Details(int? id)
        {
            var detailscustomer = GetAll()
                .FirstOrDefault(c => c.Id == id);
            return View(detailscustomer);
        }

        private List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>()
        {
            new Customer{Id=1, Name="Customer1"},
            new Customer{Id=2, Name="Customer2"}
        };
            return customers;
        }   
    }

    
}

