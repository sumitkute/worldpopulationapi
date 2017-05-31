using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using world.data;

namespace worldpopulationapi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<People> People { get; set; }
        public ApplicationDbContext()
            : base("PeopleDBConnection")
        {
            //  Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseAlways<ApplicationDbContext>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}