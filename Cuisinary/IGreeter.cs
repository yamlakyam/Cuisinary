using Microsoft.Extensions.Configuration;

namespace Cuisinary
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;  
        }

        public string GetMessageOfTheDay()
        {
            //return "Hello from my Greeter Service";
            return _configuration["Greeting"];
        }
    }
}