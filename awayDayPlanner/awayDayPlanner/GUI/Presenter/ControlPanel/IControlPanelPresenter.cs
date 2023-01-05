using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.View;

namespace awayDayPlanner.GUI.Presenter.ControlPanel
{
    public interface IControlPanelPresenter
    {
        void NewAwayDay();
        void ViewExistingAwayDays();
        void LogOut();
        void AdminShow();
        void AdminCheck();
    }
}