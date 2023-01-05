using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.GUI.View.NewItem;

namespace awayDayPlanner.GUI.View.Booking
{
    public interface IBookingForm
    {
        void Register(IBookingPresenter presenter);
        
        void Message(string message);

        DialogResult DisplayFormAsDialog(IAddNewItem form);

        void AddItemToDGV(string name, string notes, double price);

        void DeleteRow(DataGridViewRow row);

        void Reset();

        DateTime GetDate();
    }
}