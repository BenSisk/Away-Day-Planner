using awayDayPlanner.Lib.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model
{
    public interface ILoginModel
    {
        void Register();

        void Close();

        User Submit(string username, string password);
    }
}
