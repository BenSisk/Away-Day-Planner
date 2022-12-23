using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;

namespace awayDayPlanner.Source.Security.Validator
{
    internal interface IValidator
    {
        Dictionary<RegisterErrors, string> ValidateRegister(Login login, User user, Address address, string confirmPassword);
    }
}
