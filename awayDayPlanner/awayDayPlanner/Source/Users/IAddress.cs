using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Users
{
    public interface IAddress
    {
        int AddressID { get; set; }
        string FirstLine { get; set; }
        string SecondLine { get; set; }
        string PostCode { get; set; }
    }
}
