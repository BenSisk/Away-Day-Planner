using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Lib.Users
{
    public interface IUser
    {
        int userID { get; set; }

        string firstname { get; set; }

        string lastname { get; set; }
        string email { get; set; }

        DateTime dob { get; set; }

        int phone { get; set; }
        bool isAdmin { get; }

        IAddress Address { get; set; }
        ILogin Login { get; set; }
    }
}
