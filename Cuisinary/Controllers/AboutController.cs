using Microsoft.AspNetCore.Mvc;

namespace Cuisinary.Controllers
{
    [Route("abbout")]
    public class AboutController : Controller
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
