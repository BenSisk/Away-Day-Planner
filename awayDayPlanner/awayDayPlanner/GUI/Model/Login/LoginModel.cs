using awayDayPlanner.Lib.Users;
using System;
using System.Linq;
using System.Security.Cryptography;

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

        public void hashPassword()
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

        public void Submit(string username, string password)
        {
            string salt = userSalt(username);
            Console.WriteLine("user salt is " + salt);
        }

        public void verifyCredentials()
        {
            throw new NotImplementedException();
        }
    }
}