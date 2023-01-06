using System;
using System.ComponentModel.DataAnnotations;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;

namespace awayDayPlanner.Lib.Factory
{
    public class Login : ILogin
    {
        [Key]
        public int loginID { get; set; }
        [Required] public String Username { get; set; }
        [Required] public String Password { get; set; }
        [Required] public String Salt { get; set; }

        private static Login instance = null;

        private Login() { }

        public static ILogin getInstance()
        {
                if (instance == null)
                {
                    instance = new Login();
                }
                return instance;
        }
    }
}
