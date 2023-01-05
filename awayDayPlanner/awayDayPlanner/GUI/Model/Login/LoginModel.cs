using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.Model
{
    internal class LoginModel : ILoginModel
    {

        public LoginModel() { 
        
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

        public string userSalt(string username)
        {
            var query = Database.Database.Data.Login.Where(x => x.Username == username)
                .Select(x=>x.Salt).Distinct();

            foreach (var item in query)
            {
                return item;
            }

            return null;
        }
        public User loginVerify(string username, string passwordHash)
        {
            bool PasswordsMatch = false;
            var query = Database.Database.Data.Login.Where(x => x.Username == username)
                .Select(x => x.Password).Distinct();

            foreach (var item in query)
            {
                if (item == passwordHash)
                {
                    PasswordsMatch = true;
                }
                else
                    return null;
            }

            if (PasswordsMatch)
            {
                var query2 = from User in Database.Database.Data.User
                             join login in Database.Database.Data.Login
                             on User.Login.loginID equals login.loginID
                             where login.Password == passwordHash
                             select User;

                User user = query2.FirstOrDefault();
                return user;
            }

            return null;
        }
        public User Submit(string username, string password)
        {
            
            string salt = userSalt(username);

            // if we get a null value for salt, then the user didn't exist
            // unecessary to make another query
            if (salt == null)
                return null;
            else
            {
                password = password + salt;
                password = HashProvider.Hash(password, new SHA256Hasher());

                User user = loginVerify(username, password);

                return user;
            }
        }

    }
}