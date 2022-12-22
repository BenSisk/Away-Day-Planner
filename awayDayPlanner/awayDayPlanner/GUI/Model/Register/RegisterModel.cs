using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security;
using awayDayPlanner.Source.Security.Salting;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static awayDayPlanner.Lib.Factory.Register;

namespace awayDayPlanner.GUI.Model
{
    public class RegisterModel : IRegisterModel
    {

        private Register register;

        public RegisterModel()
        {
            this.register = new Register();
        }

        public RegisterErrors Submit(User user, Address address, Login login, string confirmPassword)
        {
            //Console.WriteLine("Generated salt is" + login.Salt);
            //Database.Database.Data.Address.Add(address);
            //user.Address = address;
            //user.Login = login;
            //Database.Database.Data.User.Add(user);

            var verified = this.register.verifyPassword(login, confirmPassword);

            switch(verified)
            {
                case RegisterErrors.Success:
                    login.Salt = SaltProvider.GenerateSalt(new Salter());

                    login.Password = login.Password + login.Salt;
                    login.Password = HashProvider.Hash(login.Password, new SHA256Hasher());

                    user.Login = login;
                    break;
                case RegisterErrors.PasswordMismatch:
                    return RegisterErrors.PasswordMismatch;
            }

            return RegisterErrors.Success;

            //Database.Database.Data.Login.Add(login);

            //Database.Database.Data.SaveChanges();

        }

        public void Close()
        {
            FormProvider.LoginForm.Show();
            FormProvider.RegisterForm.Hide();
            FormProvider.RegisterForm.Reset();
        }

    }
}
