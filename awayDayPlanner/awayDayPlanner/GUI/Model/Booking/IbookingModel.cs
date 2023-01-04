using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.GUI.Presenter.Booking;

namespace awayDayPlanner.GUI.Model.Booking
{
    public interface IBookingModel
    {
        void Register(IBookingPresenter presenter);
        int Submit(List<IActivity> activities, DateTime date);
    }
}
