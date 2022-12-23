using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;

namespace awayDayPlanner.GUI.Model
{
    public interface IRegisterModel
    {
        List<RegisterErrors> Submit(User user, Address address, Login login, string confirmPassword);

        void Close();
    }
}
