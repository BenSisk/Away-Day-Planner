using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Lib.Factory
{
    internal interface IIFactory
    {
        void getInstance();
        void getCredentials();
        void verifyCredentials();
        void createUser();

    }
}

