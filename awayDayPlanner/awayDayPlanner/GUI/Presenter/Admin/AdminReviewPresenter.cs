using awayDayPlanner.GUI.View.Admin;
using awayDayPlanner.GUI.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Source.Activities;
using System.Windows.Forms;
using awayDayPlanner.GUI.View.AwayDays;

namespace awayDayPlanner.GUI.Presenter.Admin
{
    public class AdminReviewPresenter : IAdminReviewPresenter
    {
        IAdminReviewForm view;
        IAdminReviewModel model;
        AwayDay awayday;

        public AdminReviewPresenter()
        {
            this.view = FormProvider.AdminReviewForm;
            this.model = FormProvider.AdminReviewModel;
            view.register(this);
            model.register(this);
            view.Reset();
        }

        public void PopulateDataGrid()
        {
            awayday = FormProvider.AdminPresenter.getAwayDay();
            foreach (var activity in awayday.AwayDayActivities)
            {
                view.addItemToDGV(activity.Type, activity.Name, activity.Type.ActivityTypeEstimatedPrice);
            }
        }

        public void Submit()
        {
            bool passed = true;
            List<double> ActivityPrices = new List<double>();
            DataGridViewRowCollection rows = view.GetPrices();
            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells["Actual Cost"].Value == null ||
                    ! Double.TryParse(row.Cells["Actual Cost"].Value.ToString(), out double result) ||
                    result < 0)
                {
                    passed = false;
                }
                else
                {
                    ActivityPrices.Add(result);
                }
            }
            if (passed)
            {
                int index = 0;
                double total = 0;
                foreach (var activity in awayday.AwayDayActivities)
                {
                    activity.ActualCost = ActivityPrices[index];
                    total += activity.ActualCost;
                    index += 1;
                }
                this.awayday.TotalCost = total;
                this.awayday.CanBeConfirmed = true;
                Database.Database.Data.SaveChanges();
                FormProvider.AdminForm.Reset();
                view.Exit();
            }
            else
            {
                view.Message("Invalid Price", "Error");
            }
        }
    }
}
