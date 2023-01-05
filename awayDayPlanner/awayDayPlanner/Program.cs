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

            Application.Run(FormProvider.LoginForm);

        }
    }
}