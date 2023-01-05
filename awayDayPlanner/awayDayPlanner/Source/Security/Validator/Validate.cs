﻿using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;

namespace awayDayPlanner.Source.Security.Validator
{
    internal class Validate
    {
        public static Dictionary<RegisterErrors, string> ValidateRegister(ILogin login, IUser user,
             IAddress address, string confirmPassword, IValidator validator)
        {
            return validator.ValidateRegister(login, user, address, confirmPassword);
        }
    }
}
