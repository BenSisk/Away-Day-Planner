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
        ActivityEnum Type { get; set; }
        string Name { get; set; }
        string Notes { get; set; }
        double EstimatedCost { get; set; }
        void RegisterActivity();
        IActivity CreateActivity();
        Activity getObject();
    }
}
