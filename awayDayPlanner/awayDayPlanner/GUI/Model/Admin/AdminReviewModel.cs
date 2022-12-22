using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.GUI.View.AwayDays;
using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Admin
{
    public class AdminReviewModel : IAdminReviewModel
    {
        IAdminReviewPresenter presenter;

        public void register(IAdminReviewPresenter presenter)
        {
            this.presenter = presenter;
        }
    }
}
