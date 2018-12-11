using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication10.Models;
using System.Data.Entity;

namespace WebApplication10.DbContext
{
    public class Db : System.Data.Entity.DbContext
    {
        public Db() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BestHotDogs;Integrated Security=True;")
        {

        }
        public DbSet<HotDog> HotDog { get; set; }
        public DbSet<Sauce> Sauces { get; set; }

    }
}