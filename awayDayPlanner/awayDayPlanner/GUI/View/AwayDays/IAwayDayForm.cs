using awayDayPlanner.GUI.Presenter.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.View.AwayDays
{
    public interface IAwayDayForm
    {
        void register(IAwayDayPresenter presenter);
        void Reset();
    }
}
