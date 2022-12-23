using awayDayPlanner.GUI.Model.AwayDays;
using awayDayPlanner.GUI.View.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Source.Activities;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.Presenter.AwayDays
{
    public class AwayDayPresenter : IAwayDayPresenter
    {
        IAwayDayForm view;
        IAwayDayModel model;
        List<AwayDay> data;
        
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
            data = model.GetData();
            string status;
            foreach (var awayday in data)
            {
                if (awayday.Confirmed)
                {
                    status = "Confirmed";
                }
                else if (awayday.CanBeConfirmed)
                {
                    status = "Confirmable";
                }
                else
                {
                    status = "Under Review";
                }
                view.addItemToDGV(awayday.AwayDayDate, awayday.AwayDayActivities.Count(), status, awayday.TotalCost);
            }
        }

        public void OpenAwayDay()
        {
            var awayday = data.ElementAt(view.GetSelected().Index);
            if (awayday.CanBeConfirmed == true)
            {
                FormProvider.AwayDayActivities.PopulateDataGrid(awayday);
                if (view.displayFormAsDialog(FormProvider.AwayDayActivities) == DialogResult.OK)
                {
                    //GeneratePDF(awayday)
                }
                view.Reset();
            }
            else
            {
                view.message("Away-Day has not yet been reviewed.\n\nPlease try again later", "Error");
            }
        }
    }
}