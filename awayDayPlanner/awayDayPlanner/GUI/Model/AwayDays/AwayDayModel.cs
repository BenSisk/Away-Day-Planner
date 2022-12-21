using awayDayPlanner.GUI.Presenter.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.AwayDays
{
    public class AwayDayModel : IAwayDayModel
    {
        private IAwayDayPresenter presenter;

        public void register(IAwayDayPresenter presenter)
        {
            this.presenter = presenter;
        }
    }
}
