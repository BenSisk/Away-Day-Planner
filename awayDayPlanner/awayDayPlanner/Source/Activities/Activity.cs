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
    public class Activity : IActivity
    {
        [Key]
        public int ActivityID { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Notes { get; set; }
        public double ActualCost { get; set; }
        [Required]
        public virtual ActivityType Type { get; set; }

        public IActivity CreateActivity()
        {
            return new Activity(this.Type);
        }

        public Activity getObject()
        {
            return this;
        }

        public Activity(ActivityType Type)
        {
            this.Type = Type;
        }

        public Activity() { }
    }
}