using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.DMWMB._2024.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstProject.DMWMB._2024.Controllers
{
    public class MovieController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //Movie m = new Movie(1, "");
            List<Movie> movies = new List<Movie>()
            {
                new Movie{ Id=1, Name="Movie1"},
                new Movie{Id=2, Name="Movie2"}
            };
            return View(movies);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            
            return Content("Test  " + id);
        }
    }
}

