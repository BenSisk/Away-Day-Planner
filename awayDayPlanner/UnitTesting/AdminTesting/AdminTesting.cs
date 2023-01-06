using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnitTesting.AdminTesting
{
    [TestClass]
    public class AdminTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            AdminFormMoc view = new AdminFormMoc();
            AdminModelMoc model = new AdminModelMoc();

            IAdminPresenter presenter = new AdminPresenter(view, model);

            Assert.IsTrue(view.hasRegistered);
            Assert.IsTrue(model.hasRegistered);
            Assert.IsTrue(view.hasReset);
        }

        [TestMethod]
        public void TestMethod2()
        {
            AdminFormMoc view = new AdminFormMoc();
            AdminModelMoc model = new AdminModelMoc();

            IAdminPresenter presenter = new AdminPresenter(view, model);

            List<AwayDay> awayDayList = new List<AwayDay>();
            AwayDay awayday = new AwayDay();

            Activity activity1 = new Activity();
            Activity activity2 = new Activity();

            ActivityType Type1 = new ActivityType();
            Type1.ActivityTypeEstimatedPrice = 5;
            ActivityType Type2 = new ActivityType();
            Type2.ActivityTypeEstimatedPrice = 50;

            activity1.Type = Type1;
            activity2.Type = Type2;

            DateTime datetime = DateTime.Today;
            List<Activity> activityList = new List<Activity> { activity1, activity2 };


            awayday.AwayDayDate = datetime;
            awayday.AwayDayActivities = activityList;

            awayDayList.Add(awayday);
            awayDayList.Add(awayday);
            awayDayList.Add(awayday);
            awayDayList.Add(awayday);

            model.awayDayList = awayDayList;

            presenter.PopulateDataGrid();

            Assert.AreEqual(datetime, view.datetime[0]);
            Assert.AreEqual(activityList.Count, view.activityCount[0]);
            Assert.AreEqual(55, view.price[0]);
            Assert.AreEqual(awayDayList.Count, view.numberAdded);
        }

        [TestMethod]
        public void TestMethod3()
        {
            AdminFormMoc view = new AdminFormMoc();
            AdminModelMoc model = new AdminModelMoc();

            IAdminPresenter presenter = new AdminPresenter(view, model);

            List<AwayDay> awayDayList = new List<AwayDay>();
            AwayDay awayday = new AwayDay();

            Activity activity1 = new Activity();
            Activity activity2 = new Activity();

            ActivityType Type1 = new ActivityType();
            Type1.ActivityTypeEstimatedPrice = 5;
            ActivityType Type2 = new ActivityType();
            Type2.ActivityTypeEstimatedPrice = 50;

            activity1.Type = Type1;
            activity2.Type = Type2;

            DateTime datetime = DateTime.Today;
            List<Activity> activityList = new List<Activity> { activity1, activity2 };


            awayday.AwayDayDate = datetime;
            awayday.AwayDayActivities = activityList;

            awayDayList.Add(awayday);
            awayDayList.Add(awayday);
            awayDayList.Add(awayday);
            awayDayList.Add(awayday);

            model.awayDayList = awayDayList;

            presenter.PopulateDataGrid();

            DataGridView grid = new DataGridView();
            grid.Columns.Add("test", "test");
            grid.Rows.Add(new DataGridViewRow());

            view.row = grid.Rows[0];
            view.result = DialogResult.OK;

            AwayDay getawayday = presenter.GetAwayDay();

            Assert.IsNotNull(getawayday);
            Assert.AreEqual(datetime, getawayday.AwayDayDate);
            Assert.AreEqual(activityList, getawayday.AwayDayActivities);
        }
    }
}