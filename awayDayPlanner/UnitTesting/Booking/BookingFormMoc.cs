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
    class BookingFormMoc : IbookingForm
    {
        public string Message = "";
        public List<string> names = new List<string>();
        public List<string> notes = new List<string>();
        public List<double> prices = new List<double>();
        public DateTime date;

        public void register(IbookingPresenter presenter)
        {

        }

        public void message(string message)
        {
            this.Message = message;
        }

        public DialogResult displayFormAsDialog(IaddNewItem form)
        {
            return DialogResult.OK;
        }

        public void addItemToDGV(string name, string notes, double price)
        {
            this.names.Add(name);
            this.notes.Add(notes);
            this.prices.Add(price);
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