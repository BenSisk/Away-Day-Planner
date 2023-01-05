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

        public void Register(IAwayDayPresenter presenter)
        {
            this.presenter = presenter;
        }

        public List<AwayDay> GetData()
        {
            var user = FormProvider.LoginForm.GetUser().userID;
            var query = from awaydays in Database.Database.Data.AwayDay
                        where (awaydays.User.userID == user)
                        select awaydays;
            return query.ToList();
        }
    }
}