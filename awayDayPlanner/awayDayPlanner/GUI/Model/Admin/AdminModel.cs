using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Admin
{
    public class AdminModel : IAdminModel
    {
        IAdminPresenter presenter;

        public void register(IAdminPresenter presenter)
        {
            this.presenter = presenter;
        }

        public List<AwayDay> GetData()
        {
            var query = from awaydays in Database.Database.Data.AwayDay
                        where (awaydays.CanBeConfirmed == false)
                        select awaydays;
            return query.ToList();
        }
    }
}
