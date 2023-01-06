using awayDayPlanner.Source.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.ValidatorTests
{
    internal class LoginMock: ILogin
    {
        public int loginID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Salt { get; set; }

        public LoginMock()
        {
            this.loginID = 1;
            this.Username = "admin";
            this.Password = "admin";

            this.Salt = "admin";
        }
    }
}
