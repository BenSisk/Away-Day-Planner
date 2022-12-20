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

        string FirstLine { get; }
        string SecondLine { get; }

        string PostCode { get; }

        RegisterPresenter Presenter { set; }
    }
}
