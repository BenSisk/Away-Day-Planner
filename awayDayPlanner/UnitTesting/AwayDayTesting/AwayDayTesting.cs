using awayDayPlanner.GUI.Model.AwayDays;
using awayDayPlanner.GUI.Presenter.AwayDays;
using awayDayPlanner.GUI.View.AwayDays;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.Lib.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UnitTesting.AwayDayTesting
{
    [TestClass]
    public class AwayDayTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            AwayDayFormMoc view = new AwayDayFormMoc();
            AwayDayModelMoc model = new AwayDayModelMoc();

            IAwayDayPresenter presenter = new AwayDayPresenter(view, model);

            model.awayDayList = new List<AwayDay>();
            AwayDay awayday = new AwayDay();

            int ID = 1;
            DateTime datetime = DateTime.Now;
            bool Confirmed = false;
            bool CanBeConfirmed = false;
            double TotalCost = 20.05;
            List<Activity> activityList =  new List<Activity> { new Activity(), new Activity() };
            IUser user = User.getInstance();


            awayday.AwayDayID = ID;
            awayday.AwayDayDate = datetime;
            awayday.Confirmed = Confirmed;
            awayday.CanBeConfirmed = CanBeConfirmed;
            awayday.TotalCost = TotalCost;
            awayday.AwayDayActivities = activityList;
            awayday.User = user;

            model.awayDayList.Add(awayday);
            presenter.PopulateDataGrid();

            Assert.AreEqual(activityList.Count, view.count);
            Assert.AreEqual("Under Review", view.status);
            Assert.AreEqual(TotalCost, view.price);
            Assert.AreEqual(datetime, view.datetime);
        }

        [TestMethod]
        public void TestMethod2()
        {
            AwayDayFormMoc view = new AwayDayFormMoc();
            AwayDayModelMoc model = new AwayDayModelMoc();

            IAwayDayPresenter presenter = new AwayDayPresenter(view, model);

            model.awayDayList = new List<AwayDay>();
            AwayDay awayday = new AwayDay();

            int ID = 1;
            DateTime datetime = DateTime.Now;
            bool Confirmed = false;
            bool CanBeConfirmed = true;
            double TotalCost = 0;
            List<Activity> activityList = new List<Activity> { new Activity(), new Activity() };
            IUser user = User.getInstance();


            awayday.AwayDayID = ID;
            awayday.AwayDayDate = datetime;
            awayday.Confirmed = Confirmed;
            awayday.CanBeConfirmed = CanBeConfirmed;
            awayday.TotalCost = TotalCost;
            awayday.AwayDayActivities = activityList;
            awayday.User = user;

            model.awayDayList.Add(awayday);
            presenter.PopulateDataGrid();

            Assert.AreEqual(activityList.Count, view.count);
            Assert.AreEqual("Ready For Confirmation", view.status);
            Assert.AreEqual(TotalCost, view.price);
            Assert.AreEqual(datetime, view.datetime);
        }

        [TestMethod]
        public void TestMethod3()
        {
            AwayDayFormMoc view = new AwayDayFormMoc();
            AwayDayModelMoc model = new AwayDayModelMoc();

            IAwayDayPresenter presenter = new AwayDayPresenter(view, model);

            model.awayDayList = new List<AwayDay>();
            AwayDay awayday = new AwayDay();

            int ID = 1;
            DateTime datetime = DateTime.Today.Add(new TimeSpan(5));
            bool Confirmed = true;
            bool CanBeConfirmed = true;
            double TotalCost = -5;
            List<Activity> activityList = new List<Activity> { new Activity(), new Activity() };
            IUser user = User.getInstance();


            awayday.AwayDayID = ID;
            awayday.AwayDayDate = datetime;
            awayday.Confirmed = Confirmed;
            awayday.CanBeConfirmed = CanBeConfirmed;
            awayday.TotalCost = TotalCost;
            awayday.AwayDayActivities = activityList;
            awayday.User = user;

            model.awayDayList.Add(awayday);
            model.awayDayList.Add(awayday);
            model.awayDayList.Add(awayday);
            model.awayDayList.Add(awayday);
            presenter.PopulateDataGrid();

            Assert.AreEqual(activityList.Count, view.count);
            Assert.AreEqual("Confirmed", view.status);
            Assert.AreEqual(TotalCost, view.price);
            Assert.AreEqual(datetime, view.datetime);
        }

        [TestMethod]
        public void TestMethod4()
        {
            AwayDayFormMoc view = new AwayDayFormMoc();
            AwayDayModelMoc model = new AwayDayModelMoc();

            IAwayDayPresenter presenter = new AwayDayPresenter(view, model);

            model.awayDayList = new List<AwayDay>();
            AwayDay awayday = new AwayDay();

            int ID = 1;
            DateTime datetime = DateTime.Now;
            bool Confirmed = false;
            bool CanBeConfirmed = false;
            double TotalCost = 0;
            List<Activity> activityList = new List<Activity> { new Activity(), new Activity() };


            awayday.AwayDayID = ID;
            awayday.AwayDayDate = datetime;
            awayday.Confirmed = Confirmed;
            awayday.CanBeConfirmed = CanBeConfirmed;
            awayday.TotalCost = TotalCost;
            awayday.AwayDayActivities = activityList;


            model.awayDayList.Add(awayday);
            presenter.PopulateDataGrid();

            DataGridView grid = new DataGridView();
            grid.Columns.Add("test", "test");
            grid.Rows.Add(new DataGridViewRow());

            view.row = grid.Rows[0];
            presenter.OpenAwayDay();

            Assert.AreEqual("Error", view.title);
        }

        [TestMethod]
        public void TestMethod5()
        {
            AwayDayFormMoc view = new AwayDayFormMoc();
            AwayDayModelMoc model = new AwayDayModelMoc();

            IAwayDayPresenter presenter = new AwayDayPresenter(view, model);

            model.awayDayList = new List<AwayDay>();
            AwayDay awayday = new AwayDay();

            int ID = 1;
            DateTime datetime = DateTime.Now;
            bool Confirmed = false;
            bool CanBeConfirmed = true;
            double TotalCost = 0;
            List<Activity> activityList = new List<Activity> { new Activity(), new Activity() };


            awayday.AwayDayID = ID;
            awayday.AwayDayDate = datetime;
            awayday.Confirmed = Confirmed;
            awayday.CanBeConfirmed = CanBeConfirmed;
            awayday.TotalCost = TotalCost;
            awayday.AwayDayActivities = activityList;


            model.awayDayList.Add(awayday);
            presenter.PopulateDataGrid();

            DataGridView grid = new DataGridView();
            grid.Columns.Add("test", "test");
            grid.Rows.Add(new DataGridViewRow());

            view.row = grid.Rows[0];
            view.result = DialogResult.OK;
            presenter.OpenAwayDay();

            Assert.AreEqual(true, view.haveDisplayedForm);
            Assert.AreEqual(true, view.haveReset);
        }
    }
}