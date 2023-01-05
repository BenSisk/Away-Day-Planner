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
    public class Login : IFactory, Source.Factory.ILogin
    {
        [Key]
        public int loginID { get; set; }
        [Required] public String Username { get; set; }
        [Required] public String Password { get; set; }
        [Required] public String Salt { get; set; }

        private static Login instance = null;

        private Login() { }

        public static Login getInstance()
        {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
        }

        public IUser CreateUserObject()
        {
            return User.getInstance();
        }
    }
}
