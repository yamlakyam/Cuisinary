using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Controller
{

    [Route("abbout")]
    public class AboutController 
    {
        public string Phone()
        {
            return "+251911009900";
        }

        [Route("address")]
        public string Address() {

            return "127.0.0.1";
        }
    }
}
