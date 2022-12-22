using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static awayDayPlanner.Lib.Factory.Register;

namespace awayDayPlanner.GUI.Model
{
    public interface IRegisterModel
    {
        List<RegisterErrors> Submit(User user, Address address, Login login, string confirmPassword);

        void Close();
    }
}
