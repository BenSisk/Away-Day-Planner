using awayDayPlanner.Lib.Users;

using System.Data.Entity;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Source.Users;

namespace awayDayPlanner.Database
{
    public class ADPContext : DbContext
    {
        public ADPContext()
            : base("name=conString")
            { 
        }
        public DbSet<User> User { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
