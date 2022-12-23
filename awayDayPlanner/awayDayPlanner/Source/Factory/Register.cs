using awayDayPlanner.Lib.Users;
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
            Success,
            PasswordSuccess,
            IncorrectPasswordSize,
            PasswordMismatch,
            FirstNameSize,
            SurnameSize,
            EmptyFirstName,
            EmptySurname,
            SpecialCharactersSurname,
            SpecialCharactersFirstname,
            FirstSuccess,
            SurnameSuccess
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

        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !char.IsLetterOrDigit(ch));
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

        public List<RegisterErrors> verifyUser(User user)
        {
            List<RegisterErrors> AllErrors = new List<RegisterErrors>();

            AllErrors.AddRange(this.verifyFirstname(user.firstname, false));
            AllErrors.AddRange(this.verifyFirstname(user.lastname, true));
            return AllErrors;
        }

        private List<RegisterErrors> verifyFirstname(string firstname, bool Surname)
        {
            List<RegisterErrors> nameErrors = new List<RegisterErrors>();
            if (firstname == null)
                if (Surname)
                    nameErrors.Add(RegisterErrors.EmptyFirstName);
                else
                    nameErrors.Add(RegisterErrors.EmptySurname);
            // no point continuing the checks with a null name
            else
            {
                // 2 character names? Aj?
                if (firstname.Length > 50 || firstname.Length < 2)
                    if (Surname)
                        nameErrors.Add(RegisterErrors.SurnameSize);
                    else
                        nameErrors.Add(RegisterErrors.FirstNameSize);
                else if (this.HasSpecialChars(firstname))
                    if (Surname)
                        nameErrors.Add(RegisterErrors.SpecialCharactersSurname);
                    else
                        nameErrors.Add(RegisterErrors.SpecialCharactersFirstname);
                else
                    if (Surname)
                        nameErrors.Add(RegisterErrors.SurnameSuccess);
                    else
                        nameErrors.Add(RegisterErrors.FirstSuccess);
            }
            return nameErrors;
        }

        private void verifyEmail()
        {
            throw new NotImplementedException();
        }

        private void verifyPhone()
        {
            throw new NotImplementedException();
        }

        public List<RegisterErrors> verifyDob(DateTime birthDate)
        {
            throw new NotImplementedException();
        }
    }
}
