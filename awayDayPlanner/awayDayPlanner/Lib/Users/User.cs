using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Lib.Users
{
    internal class User : IUser
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public DateTime dob { get; set; }


        public void verifyDetails()
        {

        }
    }
}
