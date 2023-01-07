using awayDayPlanner.GUI;
using awayDayPlanner.GUI.Model.Booking;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using awayDayPlanner.GUI.View.Booking;
using UnitTesting.ActivityTesting;
using UnitTesting.ValidatorTests;
using awayDayPlanner.Lib.Users;
using awayDayPlanner.Source.Users;

namespace UnitTesting.Booking
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test activity adding with 1 activity
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            BookingFormMoc view = new BookingFormMoc();
            BookingModelMoc model = new BookingModelMoc();

            AddNewItemMoc newitem = new AddNewItemMoc();
            ActivityMoc activity = new ActivityMoc();

            BookingPresenter presenter = new BookingPresenter(view, model, newitem);

            ActivityType Type = new ActivityType("Hello World", 50);

            activity.Type = Type;
            newitem.activityType = Type;
            newitem.custom = "name";
            newitem.notes = "notes";

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);

            presenter.AddActivity();

            CollectionAssert.AreEqual(new List<string> { "name" }, view.names);
            CollectionAssert.AreEqual(new List<string> { "notes" }, view.notes);
            CollectionAssert.AreEqual(new List<double> { 50 }, view.prices);
            Assert.AreEqual("Hello World", activity.Type.ActivityTypeName);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //test activity adding with many activities
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            BookingFormMoc view = new BookingFormMoc();
            BookingModelMoc model = new BookingModelMoc();

            AddNewItemMoc newitem = new AddNewItemMoc();
            ActivityMoc activity = new ActivityMoc();

            BookingPresenter presenter = new BookingPresenter(view, model, newitem);

            ActivityType Type = new ActivityType("Hello World", 50);

            activity.Type = Type;
            newitem.activityType = Type;
            newitem.custom = "name";
            newitem.notes = "notes";

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);

            presenter.AddActivity();
            presenter.AddActivity();
            presenter.AddActivity();

            CollectionAssert.AreEqual(new List<string> { "name", "name", "name" }, view.names);
            CollectionAssert.AreEqual(new List<string> { "notes", "notes", "notes" }, view.notes);
            CollectionAssert.AreEqual(new List<double> { 50, 50, 50 }, view.prices);
            Assert.AreEqual("Hello World", activity.Type.ActivityTypeName);
        }

        [TestMethod]
        public void TestMethod3()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            BookingFormMoc view = new BookingFormMoc();
            BookingModelMoc model = new BookingModelMoc();

            AddNewItemMoc newitem = new AddNewItemMoc();
            ActivityMoc activity = new ActivityMoc();

            BookingPresenter presenter = new BookingPresenter(view, model, newitem);

            ActivityType Type = new ActivityType("Hello World", 50);

            activity.Type = Type;
            activity.Name = "name";
            activity.Notes = "notes";
            newitem.activityType = Type;
            newitem.custom = "name";
            newitem.notes = "notes";
            view.date = DateTime.Now;
            model.returnValue = -1;

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);

            presenter.AddActivity();
            presenter.AddActivity();
            presenter.AddActivity();


            presenter.Submit();
            Assert.AreEqual(view.message_txt, "Something went wrong.");
            Assert.AreEqual(3, model.mocActivities.Count);
            Assert.AreEqual(Type, model.mocActivities.First().Type);

            foreach (var item in model.mocActivities)
            {
                Assert.AreEqual("name", item.Name);
                Assert.AreEqual("notes", item.Notes);
                Assert.AreEqual(Type, item.Type);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            ActivityMoc activity = new ActivityMoc();

            BookingPresenterMoc presenter = new BookingPresenterMoc();
            BookingModel model = new BookingModel();

            ActivityType Type = new ActivityType("Custom", 50);

            activity.Type = Type;
            activity.Name = "name";
            activity.Notes = "notes";

            IUser user = new UserMock();
            int output = model.Submit(new List<IActivity> { activity }, DateTime.Now, user);

            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void TestMethod5()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            ActivityMoc activity = new ActivityMoc();

            BookingPresenterMoc presenter = new BookingPresenterMoc();
            BookingModel model = new BookingModel();

            ActivityType Type = new ActivityType("Custom", 50);

            activity.Type = Type;
            activity.Name = "name";
            activity.Notes = "notes";

            IUser user = new UserMock();
            int output = model.Submit(new List<IActivity> { activity, activity, activity }, DateTime.Now, user);

            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void TestMethod6()
        {
            BookingForm view = FormProvider.BookingForm;

            Assert.AreSame(view, FormProvider.BookingForm);
        }

        [TestMethod]
        public void TestMethod7()
        {
            BookingPresenter presenter = FormProvider.BookingPresenter;

            Assert.AreSame(presenter, FormProvider.BookingPresenter);
        }

        [TestMethod]
        public void TestMethod8()
        {
            BookingModel model = FormProvider.BookingModel;

            Assert.AreSame(model, FormProvider.BookingModel);
        }
    }
}