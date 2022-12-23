using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security.Salting;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static awayDayPlanner.Source.Security.Validator.Validator;

namespace awayDayPlanner.Source.Security.Validator
{
    internal class Validate
    {
        public static List<RegisterErrors> ValidateRegister(Login login, User user,
             Address address, string confirmPassword, IValidator validator)
        {
            return validator.ValidateRegister(login, user, address, confirmPassword);
        }
    }
}
