using awayDayPlanner.Source.Factory;
using System;
using System.Collections.Generic;
using System.Linq;


// object factory used for creating user objects
namespace awayDayPlanner.Lib.Factory
{
    public class Register : IFactory, IRegister
    {
        private static Register instance = null;
        private static readonly object padlock = new object();

        public enum RegisterErrors
        {
            Success = 0,
            PasswordSuccess = 1,
            IncorrectPasswordSize = 2,
            PasswordMismatch = 3
        }

        public static Register getInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Register();
                    }
                    return instance;
                }
            }
        }

        private Boolean PasswordsAreEqual(string password, string confirmPassword)
        {
            if (password.Equals(confirmPassword))
                return true;
            else
                return false;
        }


        private Boolean UserExists(string user)
        {
            return Database.Database.Data.Login.Any(c => c.Username == user);
        }

        public List<RegisterErrors> verifyPassword(Login user, string password2)
        {
            List<RegisterErrors> AllErrors = new List<RegisterErrors>();

            if (user.Password.Length >= 5 && password2.Length >= 5)
                if (this.PasswordsAreEqual(user.Password, password2))
                    AllErrors.Add(RegisterErrors.PasswordSuccess);
                else
                    AllErrors.Add(RegisterErrors.PasswordMismatch);
            else
                AllErrors.Add(RegisterErrors.IncorrectPasswordSize);

            return AllErrors;
        }

        public void createUser()
        {

        }

        private void hashPassword()

        {

        }

        public void verifyUsername()
        {
            throw new NotImplementedException();
        }

        public void verifyPassword()
        {
            throw new NotImplementedException();
        }

        public void verifyEmail()
        {
            throw new NotImplementedException();
        }

        public void verifyPhone()
        {
            throw new NotImplementedException();
        }

        public List<RegisterErrors> verifyDob(DateTime birthDate)
        {
            throw new NotImplementedException();
        }
    }
}
