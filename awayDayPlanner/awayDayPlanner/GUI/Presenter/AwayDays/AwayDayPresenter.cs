using awayDayPlanner.GUI.Model.AwayDays;
using awayDayPlanner.GUI.View.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Source.Activities;

namespace awayDayPlanner.GUI.Presenter.AwayDays
{
    public class AwayDayPresenter : IAwayDayPresenter
    {
        IAwayDayForm view;
        IAwayDayModel model;

        public AwayDayPresenter()
        {
            this.view = FormProvider.AwayDayForm;
            this.model = FormProvider.AwayDayModel;

            view.register(this);
            model.register(this);
        }

        public void Close()
        {
            FormProvider.ControlPanelForm.Show();
            FormProvider.AwayDayForm.Hide();
        }

        public void PopulateDataGrid()
        {
            List<AwayDay> data = model.GetData();
            foreach (var awayday in data)
            {
                view.addItemToDGV(awayday.AwayDayDate, awayday.AwayDayActivities.Count(), awayday.Confirmed, awayday.TotalCost);
            }
        }
    }
}
