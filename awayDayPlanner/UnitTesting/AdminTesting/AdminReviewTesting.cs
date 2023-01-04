using System;
using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Source.Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTesting.AdminTesting
{
    [TestClass]
    public class AdminReviewTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            AdminReviewFormMoc reviewView = new AdminReviewFormMoc();
            AdminFormMoc adminView = new AdminFormMoc();
            AdminModelMoc adminModel = new AdminModelMoc();
            AdminPresenterMoc adminPresenter = new AdminPresenterMoc();
            IAdminReviewPresenter reviewPresenter = new AdminReviewPresenter(reviewView, adminView, adminPresenter);

            Assert.IsTrue(reviewView.hasRegistered);
            Assert.IsTrue(reviewView.hasReset);
        }

        [TestMethod]
        public void TestMethod2()
        {
            AdminReviewFormMoc reviewView = new AdminReviewFormMoc();
            AdminFormMoc adminView = new AdminFormMoc();
            AdminModelMoc adminModel = new AdminModelMoc();
            AdminPresenterMoc adminPresenter = new AdminPresenterMoc();
            IAdminReviewPresenter reviewPresenter = new AdminReviewPresenter(reviewView, adminView, adminPresenter);

            AwayDay awayday = new AwayDay();

            Activity activity1 = new Activity();
            Activity activity2 = new Activity();

            ActivityType Type1 = new ActivityType();
            double price1 = 5;
            double price2 = 50;
            Type1.ActivityTypeEstimatedPrice = price1;
            ActivityType Type2 = new ActivityType();
            Type2.ActivityTypeEstimatedPrice = price2;

            string test1 = "test1";
            string test2 = "test2";
            activity1.Type = Type1;
            activity1.Name = test1;
            activity2.Type = Type2;
            activity2.Name = test2;

            DateTime datetime = DateTime.Today;
            List<Activity> activityList = new List<Activity> { activity1, activity2 };


            awayday.AwayDayDate = datetime;
            awayday.AwayDayActivities = activityList;

            adminPresenter.awayday = awayday;

            reviewPresenter.PopulateDataGrid();
            Assert.AreEqual(Type1, reviewView.typeList[0]);
            Assert.AreEqual(test1, reviewView.nameList[0]);
            Assert.AreEqual(price1, reviewView.priceList[0]);
            Assert.AreEqual(Type2, reviewView.typeList[1]);
            Assert.AreEqual(test2, reviewView.nameList[1]);
            Assert.AreEqual(price2, reviewView.priceList[1]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            AdminReviewFormMoc reviewView = new AdminReviewFormMoc();
            AdminFormMoc adminView = new AdminFormMoc();
            AdminModelMoc adminModel = new AdminModelMoc();
            AdminPresenterMoc adminPresenter = new AdminPresenterMoc();
            IAdminReviewPresenter reviewPresenter = new AdminReviewPresenter(reviewView, adminView, adminPresenter);

            DataGridView grid = new DataGridView();
            grid.Columns.Add("Actual Cost", "Actual Cost");
            grid.Rows.Add(new DataGridViewRow());
            grid.Rows.Add(new DataGridViewRow());
            grid.Rows.Add(new DataGridViewRow());

            grid.Rows[0].Cells[0].Value = 5;
            grid.Rows[1].Cells[0].Value = 50;
            grid.Rows[2].Cells[0].Value = 500;
            grid.Rows[3].Cells[0].Value = 5000;

            reviewView.rowCollection = grid.Rows;

            AwayDay awayday = new AwayDay();

            Activity activity1 = new Activity();
            Activity activity2 = new Activity();

            ActivityType Type1 = new ActivityType();
            double price1 = 5;
            double price2 = 50;
            Type1.ActivityTypeEstimatedPrice = price1;
            ActivityType Type2 = new ActivityType();
            Type2.ActivityTypeEstimatedPrice = price2;

            string test1 = "test1";
            string test2 = "test2";
            activity1.Type = Type1;
            activity1.Name = test1;
            activity2.Type = Type2;
            activity2.Name = test2;

            DateTime datetime = DateTime.Today;
            List<Activity> activityList = new List<Activity> { activity1, activity2 };


            awayday.AwayDayDate = datetime;
            awayday.AwayDayActivities = activityList;

            adminPresenter.awayday = awayday;

            reviewPresenter.PopulateDataGrid();
            reviewPresenter.Submit();

            Assert.IsTrue(adminView.hasReset);
            Assert.IsTrue(reviewView.hasExit);
        }

        [TestMethod]
        public void TestMethod4()
        {
            AdminReviewFormMoc reviewView = new AdminReviewFormMoc();
            AdminFormMoc adminView = new AdminFormMoc();
            AdminModelMoc adminModel = new AdminModelMoc();
            AdminPresenterMoc adminPresenter = new AdminPresenterMoc();
            IAdminReviewPresenter reviewPresenter = new AdminReviewPresenter(reviewView, adminView, adminPresenter);

            DataGridView grid = new DataGridView();
            grid.Columns.Add("Actual Cost", "Actual Cost");
            grid.Rows.Add(new DataGridViewRow());
            grid.Rows.Add(new DataGridViewRow());
            grid.Rows.Add(new DataGridViewRow());

            grid.Rows[0].Cells[0].Value = 5;
            grid.Rows[1].Cells[0].Value = 50;
            grid.Rows[2].Cells[0].Value = 500;
            grid.Rows[3].Cells[0].Value = "asd";

            reviewView.rowCollection = grid.Rows;

            AwayDay awayday = new AwayDay();

            Activity activity1 = new Activity();
            Activity activity2 = new Activity();

            ActivityType Type1 = new ActivityType();
            double price1 = 5;
            double price2 = 50;
            Type1.ActivityTypeEstimatedPrice = price1;
            ActivityType Type2 = new ActivityType();
            Type2.ActivityTypeEstimatedPrice = price2;

            string test1 = "test1";
            string test2 = "test2";
            activity1.Type = Type1;
            activity1.Name = test1;
            activity2.Type = Type2;
            activity2.Name = test2;

            DateTime datetime = DateTime.Today;
            List<Activity> activityList = new List<Activity> { activity1, activity2 };


            awayday.AwayDayDate = datetime;
            awayday.AwayDayActivities = activityList;

            adminPresenter.awayday = awayday;

            reviewPresenter.PopulateDataGrid();
            reviewPresenter.Submit();

            Assert.AreEqual("Error", reviewView.title);
            Assert.AreEqual("Invalid Price", reviewView.text);
        }

        [TestMethod]
        public void TestMethod5()
        {
            AdminReviewFormMoc reviewView = new AdminReviewFormMoc();
            AdminFormMoc adminView = new AdminFormMoc();
            AdminModelMoc adminModel = new AdminModelMoc();
            AdminPresenterMoc adminPresenter = new AdminPresenterMoc();
            IAdminReviewPresenter reviewPresenter = new AdminReviewPresenter(reviewView, adminView, adminPresenter);

            DataGridView grid = new DataGridView();
            grid.Columns.Add("Actual Cost", "Actual Cost");
            grid.Rows.Add(new DataGridViewRow());
            grid.Rows.Add(new DataGridViewRow());
            grid.Rows.Add(new DataGridViewRow());

            grid.Rows[0].Cells[0].Value = 5;
            grid.Rows[1].Cells[0].Value = 50;
            grid.Rows[2].Cells[0].Value = 500;
            grid.Rows[3].Cells[0].Value = -5;

            reviewView.rowCollection = grid.Rows;

            AwayDay awayday = new AwayDay();

            Activity activity1 = new Activity();
            Activity activity2 = new Activity();

            ActivityType Type1 = new ActivityType();
            double price1 = 5;
            double price2 = 50;
            Type1.ActivityTypeEstimatedPrice = price1;
            ActivityType Type2 = new ActivityType();
            Type2.ActivityTypeEstimatedPrice = price2;

            string test1 = "test1";
            string test2 = "test2";
            activity1.Type = Type1;
            activity1.Name = test1;
            activity2.Type = Type2;
            activity2.Name = test2;

            DateTime datetime = DateTime.Today;
            List<Activity> activityList = new List<Activity> { activity1, activity2 };


            awayday.AwayDayDate = datetime;
            awayday.AwayDayActivities = activityList;

            adminPresenter.awayday = awayday;

            reviewPresenter.PopulateDataGrid();
            reviewPresenter.Submit();

            Assert.AreEqual("Error", reviewView.title);
            Assert.AreEqual("Invalid Price", reviewView.text);
        }
    }
}