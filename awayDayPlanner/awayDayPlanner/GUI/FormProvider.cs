using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI
{
    public class FormProvider
    {
        public static LoginForm LoginForm
        {
            get
            {
                if (_loginForm == null)
                {
                    _loginForm = new LoginForm();
                }

                return _loginForm;
            }
        }

        public static RegisterForm RegisterForm
        {
            get
            {
                if (_registerForm == null)
                {
                    _registerForm = new RegisterForm();
                }

                return _registerForm;
            }
        }
        private static RegisterForm _registerForm;
        private static LoginForm _loginForm;
    }
}
