using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace awayDayPlanner.GUI
{
    public interface IRegisterView
    {
        string firstname { get; }
        string surname { get; }
        string email { get;  }
        DateTime dob { get; }
        String phone { get; }    

        string FirstLine { get; }
        string SecondLine { get; }
        string PostCode { get; }

        string Username { get; }
        string Password { get; }
        string Password2 { get; }


        // Labels
        System.Windows.Forms.Label labelFirstName { get; set; }
        System.Windows.Forms.Label labelSecondName { get; set; }
        System.Windows.Forms.Label labelEmail { get; set; }
        System.Windows.Forms.Label labelDOB { get; set; }
        System.Windows.Forms.Label labelPhone { get; set; }
        System.Windows.Forms.Label labelFirstLine { get; set; }
        System.Windows.Forms.Label labelSecondLine { get; set; }
        System.Windows.Forms.Label labelUsername { get; set; }
        System.Windows.Forms.Label labelPassword { get; set; }

        // Tool tips

        System.Windows.Forms.ToolTip PasswordError { get; set; }
        void Message(string message);
        RegisterPresenter Presenter { set; }
    }
}
