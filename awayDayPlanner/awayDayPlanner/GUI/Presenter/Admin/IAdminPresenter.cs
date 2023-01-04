using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.Presenter.Admin
{
    public interface IAdminPresenter
    {
        void OpenSelected();
        void PopulateDataGrid();
        AwayDay GetAwayDay();
        void CloseAdmin();
    }
}
