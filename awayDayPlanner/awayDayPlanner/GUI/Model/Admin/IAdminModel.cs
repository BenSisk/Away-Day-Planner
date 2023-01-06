using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Admin
{
    public interface IAdminModel 
    {
        void Register(IAdminPresenter presenter);
        List<AwayDay> GetData();
    }
}