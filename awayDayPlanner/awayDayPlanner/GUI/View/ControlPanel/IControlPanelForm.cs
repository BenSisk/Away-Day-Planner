using awayDayPlanner.GUI.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Presenter.ControlPanel;

namespace awayDayPlanner.GUI.View.ControlPanel
{
    public interface IControlPanelForm
    {
        void register(IControlPanelPresenter presenter);
    }
}
