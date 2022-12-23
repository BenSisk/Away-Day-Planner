using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.GUI.View.Booking;
using System.Windows.Forms;


namespace UnitTesting.Booking
{
    class BookingFormMoc : IbookingForm
    {
        string Message = "";
        DateTime date;

        public void register(IbookingPresenter presenter)
        {

        }

        public void message(string message)
        {
            this.Message = message;
        }

        public DialogResult displayFormAsDialog(Form form)
        {
            return DialogResult.OK;
        }

        public void addItemToDGV(string name, string notes, double price)
        {

        }

        public void deleteRow(DataGridViewRow row)
        {

        }

        public void Reset()
        {

        }

        public DateTime getDate()
        {
            return date;
        }
    }
}