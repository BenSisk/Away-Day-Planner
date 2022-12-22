using awayDayPlanner.Lib.Users;

using System.Data.Entity;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Source.Users;
using awayDayPlanner.Source.Activities;

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
        public DbSet<AwayDay> AwayDay { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ActivityType> ActivityOptions { get; set; }
    }
}
