using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;

namespace awayDayPlanner.Lib.Factory
{
    internal class Login : IFactory
    {
        private static Login instance = null;
        private static readonly object padlock = new object();

        [Key]
        private int loginID;
        private String username = null;
        private String password = null;

        public virtual ICollection<User> User { get; set; }

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
