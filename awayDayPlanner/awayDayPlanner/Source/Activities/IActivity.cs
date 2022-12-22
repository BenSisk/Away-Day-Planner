using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Activities
{
    public interface IActivity
    {
        int ActivityID { get; set; }
        ActivityType Type { get; set; }
        string Name { get; set; }
        string Notes { get; set; }
        double ActualCost { get; set; }
        IActivity CreateActivity();
        Activity getObject();
    }
}
