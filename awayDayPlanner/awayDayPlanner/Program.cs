using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new awayDayPresenter());

            awayDayForm awayDayForm = new awayDayForm();
            awayDayModel awayDayModel = new awayDayModel();
            awayDayPresenter presenter = new awayDayPresenter(awayDayForm, awayDayModel);
            Application.Run(awayDayForm);
        }
    }
}