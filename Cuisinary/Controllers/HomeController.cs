
using Cuisinary.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var model = "Hello from Controller";
            var model = new Restaurant {Id =1, Name="Injoy" };
            //return new ObjectResult(model);
            // return new ObjectResult(model);
            return View(model);
        }
    }
}
