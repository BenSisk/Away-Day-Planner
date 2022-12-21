using awayDayPlanner.GUI.Presenter.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.Lib.Users;

namespace awayDayPlanner.GUI.Model.AwayDays
{
    public class AwayDayModel : IAwayDayModel
    {
        private IAwayDayPresenter presenter;

        public void register(IAwayDayPresenter presenter)
        {
            this.presenter = presenter;
        }

        public List<AwayDay> GetData()
        {
            User user = FormProvider.ControlPanelPresenter.user;
            var query = from awaydays in Database.Database.Data.AwayDay
                        where (awaydays.User.userID == user.userID)
                        select awaydays;
            return query.ToList();
        }
    }
}