using awayDayPlanner.GUI;
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.Source.Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace UnitTesting.Booking
{
    [TestClass]
    public class BookingTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            BookingFormMoc view = new BookingFormMoc();
            BookingModelMoc model = new BookingModelMoc();

            AddNewItemMoc newitem = new AddNewItemMoc();
            ActivityMoc activity = new ActivityMoc();

            bookingPresenter presenter = new bookingPresenter(view, model, newitem);

            ActivityType Type = new ActivityType("Hello World", 50);

            activity.Type = Type;
            newitem.activityType = Type;
            newitem.custom = "name";
            newitem.notes = "notes";

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);

            presenter.addActivity();

            Console.WriteLine(view.names);

            CollectionAssert.AreEqual(new List<string> { "name" }, view.names);
            CollectionAssert.AreEqual(new List<string> { "notes" }, view.notes);
            CollectionAssert.AreEqual(new List<double> { 50 }, view.prices);
            Assert.AreEqual("Hello World", activity.Type.ActivityTypeName);
        }

        [TestMethod]
        public void TestMethod2()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            BookingFormMoc view = new BookingFormMoc();
            BookingModelMoc model = new BookingModelMoc();

            AddNewItemMoc newitem = new AddNewItemMoc();
            ActivityMoc activity = new ActivityMoc();

            bookingPresenter presenter = new bookingPresenter(view, model, newitem);

            ActivityType Type = new ActivityType("Hello World", 50);

            activity.Type = Type;
            newitem.activityType = Type;
            newitem.custom = "name";
            newitem.notes = "notes";

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);

            presenter.addActivity();
            presenter.addActivity();
            presenter.addActivity();

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

            bookingPresenter presenter = new bookingPresenter(view, model, newitem);

            ActivityType Type = new ActivityType("Hello World", 50);
            List<IActivity> list = new List<IActivity>{ activity, activity, activity };

            activity.Type = Type;
            newitem.activityType = Type;
            newitem.custom = "name";
            newitem.notes = "notes";
            view.date = DateTime.Now;

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);

            presenter.addActivity();
            presenter.addActivity();
            presenter.addActivity();

            presenter.submit();

            CollectionAssert.AreEqual(list, model.mocActivities);
        }
    }
}
