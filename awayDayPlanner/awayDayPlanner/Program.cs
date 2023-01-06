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
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);


            if (!File.Exists("Database\\Database.mdf"))
            {
                MessageBox.Show("No Database found, Aborting");
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(FormProvider.LoginForm);
            }
        }
    }
}