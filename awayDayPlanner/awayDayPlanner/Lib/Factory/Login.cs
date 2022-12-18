using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Lib.Factory;

namespace awayDayPlanner.Lib.Factory
{
    internal class Login : IFactory
    {
        private static Login instance = null;
        private static readonly object padlock = new object();

        Login()
        {

        }

        public static Login getInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Login();
                    }
                    return instance;
                }
            }
        }

        public void getCredentials()
        { 

        }

        public void verifyCredentials()
        { 

        }

        public void createUser()
        {

        }

        private void deshashPassword()

        {

        }
    }
}
