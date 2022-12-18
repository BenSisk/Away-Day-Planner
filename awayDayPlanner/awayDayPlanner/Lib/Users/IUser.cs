using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Lib.Users
{
    internal interface IUser
    {
        int id
        {
            get; set;
        }

        string firstname
        {
            get; set;
        }

        string lastname
        { 
            get; set;
        }
        string email
        {
            get; set;
        }

        DateTime dob
        {
            get; set;
        }

        void verifyDetails();
    }
}
