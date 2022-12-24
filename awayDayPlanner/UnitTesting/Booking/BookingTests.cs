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
            //test activity adding with many activities
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

            activity.Type = Type;
            activity.Name = "name";
            activity.Notes = "notes";
            newitem.activityType = Type;
            newitem.custom = "name";
            newitem.notes = "notes";
            view.date = DateTime.Now;
            model.returnValue = -1;

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);

            presenter.addActivity();
            presenter.addActivity();
            presenter.addActivity();


            presenter.submit();
            Assert.AreEqual(view.Message, "Something went wrong.");
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
            bookingModel model = new bookingModel();

            ActivityType Type = new ActivityType("Custom", 50);

            activity.Type = Type;
            activity.Name = "name";
            activity.Notes = "notes";

            int output = model.submit(new List<IActivity> { activity }, DateTime.Now);

            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void TestMethod5()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);

            ActivityMoc activity = new ActivityMoc();

            BookingPresenterMoc presenter = new BookingPresenterMoc();
            bookingModel model = new bookingModel();

            ActivityType Type = new ActivityType("Custom", 50);

            activity.Type = Type;
            activity.Name = "name";
            activity.Notes = "notes";

            int output = model.submit(new List<IActivity> { activity, activity, activity }, DateTime.Now);

            Assert.AreEqual(0, output);
        }

        [TestMethod]
        public void TestMethod6()
        {
            bookingForm view = FormProvider.bookingForm;

            Assert.AreSame(view, FormProvider.bookingForm);
        }

        [TestMethod]
        public void TestMethod7()
        {
            bookingPresenter presenter = FormProvider.bookingPresenter;

            Assert.AreSame(presenter, FormProvider.bookingPresenter);
        }

        [TestMethod]
        public void TestMethod8()
        {
            bookingModel model = FormProvider.bookingModel;

            Assert.AreSame(model, FormProvider.bookingModel);
        }
    }
}