using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using awayDayPlanner.Lib.Users;

using System.Data.Entity;
using System.Configuration;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.GUI;
using awayDayPlanner.Source.Users;

namespace awayDayPlanner.Database
{
    public class ADPContext : DbContext
    {
        public ADPContext() : base()
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
