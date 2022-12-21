using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.Lib.Users;

namespace awayDayPlanner.GUI.Model.Booking
{
    public partial class bookingModel : IbookingModel
    {
        private IbookingPresenter presenter;
        private User user = new User();


        public bookingModel()
        {

        }

        public void register(IbookingPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void generatePDF()
        {
            //make itemised PDF
        }

        public int submit(List<IActivity> activities)
        {
            if (activities.Count > 0)
            {
                AwayDay awayday = new AwayDay();
                foreach (IActivity activity in activities)
                {
                    Database.Database.Data.Activity.Add(activity.getObject());
                    awayday.AwayDayActivities.Add(activity.getObject());
                }
                awayday.User = this.user;
                Database.Database.Data.AwayDay.Add(awayday);
                Database.Database.Data.SaveChanges();
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}