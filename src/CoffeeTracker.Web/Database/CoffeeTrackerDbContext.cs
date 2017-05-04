using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeTracker.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTracker.Web.Database
{
    public class CoffeeTrackerDbContext : DbContext
    {
        public CoffeeTrackerDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
