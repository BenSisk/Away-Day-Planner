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
using UnitTesting.ValidatorTests;

namespace UnitTesting.Booking
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
        public virtual Address Address { get; set; }
        public virtual Login Login { get; set; }
        public ICollection<AwayDay> AwayDay { get; set; }

        public UserMock() 
        {
            this.userID = 1;
            this.firstname = "1";
            this.lastname = "2";
            this.email = "email";
            this.isAdmin = true;
            this.dob = DateTime.Now;
            this.phone = 10;

            IAddress address = new AddressMock();
            UserCast castthis = new UserCast();
            this.Address = castthis.convertAddresstype(address);
        }
    }
}
