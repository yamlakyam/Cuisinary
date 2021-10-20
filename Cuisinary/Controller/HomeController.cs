using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Controller
{
    public class HomeController 
    {
        public IActionResult Index()
        {
            var model = "hi";

            return new ObjectResult(model);
        }
    }
}
