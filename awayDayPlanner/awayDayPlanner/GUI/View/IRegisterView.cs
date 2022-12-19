using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI
{
    public interface IRegisterView
    {
        string firstname { get; }
        string surname { get; }
        string email { get;  }
        string dob { get; }
        string phone { get; }    

        string firstline { get; }
        string secondline { get; }

        string postcode { get; }

        RegisterPresenter Presenter { set; }
    }
}
