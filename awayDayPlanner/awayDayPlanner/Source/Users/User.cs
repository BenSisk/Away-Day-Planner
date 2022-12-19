using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Lib.Users
{
    public class User : IUser
    {
        [Key]
        public int userID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public DateTime dob { get; set; }

        public virtual Address Address { get; set; } = new Address();

        public void verifyDetails()
        {

        }
    }
}
