using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model
{
    public interface ILoginModel
    {
        void verifyCredentials();

        void createUser();

        void deshashPassword();

        void Register();

        void Close();

        void Submit();
    }
}
