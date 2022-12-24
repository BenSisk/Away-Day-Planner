using awayDayPlanner.GUI.View.NewItem;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting.Booking
{
    class AddNewItemMoc : IaddNewItem
    {
        public string custom;
        public string notes;
        public ActivityType activityType;

        public ActivityType getActivityType()
        {
            return activityType;
        }

        public string getCustomRequest()
        {
            return custom;
        }

        public string getNotes()
        {
            return notes;
        }

        public Form GetForm()
        {
            return new Form();
        } 
    }
}
