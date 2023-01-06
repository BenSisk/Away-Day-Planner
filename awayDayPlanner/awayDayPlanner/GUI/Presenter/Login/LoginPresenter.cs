using awayDayPlanner.GUI.Model;
using awayDayPlanner.GUI.Presenter.Login;
using awayDayPlanner.Lib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using awayDayPlanner.GUI.Model;

namespace awayDayPlanner.GUI
{
    public class LoginPresenter: ILoginPresenter
    {
        private readonly ILoginView _view;
        private readonly ILoginModel _model;

        public LoginPresenter(ILoginView view, ILoginModel model)
        {
            _view = view;
            _model = model;
        }

        public void Register()
        {
            _model.Register();
        }

        public void Close()
        {
            _model.Close();
        }

        public void Submit()
        {
            var user = _model.Submit(_view.Username, _view.Password);

            if (user is null)
                _view.Message("Invalid login details");
            else
            {
                FormProvider.ControlPanelPresenter.AdminCheck();
                FormProvider.ControlPanelForm.Show();
                FormProvider.LoginForm.Hide();
            }
        }

        public void Reset()
        {
            User.UpdateInstance(null);
        }
    }
}
