using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Presenter.AwayDays
{
    public interface IAwayDayPresenter
    {
        void Close();
        void PopulateDataGrid();
    }
}
