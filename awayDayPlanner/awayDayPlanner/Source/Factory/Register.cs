using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Security;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IncorrectPasswordSize = 1,
            PasswordMismatch = 2
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

        public RegisterErrors verifyPassword(Login user, string password2)
        {
            if (user.Password.Length >= 5 && password2.Length >=5)
                if (this.PasswordsAreEqual(user.Password, password2))
                    return RegisterErrors.Success;
                else
                    return RegisterErrors.PasswordMismatch;
            else
                return RegisterErrors.IncorrectPasswordSize;
            
           /* if (user.Username.Length > 3 && user.Username.Length <= 50)
            {

                if (this.UserExists(user.Username))
                    Console.WriteLine("Username already taken");
                else
                {
                    if (this.PasswordsAreEqual(user.Password, password2))
                    {
                        Console.WriteLine("Pass word is: " + user.Password);
                        Console.WriteLine("Saltword is: " + user.Salt);

                        user.Password = user.Password + user.Salt;
                        user.Password = HashProvider.Hash(user.Password, new SHA256Hasher());

                        Console.WriteLine("Salted password hash is: " + user.Password);

                    }
                }
            }
            else
            {
                Console.WriteLine("Username must be between 3 and 50 characters");
            }*/
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

        public void verifyDob()
        {
            throw new NotImplementedException();
        }
    }
}
