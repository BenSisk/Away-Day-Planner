using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Factory;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;

namespace awayDayPlanner.GUI.Model
{
    public interface IRegisterModel
    {
        Dictionary<RegisterErrors, string> Submit(IUser user, IAddress address, ILogin login, string confirmPassword);

        void Close();
    }
}
