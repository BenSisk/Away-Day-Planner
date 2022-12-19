using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using awayDayPlanner.GUI.Model;

namespace awayDayPlanner.GUI
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            view.Presenter = this;
        }
    }
}
