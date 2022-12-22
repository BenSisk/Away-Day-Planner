using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Factory
{
    internal interface IRegister
    {
        void verifyUsername();
        void verifyPassword();
        void verifyEmail();
        void verifyPhone();
        void verifyDob();

    }
}
