using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.View;

namespace awayDayPlanner.GUI.Presenter
{
    public interface IControlPanelPresenter
    {
        void newAwayDay();
        void viewExistingAwayDays();
    }
}
