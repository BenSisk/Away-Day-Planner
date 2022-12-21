using awayDayPlanner.GUI.Presenter.AwayDays;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.AwayDays
{
    public interface IAwayDayModel
    {
        void register(IAwayDayPresenter presenter);
        List<AwayDay> GetData();
    }
}