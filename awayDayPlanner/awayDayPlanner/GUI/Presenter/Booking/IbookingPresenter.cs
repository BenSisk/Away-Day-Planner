using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.Presenter.Booking
{
    public interface IbookingPresenter
    {
        void submit();
        void addActivity();
        void deleteRows(DataGridViewSelectedRowCollection rows);
        void Close();
    }
}