using Cuisinary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cuisinary.Data
{
    public class CuisinaryDbContext :DbContext
    {
        public CuisinaryDbContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
