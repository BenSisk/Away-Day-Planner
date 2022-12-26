using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Source.Activities;
using System.ComponentModel;

namespace awayDayPlanner.Lib.Users
{
    public class User : IUser
    {
        [Key]
        public int userID { get; set; }
        [Required]
        public string firstname { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public DateTime dob { get; set; }
        [Required]
        public int phone { get; set; }

        [Required]
        public virtual Address Address { get; set; }
        public virtual Login Login { get; set; }
        public virtual ICollection<AwayDay> AwayDays { get; set; } = new List<AwayDay>();

    }
}
