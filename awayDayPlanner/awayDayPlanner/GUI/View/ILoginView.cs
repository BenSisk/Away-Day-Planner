using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI
{
    public interface ILoginView
    {
        string userName { get;}
        string password { get;}

        LoginPresenter Presenter { set; }
    }
}
