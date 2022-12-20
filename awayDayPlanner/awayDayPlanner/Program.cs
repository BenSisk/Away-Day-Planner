using awayDayPlanner.Database;
using awayDayPlanner.GUI;
using System;
using System.Windows.Forms;
using System.Data.Entity;
using awayDayPlanner.Booking;

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


            // this will probably be moved to wherever it reads the activity list from later
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Activity1, new ActivityNormal());
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Activity2, new ActivityNormal());
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Activity3, new ActivityNormal());
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(ActivityEnum.Custom, new ActivityCustom());


            // Application.Run(FormProvider.LoginForm);
            Application.Run(FormProvider.bookingForm);
        }
    }
}