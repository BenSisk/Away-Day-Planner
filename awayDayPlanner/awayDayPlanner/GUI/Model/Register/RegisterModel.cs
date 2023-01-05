using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Security;
using awayDayPlanner.Source.Security.Salting;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static awayDayPlanner.Source.Security.Validator.Validator;

namespace awayDayPlanner.GUI.Model
{
    public class RegisterModel : IRegisterModel
    {
        private static RegisterModel instance = null;

        private RegisterModel() {}

        public static RegisterModel getInstance()
        {
            if (instance == null) 
                instance = new RegisterModel();

            return instance;
        }
               

        public Dictionary<RegisterErrors, string> Submit(string confirmPassword)
        {
            Login login = Login.getInstance();
            User user =User.getInstance();
            Address address = Address.getInstance();

            var verified = Validate.ValidateRegister(login,
                                                     user,
                                                     address,
                                                     confirmPassword, new Validator());


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
