using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.ActivityTesting
{
    public class ActivityMoc : IActivity
    {
        public int ActivityID { get; set; }
        public ActivityType Type { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public double ActualCost { get; set; }
        public IActivity CreateActivity()
        {
            return new ActivityMoc(this.Type);
        }

        public Activity getObject()
        {
            var activity = new Activity();
            activity.Name = this.Name;
            activity.Type = this.Type;
            activity.ActualCost = this.ActualCost;
            activity.Notes = this.Notes;
            return activity;
        }

        public ActivityMoc(ActivityType Type)
        {
            this.Type = Type;
        }

        public ActivityMoc() { }
    }
}
