using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DemoKO.Models
{
    public class CVMContext : DbContext
    {
        public CVMContext():base("DefaultConnection")
        {
            Database.SetInitializer(new CVMDatabaseInitializer());
        }
        public DbSet<CVInfo> infoes { get; set; }
    }
}