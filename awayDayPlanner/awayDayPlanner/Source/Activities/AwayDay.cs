using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Lib.Users;

namespace awayDayPlanner.Source.Activities
{
    public class AwayDay
    {
        [Key]
        public int AwayDayID { get; set; }
        [Required]
        public DateTime AwayDayDate { get; set; }
        [Required]
        public bool Confirmed { get; set; }
        [Required]
        public double TotalCost { get; set; }
        [Required]
        public virtual ICollection<Activity> AwayDayActivities { get; set; } = new List<Activity>();
        [Required]
        public virtual User User { get; set; }
    }
}
