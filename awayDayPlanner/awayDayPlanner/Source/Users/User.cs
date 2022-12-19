using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace awayDayPlanner.Lib.Users
{
    public class User : IUser
    {
        [Key]
        public int userID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string dob { get; set; }
        public string phone { get; set;  }

        public virtual Address Address { get; set; } = new Address();

        public void verifyDetails()
        {

        }
    }
}
