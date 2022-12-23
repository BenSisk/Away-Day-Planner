using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.Source.Activities;

namespace UnitTesting.Booking
{
    class BookingModelMoc : IbookingModel
    {
        public void register(IbookingPresenter presenter) { }

        public int submit(List<IActivity> activities, DateTime datetime)
        {
            return 0;
        }
    }
}
