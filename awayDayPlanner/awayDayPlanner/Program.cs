using awayDayPlanner.Database;
using awayDayPlanner.GUI;
using awayDayPlanner.Booking;
using System;
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
            var db = new ADPContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new awayDayPresenter());

            var awayDayForm = FormProvider.bookingForm;
            var presenter = FormProvider.bookingPresenter;
            Application.Run(awayDayForm);

            // Test code
            // LoginForm loginForm = new LoginForm();
            // Application.Run(FormProvider.LoginForm);
        }
    }
}