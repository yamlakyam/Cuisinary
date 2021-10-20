using Cuisinary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Services
{
    public interface IRestaurantData
    {

       public IEnumerable<Restaurant> GetAll();
        public Restaurant Get(int id);
    }
}
