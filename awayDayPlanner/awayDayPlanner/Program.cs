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

            //this will actually happen in the database thing I think, where it populates AcitivityEnum
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Activity1, new ActivityNormal());
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Activity2, new ActivityNormal());
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Activity3, new ActivityNormal());
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Custom, new ActivityCustom());


            Application.Run(FormProvider.bookingForm);

            // Test code
            // LoginForm loginForm = new LoginForm();
            // Application.Run(FormProvider.LoginForm);
        }
    }
}