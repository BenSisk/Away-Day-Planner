using awayDayPlanner.Lib.Users;

using System.Data.Entity;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Source.Users;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.Source.Factory;

namespace awayDayPlanner.Database
{
    public class ADPContext : DbContext
    {
        public ADPContext()
            : base("name=conString")
            { 
        }
        public DbSet<IUser> User { get; set; }
        public DbSet<ILogin> Login { get; set; }
        public DbSet<IAddress> Address { get; set; }
        public DbSet<AwayDay> AwayDay { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<ActivityType> ActivityOptions { get; set; }
    }
}
