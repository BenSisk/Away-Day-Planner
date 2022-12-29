using awayDayPlanner.GUI.Presenter.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.View.AwayDays
{
    public interface IAwayDayForm
    {
        void register(IAwayDayPresenter presenter);
        void Reset();
        void AddItemToDGV(DateTime date, int count, string status, double cost);
        DataGridViewRow GetSelected();
        DialogResult displayFormAsDialog(Form form);
        void Message(string message, string title);
    }
}
