using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.GUI.View.AwayDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Admin
{
    public interface IAdminReviewModel
    {
        void register(IAdminReviewPresenter presenter);
    }
}
