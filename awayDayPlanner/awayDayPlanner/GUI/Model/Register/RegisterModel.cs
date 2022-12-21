using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model
{
    public class RegisterModel : IRegisterModel
    {

        private Register register;

        public RegisterModel()
        {
            this.register = new Register();
        }

        public void Submit(User user, Address address, Login login, string confirmPassword)
        {
            Console.WriteLine("Generated salt is" + login.Salt);
            Database.Database.Data.Address.Add(address);
            user.Address = address;
            user.Login = login;
            Database.Database.Data.User.Add(user);


            this.register.verifyCredentials(login, confirmPassword);
            Database.Database.Data.Login.Add(login);

            Database.Database.Data.SaveChanges();

        }

        public void Close()
        {
            FormProvider.LoginForm.Show();
            FormProvider.RegisterForm.Hide();
            FormProvider.RegisterForm.Reset();
        }

    }
}
