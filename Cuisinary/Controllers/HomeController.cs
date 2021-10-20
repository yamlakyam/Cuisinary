
using Cuisinary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Controllers
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            //var model = "Hello from Controller";
            var model = new Restaurant {Id =1, Name="Mother Bet" };
            return new ObjectResult(model);
        }
    }
}
