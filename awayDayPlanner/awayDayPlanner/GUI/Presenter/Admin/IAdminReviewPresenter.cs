using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Presenter.Admin
{
    public interface IAdminReviewPresenter
    {
        void PopulateDataGrid();
        void Submit();
    }
}
