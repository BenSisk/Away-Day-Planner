using awayDayPlanner.Lib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Presenter.Login
{
    public interface ILoginPresenter
    {
        void Register();
        void Close();
        void Submit();
        void Reset();
    }
}
