using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.View;
using awayDayPlanner.GUI.View.ControlPanel;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.Source.Users;

namespace awayDayPlanner.GUI.Presenter.ControlPanel
{
    public class ControlPanelPresenter : IControlPanelPresenter
    {
        public User user;

        private IControlPanelForm view;

        public ControlPanelPresenter(IControlPanelForm view)
        {
            this.view = view;
            view.Register(this);


            //BELOW IS NOT STAYING HERE
            //var query = from users in Database.Database.Data.User
            //            where (users.userID == 1)
            //            select users;
            //user = query.First();
        }

        public void NewAwayDay()
        {
            FormProvider.BookingForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }

        public void ViewExistingAwayDays()
        {
            FormProvider.AwayDayForm.Reset();
            FormProvider.AwayDayForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }

        public void LogOut()
        {
            FormProvider.ControlPanelForm.user = null;
            FormProvider.LoginForm.Reset();
            FormProvider.LoginForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }
    }
}