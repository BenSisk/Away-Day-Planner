using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.GUI.Presenter.Admin;

namespace awayDayPlanner.GUI.View.Admin
{
    public interface IAdminForm
    {
        void register(IAdminPresenter presenter);
        void addItemToDGV(DateTime date, int count, double cost);
        void Reset();
        DialogResult displayFormAsDialog(Form form);
        DataGridViewRow GetSelected();
    }
}
