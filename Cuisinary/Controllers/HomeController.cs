
using Cuisinary.Models;
using Cuisinary.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Controllers
{
    public class HomeController : Controller
    {
        public IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public IActionResult Index()
        {
            //var model = "Hello from Controller";
            var model = new Restaurant {Id =1, Name="Injoy" };

            var model1 = _restaurantData.GetAll();
            //return new ObjectResult(model);
            //return View(model);
            return Ok(model1);
        }
    }
}
