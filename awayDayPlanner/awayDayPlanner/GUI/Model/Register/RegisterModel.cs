using awayDayPlanner.Lib.Factory;
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
        private static RegisterModel instance = null;

        public RegisterModel() {}

        public static RegisterModel getInstance()
        {
            if (instance == null) 
                instance = new RegisterModel();
            return instance;
        }
               

        public Dictionary<RegisterErrors, string> Submit(string confirmPassword, IUser user, ILogin login, IAddress address)
        {
            if (user is null || login is null || address is null)
                return null;

            var verified = Validate.ValidateRegister(login,
                                                     user,
                                                     address,
                                                     confirmPassword, new Validator());


            if (verified.ContainsKey(RegisterErrors.Success))
            {
                login.Salt = SaltProvider.GenerateSalt(new Salter());

                login.Password = login.Password + login.Salt;
                login.Password = HashProvider.Hash(login.Password, new SHA256Hasher());

                Database.Database.Data.Address.Add((Address)address);
                user.Address = address;
                user.Login = (Login)login;
                Database.Database.Data.User.Add((User)user);
                Database.Database.Data.Login.Add((Login)login);

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
