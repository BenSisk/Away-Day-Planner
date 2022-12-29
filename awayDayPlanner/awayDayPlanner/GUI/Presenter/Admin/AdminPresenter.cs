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
        private IAdminForm view;
        private IAdminModel model;
        List<AwayDay> data;

        public AdminPresenter(IAdminForm view, IAdminModel model)
        {
            this.view = view;
            this.model = model;
            view.Register(this);
            model.Register(this);
            view.Reset();
        }

        public void OpenSelected()
        {
            FormProvider.AdminReviewForm.Reset();
            view.DisplayFormAsDialog(FormProvider.AdminReviewForm);
        }

        public void PopulateDataGrid()
        {
            data = model.GetData();
            foreach (var item in data)
            {
                view.AddItemToDGV(item.AwayDayDate, item.AwayDayActivities.Count(), Sum(item));
            }
        }

        private double Sum(AwayDay awayday)
        {
            double total = 0;
            foreach (var item in awayday.AwayDayActivities)
            {
                total += item.Type.ActivityTypeEstimatedPrice;
            }
            return total;
        }

        public AwayDay GetAwayDay()
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