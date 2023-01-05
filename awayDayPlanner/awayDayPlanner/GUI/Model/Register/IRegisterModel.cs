using awayDayPlanner.Lib.Factory;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Security.Validator;
using awayDayPlanner.Source.Users;
using System.Collections.Generic;

namespace awayDayPlanner.GUI.Model
{
    public interface IRegisterModel
    {
        Dictionary<RegisterErrors, string> Submit(string confirmPassword);

        void Close();
    }
}
