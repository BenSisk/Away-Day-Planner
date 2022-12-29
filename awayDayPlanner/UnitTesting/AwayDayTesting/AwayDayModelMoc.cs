using awayDayPlanner.GUI.Model.AwayDays;
using awayDayPlanner.GUI.Presenter.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Source.Activities;

namespace UnitTesting.AwayDayTesting
{
    public class AwayDayModelMoc : IAwayDayModel
    {
        public List<AwayDay> awayDayList = new List<AwayDay>();

        public void register(IAwayDayPresenter presenter) { }
        public List<AwayDay> GetData()
        {
            return awayDayList;
        }
    }
}
