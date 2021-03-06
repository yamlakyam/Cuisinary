
using Cuisinary.Models;
using Cuisinary.Services;
using Cuisinary.ViewModels;
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
        public IGreeter _greeter;


        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public IActionResult Index()
        {
            var model1 = _restaurantData.GetAll();
            var model = new HomeIndexViewModel();

            model.CurrentMessage = _greeter.GetMessageOfTheDay();
            model.Restaurants = _restaurantData.GetAll();

            //return new ObjectResult(model);
            //return View(model);
            //return Ok(model1);
            return Ok(model);
        }

        public IActionResult Details(int id)
        {
            var model= _restaurantData.Get(id);

            if (model == null) {
                //return new ObjectResult("Couldnt Find Such restaurant");
                return RedirectToAction(nameof(Index));
            }
            return new ObjectResult(model);
        }

        
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(RestaurantEditModel model) {

            var newRestaurant = new Restaurant();
            newRestaurant.Name = model.Name;
            newRestaurant.Cuisine = model.Cuisine;

            newRestaurant = _restaurantData.Add(newRestaurant);

            //return new ObjectResult(newRestaurant);
            return RedirectToAction(nameof(Details), new {id= newRestaurant.Id});
        }
    }
}
