using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Source.Activities;

namespace awayDayPlanner.GUI.View.Admin
{
    public interface IAdminReviewForm
    {
        void Register(IAdminReviewPresenter presenter);
        void Reset();
        void AddItemToDGV(ActivityType type, string name, double cost);
        DataGridViewRowCollection GetPrices();
        void Exit();
        void Message(string message, string title);
    }
}
