using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
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
        public List<RegisterErrors> ValidateRegister(Login login, User user, 
            Address address, string confirmPassword)
        {
            List<RegisterErrors> AllErrors = new List<RegisterErrors>();

            AllErrors.AddRange(this.verifyUser(user));
            AllErrors.AddRange(this.verifyUsername(login));
            AllErrors.AddRange(this.verifyPassword(login, confirmPassword));

            if (AllErrors.Contains(RegisterErrors.PasswordSuccess) &&
                AllErrors.Contains(RegisterErrors.UsernameSuccess) &&
                AllErrors.Contains(RegisterErrors.PhoneSuccess) &&
                AllErrors.Contains(RegisterErrors.FirstSuccess) &&
                AllErrors.Contains(RegisterErrors.SurnameSuccess) &&
                AllErrors.Contains(RegisterErrors.EmailSuccess))
            {
                AllErrors.Clear();
                AllErrors.Add(RegisterErrors.Success);
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

        private List<RegisterErrors> verifyUsername(Login login)
        {
            List<RegisterErrors> AllErrors = new List<RegisterErrors>();
            if (this.HasSpecialChars(login.Username))
                AllErrors.Add(RegisterErrors.InvalidUsername);

            if (login.Username.Length < 5 || login.Username.Length > 25)
                AllErrors.Add(RegisterErrors.ShortUsername);

            if (UserExists(login.Username))
                AllErrors.Add(RegisterErrors.UsernameTaken);

            if (AllErrors.Count == 0)
                AllErrors.Add(RegisterErrors.UsernameSuccess);

            return AllErrors;

        }
        private List<RegisterErrors> verifyPassword(Login user, string password2)
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

        private List<RegisterErrors> verifyPhone(int number)
        {
            List<RegisterErrors> PhoneErrors = new List<RegisterErrors>();

            if (number == 0)
                PhoneErrors.Add(RegisterErrors.InvalidPhone);
            else
                PhoneErrors.Add(RegisterErrors.PhoneSuccess);

            return PhoneErrors;

        }
        private List<RegisterErrors> verifyUser(User user)
        {
            List<RegisterErrors> AllErrors = new List<RegisterErrors>();

            AllErrors.AddRange(this.verifyFirstname(user.firstname, false));
            AllErrors.AddRange(this.verifyFirstname(user.lastname, true));
            AllErrors.AddRange(this.verifyPhone(user.phone));

            if (!this.isValidEmail(user.email))
                AllErrors.Add(RegisterErrors.InvalidEmail);
            else
                AllErrors.Add(RegisterErrors.EmailSuccess);

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


    }
}
