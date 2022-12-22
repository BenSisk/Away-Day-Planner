using awayDayPlanner.Lib.Factory;
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
        void verifyUsername();
        List<RegisterErrors> verifyPassword(Login user, string password);
        void verifyEmail();
        void verifyPhone();
        List<RegisterErrors> verifyDob(DateTime birthdate);

    }
}
