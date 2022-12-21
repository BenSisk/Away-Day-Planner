using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Lib.Factory
{
    internal interface IFactory
    {
        void verifyCredentials();
        void createUser();

    }
}

