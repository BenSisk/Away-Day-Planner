using awayDayPlanner.GUI.Model.AwayDays;
using awayDayPlanner.GUI.Presenter.AwayDays;
using awayDayPlanner.GUI.View.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.AwayDayTesting
{
    public class AwayDayPresenterMoc : IAwayDayPresenter
    {
        public IAwayDayForm view;
        public IAwayDayModel model;

        public void Close() { }
        public void PopulateDataGrid() { }
        public void OpenAwayDay() { }
    }
}
