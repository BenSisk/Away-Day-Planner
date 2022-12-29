using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting.Booking
{
    public class BookingPresenterMoc : IBookingPresenter
    {
        public IBookingModel model;
        public int submitSuccess;
        public List<IActivity> activities;
        public DateTime date;

        public void Submit()
        {

        }

        public void AddActivity()
        {

        }

        public void DeleteRows(DataGridViewSelectedRowCollection rows)
        {

        }

        public void Close()
        {

        }

        public void CallModel()
        {
            model.Submit(activities, date);
        }
    }
}
