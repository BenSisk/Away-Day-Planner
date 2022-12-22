using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using awayDayPlanner.GUI.Model;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;

namespace awayDayPlanner.Lib.Factory
{
    public class Login : ILoginModel
    {
        [Key]
        public int loginID { get; set; }
        [Required] public String Username { get; set; }
        [Required] public String Password { get; set; }
        [Required] public String Salt { get; set; }

        private static Login instance = null;
        private static readonly object padlock = new object();

        public Login()
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

        public void verifyCredentials(Login login)
        {

        }

        public void createUser()
        {

        }

        public void Register()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Submit()
        { throw new NotImplementedException(); }

        public void hashPassword()
        {
            throw new NotImplementedException();
        }
    }
}
