using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model
{
    internal class LoginModel : ILoginModel
    {

        public LoginModel() { 
        
        }

        public void createUser()
        {
            throw new NotImplementedException();
        }

        public void deshashPassword()
        {
            throw new NotImplementedException();
        }

        public void getCredentials()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            FormProvider.RegisterForm.Show();
            FormProvider.LoginForm.Hide();
        }

        public void Close()
        {
            FormProvider.LoginForm.Close();
        }

        public void verifyCredentials()
        {
            throw new NotImplementedException();
        }
    }
}
