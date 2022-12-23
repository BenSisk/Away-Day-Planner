using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;

namespace awayDayPlanner.Source.Security.Validator
{
    internal class Validate
    {
        public static Dictionary<RegisterErrors, string> ValidateRegister(Login login, User user,
             Address address, string confirmPassword, IValidator validator)
        {
            return validator.ValidateRegister(login, user, address, confirmPassword);
        }
    }
}
