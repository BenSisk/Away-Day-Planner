using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Billing
{
    public class AwayDay
    {
        public int AwayDayID = 1;
        public DateTime AwayDayDate = DateTime.Now;
        public bool Confirmed = true;
        public double TotalCost = 13.45;
        public ICollection<Activity> AwayDayActivities = new List<Activity>()
        {
            new Activity()
        };

        public User User = new User();
    }

    public class Activity
    {
        public int ActivityID = 1;
        public ActivityType 
        public string Name { get; set; }
        [MaxLength(200)]
        public string Notes { get; set; }
        public double EstimatedCost { get; set; }

        public abstract void RegisterActivity();
        public abstract IActivity CreateActivity();

        public Activity getObject()
        {
            return this;
        }




    }

    public class User
    {



    }


}
