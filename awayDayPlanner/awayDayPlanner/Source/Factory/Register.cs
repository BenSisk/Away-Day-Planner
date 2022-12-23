using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using System;
using System.Collections.Generic;
using System.Linq;


// object factory used for creating user objects
namespace awayDayPlanner.Lib.Factory
{
    public class Register : IFactory, IRegister
    {
        private static Register instance = null;
        private static readonly object padlock = new object();

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

        public void createUser()
        {

        }

        private void hashPassword()

        {

        }

        private void verifyEmail()
        {
            throw new NotImplementedException();
        }

        private void verifyPhone()
        {
            throw new NotImplementedException();
        }

    }
}
