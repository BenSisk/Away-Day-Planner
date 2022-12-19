using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI
{

    // Singleton classes for managing forms without creating and destroying contexts
    public class FormProvider
    {
        public static LoginForm LoginForm
        {
            get
            {
                if (_loginForm == null)
                {
                    var model = new Model.LoginModel();

                    _loginForm = new LoginForm();
                    _loginForm.Presenter = new LoginPresenter(_loginForm, model);
                }

                return _loginForm;
            }
        }

        public static ControlPanelForm ControlPanelForm
        {
            get
            {
                if (_controlPanel == null)
                {
                    _controlPanel = new ControlPanelForm();
                }

                return _controlPanel;
            }
        }

        public static RegisterForm RegisterForm
        {
            get
            {
                if (_registerForm == null)
                {
                    var model = new Model.RegisterModel();
                    _registerForm = new RegisterForm();
                    _registerForm.Presenter = new RegisterPresenter(_registerForm, model);
                }

                return _registerForm;
            }
        }

        private static RegisterForm _registerForm;
        private static LoginForm _loginForm;
        private static ControlPanelForm _controlPanel;
    }
}
