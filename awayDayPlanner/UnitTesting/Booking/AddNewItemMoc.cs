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
    class AddNewItemMoc : IAddNewItem
    {
        public string custom;
        public string notes;
        public ActivityType activityType;

        public ActivityType GetActivityType()
        {
            return activityType;
        }

        public string GetCustomRequest()
        {
            return custom;
        }

        public string GetNotes()
        {
            return notes;
        }

        public Form GetForm()
        {
            return new Form();
        } 
    }
}
