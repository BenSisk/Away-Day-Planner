using awayDayPlanner.GUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI
{
    public class RegisterPresenter
    {
        private readonly IRegisterView _view;
        private readonly IRegisterModel _model;

        public RegisterPresenter(IRegisterView view, IRegisterModel model)
        {
            _view = view;
            view.Presenter = this;
            _model = model;
        }

        public void Submit()
        {
            _model.Submit();
        }
    }
}
