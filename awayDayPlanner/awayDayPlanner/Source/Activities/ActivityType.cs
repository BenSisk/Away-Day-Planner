using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Activities
{
    public class ActivityType
    {
        [Key]
        public int ActivityTypeID { get; set; }
        [Required]
        public string ActivityTypeName { get; set; }
        [Required]
        public double ActivityTypeEstimatedPrice { get; set; }

        public ActivityType (string activityOptionName, double activityOptionEstimatedPrice)
        {
            this.ActivityTypeName = activityOptionName;
            this.ActivityTypeEstimatedPrice = activityOptionEstimatedPrice;
        }

        public ActivityType() { }

        public override string ToString()
        {
            return ActivityTypeName;
        }
    }
}
