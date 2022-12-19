﻿using awayDayPlanner.Lib.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Users
{
    public class Address
    {
        [Key] public int AddressID { get; set; }
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string PostCode { get; set; }
    }
}