using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.View.NewItem
{
    public interface IaddNewItem
    {
        ActivityType getActivityType();
        string getCustomRequest();
        string getNotes();
        Form GetForm();
    }
}