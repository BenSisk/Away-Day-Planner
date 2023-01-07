using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security;
using awayDayPlanner.Source.Users;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace awayDayPlanner.GUI.Model
{
    public class LoginModel : ILoginModel
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
        public IUser loginVerify(string username, string passwordHash)
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

                IUser user = query2.FirstOrDefault();
                return user;
            }

            return null;
        }

        private Address getUserAddress(IUser user)
        {
            var addressID = from User in Database.Database.Data.User
                            where User.userID == user.userID
                            select User.Address.AddressID;

            int address1 = addressID.FirstOrDefault();

            var query2 = from User in Database.Database.Data.User
                             join Address in Database.Database.Data.Address
                             on User.Address.AddressID equals Address.AddressID
                             where Address.AddressID == address1
                             select Address;
            Address address = query2.FirstOrDefault();

            return address;
        }
        public IUser Submit(string username, string password)
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
                IUser user = loginVerify(username, password);
                user.Address = getUserAddress(user);
                User.UpdateInstance(user);
                return user;
            }
        }

    }
}