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

namespace awayDayPlanner.Database
{
    public class ADPContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
