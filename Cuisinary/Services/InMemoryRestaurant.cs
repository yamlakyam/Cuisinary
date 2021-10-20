using Cuisinary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {

        public InMemoryRestaurant()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id=1, Name="Injoy"},
                new Restaurant{ Id=2, Name="Enjoy"}
            };
        }

        List<Restaurant> _restaurants;
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }
    }
}
