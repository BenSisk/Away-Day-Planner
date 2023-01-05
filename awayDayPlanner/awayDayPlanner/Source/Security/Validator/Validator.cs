using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Security.Validator
{
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
        SurnameSuccess,
        InvalidEmail,
        InvalidUsername,
        ShortUsername,
        UsernameTaken,
        UsernameSuccess,
        InvalidPhone,
        PhoneSuccess,
        EmailSuccess
    }
    internal class Validator : IValidator
    {
        private Dictionary<RegisterErrors, string> 
            AllErrors = new Dictionary<RegisterErrors, string>();

        public Dictionary<RegisterErrors, string> ValidateRegister(ILogin login, IUser user, 
            IAddress address, string confirmPassword)
        {
            this.verifyUser(user);
            this.verifyUsername(login);
            this.verifyPassword(login, confirmPassword);

            if (AllErrors.ContainsKey(RegisterErrors.PasswordSuccess) &&
                AllErrors.ContainsKey(RegisterErrors.UsernameSuccess) &&
                AllErrors.ContainsKey(RegisterErrors.PhoneSuccess) &&
                AllErrors.ContainsKey(RegisterErrors.FirstSuccess) &&
                AllErrors.ContainsKey(RegisterErrors.SurnameSuccess) &&
                AllErrors.ContainsKey(RegisterErrors.EmailSuccess))
            {
                AllErrors.Clear();
                AllErrors.Add(RegisterErrors.Success, "Validation succeeded");
            }

                return AllErrors;
        }

        private Boolean isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
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

        private void verifyUsername(ILogin login)
        {
            if (this.HasSpecialChars(login.Username))
                AllErrors.Add(RegisterErrors.InvalidUsername, 
                    "Username can't contain special character");

            else if (login.Username.Length < 5 || login.Username.Length > 25)
                AllErrors.Add(RegisterErrors.ShortUsername, 
                    "Username should be between 5 and 25 characters");

            else if (UserExists(login.Username))
                AllErrors.Add(RegisterErrors.UsernameTaken,
                    "Username is already taken");

            else 
                AllErrors.Add(RegisterErrors.UsernameSuccess, 
                    "Username Successful");
        }

        private void verifyPassword(ILogin user, string password2)
        {
            if (user.Password.Length >= 5 && password2.Length >= 5)
                if (this.PasswordsAreEqual(user.Password, password2))
                    AllErrors.Add(RegisterErrors.PasswordSuccess, "password successful");
                else
                    AllErrors.Add(RegisterErrors.PasswordMismatch, "Passwords don't match");
            else
                AllErrors.Add(RegisterErrors.IncorrectPasswordSize, 
                    "Passwords should be 5 or more characters");
        }

        private void verifyPhone(int number)
        {
            if (number == 0)
                AllErrors.Add(RegisterErrors.InvalidPhone, 
                    "Invalid phone number");
            else
                AllErrors.Add(RegisterErrors.PhoneSuccess,
                    "Phone success");
        }

        private void verifyUser(IUser user)
        {
            this.verifyFirstname(user.firstname, false);
            this.verifyFirstname(user.lastname, true);
            this.verifyPhone(user.phone);

            if (!this.isValidEmail(user.email))
                AllErrors.Add(RegisterErrors.InvalidEmail, "Invalid email address");
            else
                AllErrors.Add(RegisterErrors.EmailSuccess, "Email success");
        }

        private void verifyFirstname(string firstname, bool Surname)
        {
            if (firstname == null)
                if (Surname)
                    AllErrors.Add(RegisterErrors.EmptyFirstName, "Firstname can't be empty");
                else
                    AllErrors.Add(RegisterErrors.EmptySurname, "Surname can't be empty");
            // no point continuing the checks with a null name
            else
            {
                // 2 character names? Aj?
                if (firstname.Length > 50 || firstname.Length < 2)
                    if (Surname)
                        AllErrors.Add(RegisterErrors.SurnameSize, 
                            "Surname must be be 2 and 50 characters");
                    else
                        AllErrors.Add(RegisterErrors.FirstNameSize,
                            "Firstname must be be 2 and 50 characters");
                else if (this.HasSpecialChars(firstname))
                    if (Surname)
                        AllErrors.Add(RegisterErrors.SpecialCharactersSurname,
                            "Name cannot contain special characters");
                    else
                        AllErrors.Add(RegisterErrors.SpecialCharactersFirstname,
                            "Name cannot contain special characters");
                else
                    if (Surname)
                        AllErrors.Add(RegisterErrors.SurnameSuccess, "firstname success");
                    else
                        AllErrors.Add(RegisterErrors.FirstSuccess, "surname Success");
            }
        }
    }
}
