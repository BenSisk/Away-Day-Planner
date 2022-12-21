using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.Source.Activities
{
    public abstract class Activity : IActivity
    {
        [Key]
        public int ActivityID { get; set; }
        [Required]
        public ActivityEnum Type { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Notes { get; set; }
        public double EstimatedCost { get; set; }
        public double ActualCost { get; set; }

        public abstract void RegisterActivity();
        public abstract IActivity CreateActivity();

        public Activity getObject()
        {
            return this;
        }
    }

    public class ActivityNormal : Activity
    {
        override public void RegisterActivity()
        {
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(this.Type, new ActivityNormal());
        }

        override public IActivity CreateActivity()
        {
            return new ActivityNormal();
        }
    }

    public class ActivityCustom : Activity
    {
        public ActivityCustom()
        {
            this.EstimatedCost = 0;
        }

        override public void RegisterActivity()
        {
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(this.Type, new ActivityCustom());
        }

        override public IActivity CreateActivity()
        {
            return new ActivityCustom();
        }
    }
}
