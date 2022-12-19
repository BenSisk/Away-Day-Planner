using awayDayPlanner.Lib.Users;
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
        [Required] public String Firstline { get; set; } = string.Empty;
        [Required] public String SecondLine { get; set; } = string.Empty;
        [Required] public String PostCode { get; set; } = string.Empty;

        public int UserID { get; set; }
    }
}
