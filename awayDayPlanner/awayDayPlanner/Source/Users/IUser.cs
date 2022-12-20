﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Lib.Users
{
    internal interface IUser
    {
        int userID
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

        string dob
        {
            get; set;
        }
    }
}
