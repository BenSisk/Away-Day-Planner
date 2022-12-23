using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static awayDayPlanner.Lib.Factory.Register;

namespace awayDayPlanner.Source.Factory
{
    internal interface IRegister
    {
        List<RegisterErrors> verifyPassword(Login user, string password);
        List<RegisterErrors> verifyUser(User user);

    }
}
