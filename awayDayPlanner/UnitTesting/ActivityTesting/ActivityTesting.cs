using awayDayPlanner.Source.Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTesting.Booking;

namespace UnitTesting.ActivityTesting
{
    [TestClass]
    public class ActivityTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            ActivityMoc activity1 = new ActivityMoc();

            ActivityType Type = new ActivityType("Hello World", 50);

            activity1.Type = Type;
            activity1.Name = "name";
            activity1.Notes = "notes";
            
            Assert.ThrowsException<KeyNotFoundException>(() => ActivityFactory.ActivityFactorySingleton.GetActivityInstance(Type));
        }

        [TestMethod]
        public void TestMethod2()
        {
            ActivityMoc activity1 = new ActivityMoc();

            ActivityType Type = new ActivityType("Hello World", 50);

            activity1.Type = Type;
            activity1.Name = "name";
            activity1.Notes = "notes";

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity1);

            Assert.AreEqual(activity1.Type, ActivityFactory.ActivityFactorySingleton.GetActivityInstance(Type).Type);
        }

        [TestMethod]
        public void TestMethod3()
        {
            ActivityFactory factory = ActivityFactory.ActivityFactorySingleton;
            Assert.AreSame(ActivityFactory.ActivityFactorySingleton, factory);
        }

        [TestMethod]
        public void TestMethod4()
        {
            ActivityType Type = new ActivityType("Hello World", 50);

            Activity activity = new Activity();
            activity.Type = Type;

            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);
            var newActivity = ActivityFactory.ActivityFactorySingleton.GetActivityInstance(Type);

            Assert.AreEqual(activity.Type, newActivity.Type);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Activity activity = new Activity();

            Assert.AreSame(activity, activity.GetObject());
        }

        [TestMethod]
        public void TestMethod6()
        {
            Activity activity = new Activity();

            Assert.AreNotSame(activity, ((IActivity)activity.Clone()));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Activity activity = new Activity();
            ActivityType Type = new ActivityType("Hello World", 50);

            activity.Type = Type;
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(Type, activity);


            var activity1 = ActivityFactory.ActivityFactorySingleton.GetActivityInstance(Type);
            var activity2 = ActivityFactory.ActivityFactorySingleton.GetActivityInstance(Type);

            activity1.Name = "name";
            activity1.Notes = "notes";
            activity1.ActualCost = 5;

            Assert.AreNotSame(activity1, activity2);
            Assert.AreNotEqual(activity1.Name, activity2.Name);
            Assert.AreNotEqual(activity1.Notes, activity2.Notes);
            Assert.AreNotEqual(activity1.ActualCost, activity2.ActualCost);
            Assert.AreEqual(activity1.Type, activity2.Type);
        }
    }
}