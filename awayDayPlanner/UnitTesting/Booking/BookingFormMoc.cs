using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.GUI.View.Booking;
using System.Windows.Forms;
using awayDayPlanner.GUI.View.NewItem;

namespace UnitTesting.Booking
{
    class BookingFormMoc : IBookingForm
    {
        public string message_txt = "";
        public List<string> names = new List<string>();
        public List<string> notes = new List<string>();
        public List<double> prices = new List<double>();
        public DateTime date;

        public void Register(IBookingPresenter presenter)
        {

        }

        public void Message(string message_txt)
        {
            this.message_txt = message_txt;
        }

        public DialogResult DisplayFormAsDialog(IAddNewItem form)
        {
            return DialogResult.OK;
        }

        public void AddItemToDGV(string name, string notes, double price)
        {
            this.names.Add(name);
            this.notes.Add(notes);
            this.prices.Add(price);
        }

        public void DeleteRow(DataGridViewRow row)
        {

        }

        public void Reset()
        {

        }

        public DateTime GetDate()
        {
            return date;
        }
    }
}