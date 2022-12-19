using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;

namespace awayDayPlanner.Lib.Factory
{
    public class Login : IFactory, ILoginModel
    {
        [Key]
        public int loginID { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        private static Login instance = null;
        private static readonly object padlock = new object();

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

        void ILoginModel.deshashPassword()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            throw new NotImplementedException();
        }
    }
}
