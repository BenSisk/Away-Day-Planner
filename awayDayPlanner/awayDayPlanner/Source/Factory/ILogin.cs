using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Factory
{
    public interface ILogin
    {
        int loginID { get; set; }
        String Username { get; set; }
        String Password { get; set; }
        String Salt { get; set; }
    }
}
