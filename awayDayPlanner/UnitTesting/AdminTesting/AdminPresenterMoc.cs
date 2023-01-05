using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.AdminTesting
{
    public class AdminPresenterMoc : IAdminPresenter
    {
        public AwayDay awayday;
        public void OpenSelected() { }
        public void PopulateDataGrid()
        {

        }
        public AwayDay GetAwayDay()
        {
            return awayday;
        }
        public void LogOut() { }
    }
}
