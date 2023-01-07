using awayDayPlanner.Lib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Users
{
    public class UserCast
    {
        public User convertInterfacetype(IUser user)
        {
            User.getInstance().userID = user.userID;
            User.getInstance().firstname = user.firstname;
            User.getInstance().lastname = user.lastname;

            User.getInstance().email = user.email;
            User.getInstance().dob = user.dob;
            User.getInstance().phone = user.phone;

            User.getInstance().Address = user.Address;

            return (User) User.getInstance();
        }

        public Address convertAddresstype(IAddress address)
        {
            Address.getInstance().AddressID = address.AddressID;
            Address.getInstance().FirstLine = address.FirstLine;
            Address.getInstance().SecondLine = address.SecondLine;
            Address.getInstance().PostCode = address.PostCode;


            return (Address)Address.getInstance();
        }
    }
}
