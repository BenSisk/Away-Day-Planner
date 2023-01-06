using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.ValidatorTests
{
    internal class UserMock : IUser
    {
        public int userID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public DateTime dob { get; set; }
        public int phone { get; set; }
        public bool isAdmin { get; set; } = false;
        public Login Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAddress Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<AwayDay> AwayDay { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public UserMock() 
        {
            this.userID = 1;
            this.firstname = "1";
            this.lastname = "2";
            this.email = "email";
            this.isAdmin = true;
            this.dob = DateTime.Now;
            this.phone = 10;
        }
    }
}
