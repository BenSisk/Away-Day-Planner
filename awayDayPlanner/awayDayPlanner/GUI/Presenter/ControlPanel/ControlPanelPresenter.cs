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

        public ControlPanelPresenter()
        {
            this.view = FormProvider.ControlPanelForm;
            view.register(this);

            var query = from users in Database.Database.Data.User
                        where (users.userID == 1)
                        select users;
            user = query.FirstOrDefault();
        }

        public void newAwayDay()
        {
            FormProvider.bookingForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }

        public void viewExistingAwayDays()
        {
            FormProvider.AwayDayForm.Reset();
            FormProvider.AwayDayForm.Show();
            FormProvider.ControlPanelForm.Hide();
        }
    }
}