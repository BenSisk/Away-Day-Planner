using awayDayPlanner.Database;
using awayDayPlanner.GUI;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using awayDayPlanner.Source.Activities;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

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
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);

/*
            Database.Database.Data.ActivityOptions.Add(new ActivityType("activity1", 25));
            Database.Database.Data.ActivityOptions.Add(new ActivityType("GONK", 10));
            Database.Database.Data.SaveChanges();
*/

            // Application.Run(FormProvider.LoginForm);
            Application.Run(FormProvider.ControlPanelForm);
        }
    }
}