using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.Presenter.Booking
{
    public interface IBookingPresenter
    {
        void Submit();
        void AddActivity();
        void DeleteRows(DataGridViewSelectedRowCollection rows);
        void Close();
    }
}