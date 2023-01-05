using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Security;
using awayDayPlanner.Source.Security.Salting;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;

namespace awayDayPlanner.GUI.Model
{
    public class RegisterModel : IRegisterModel
    {

        public RegisterModel()
        {
        }

        public Dictionary<RegisterErrors, string> Submit(IUser user, IAddress address, ILogin login, string confirmPassword)
        {
            var verified = Validate.ValidateRegister(login, user, address, confirmPassword, new Validator());


            if (verified.ContainsKey(RegisterErrors.Success))
            {
                login.Salt = SaltProvider.GenerateSalt(new Salter());

                login.Password = login.Password + login.Salt;
                login.Password = HashProvider.Hash(login.Password, new SHA256Hasher());

                Database.Database.Data.Address.Add(address);
                user.Address = address;
                user.Login = login;
                Database.Database.Data.User.Add(user);
                Database.Database.Data.Login.Add(login);

                Database.Database.Data.SaveChanges();

                return verified;

            }
            return verified;
        }

        public void Close()
        {
            FormProvider.LoginForm.Show();
            FormProvider.RegisterForm.Hide();
            FormProvider.RegisterForm.Reset();
        }

    }
}
