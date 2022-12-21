using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.View;
using awayDayPlanner.GUI.View.ControlPanel;

namespace awayDayPlanner.GUI.Presenter.ControlPanel
{
    public class ControlPanelPresenter : IControlPanelPresenter
    {
        private IControlPanelForm view;

        public ControlPanelPresenter()
        {
            this.view = FormProvider.ControlPanelForm;
            view.register(this);
        }

        public void newAwayDay()
        {
            FormProvider.ControlPanelForm.Hide();
            FormProvider.bookingForm.Show();
        }

        public void viewExistingAwayDays()
        {
            FormProvider.ControlPanelForm.Hide();
            FormProvider.AwayDayForm.Show();
        }
    }
}
