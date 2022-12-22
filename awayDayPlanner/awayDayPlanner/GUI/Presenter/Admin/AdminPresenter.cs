using awayDayPlanner.GUI.Model.Admin;
using awayDayPlanner.GUI.View.Admin;
using awayDayPlanner.GUI.View.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.Source.Activities;

namespace awayDayPlanner.GUI.Presenter.Admin
{
    public class AdminPresenter : IAdminPresenter
    {
        IAdminForm view;
        IAdminModel model;
        List<AwayDay> data;

        public AdminPresenter()
        {
            this.view = FormProvider.AdminForm;
            this.model = FormProvider.AdminModel;
            view.register(this);
            model.register(this);
            view.Reset();
        }

        public void OpenSelected()
        {
            FormProvider.AdminReviewForm.Reset();
            view.displayFormAsDialog(FormProvider.AdminReviewForm);
        }

        public void PopulateDataGrid()
        {
            data = model.GetData();
            foreach (var item in data)
            {
                view.addItemToDGV(item.AwayDayDate, item.AwayDayActivities.Count(), sum(item));
            }
        }

        private double sum(AwayDay awayday)
        {
            double total = 0;
            foreach (var item in awayday.AwayDayActivities)
            {
                total += item.Type.ActivityTypeEstimatedPrice;
            }
            return total;
        }

        public AwayDay getAwayDay()
        {
            return data.ElementAt(view.GetSelected().Index);
        }
        public void LogOut()
        {
            FormProvider.ControlPanelForm.Show();
            FormProvider.AdminForm.Hide();
        }
    }
}