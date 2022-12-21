using awayDayPlanner.GUI.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.View
{
    public interface IControlPanelForm
    {
        void register(IControlPanelPresenter presenter);
    }
}
