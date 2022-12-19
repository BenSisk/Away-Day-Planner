using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// object factory used for creating user objects
namespace awayDayPlanner.Lib.Factory
{
    internal class Register : IFactory
    {
        private static Register instance = null;
        private static readonly object padlock = new object();

        Register()
        {

        }

        public static Register getInstance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Register();
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

        private void hashPassword()

        {

        }
    }
}
