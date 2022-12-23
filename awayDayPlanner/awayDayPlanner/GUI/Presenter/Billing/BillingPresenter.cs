using awayDayPlanner.GUI.Billing;
using awayDayPlanner.GUI.Model.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI
{
    public class BillingPresenter
    {
        private readonly IBillingView _view;
        private readonly IBillingModel _model;

        public BillingPresenter(IBillingView view, IBillingModel model)
        {
            _view = view;
            view.Presenter = this;
            _model = model;
        }

        public void PopulateDataGrid()
        {
            foreach (var awayday in data)
            {
                _view.addItemToDGV(awayday.AwayDayDate, awayday.AwayDayActivities.Count(), awayday.TotalCost);
            }
        }

    }
}
