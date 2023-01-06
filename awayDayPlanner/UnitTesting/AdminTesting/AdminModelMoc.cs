using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Model.Admin;
using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Source.Activities;

namespace UnitTesting.AdminTesting
{
    public class AdminModelMoc : IAdminModel
    {
        public bool hasRegistered;
        public List<AwayDay> awayDayList;

        public void Register(IAdminPresenter presenter)
        {
            this.hasRegistered = true;
        }

        public List<AwayDay> GetData()
        {
            return awayDayList;
        }
    }
}
