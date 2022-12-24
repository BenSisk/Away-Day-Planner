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
    public interface IbookingForm
    {
        void register(IbookingPresenter presenter);
        
        void message(string message);

        DialogResult displayFormAsDialog(IaddNewItem form);

        void addItemToDGV(string name, string notes, double price);

        void deleteRow(DataGridViewRow row);

        void Reset();

        DateTime getDate();
    }
}