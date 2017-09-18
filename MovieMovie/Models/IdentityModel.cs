using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieMovie.Models
{
    public class IdentityModel
    {

    }

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Membership> membership { get; set; }
    }
}