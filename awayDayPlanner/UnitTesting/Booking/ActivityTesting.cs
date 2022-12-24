using awayDayPlanner.Source.Activities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTesting.Booking
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
            
            Assert.ThrowsException<KeyNotFoundException>(() => ActivityFactory.ActivityFactorySingleton.getActivityInstance(Type));
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

            Assert.AreEqual(activity1.Type, ActivityFactory.ActivityFactorySingleton.getActivityInstance(Type).Type);
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

            Assert.AreEqual(activity.Type, activity.CreateActivity().Type);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Activity activity = new Activity();

            Assert.AreSame(activity, activity.getObject());
        }

        [TestMethod]
        public void TestMethod6()
        {
            Activity activity = new Activity();

            Assert.AreNotSame(activity, activity.CreateActivity());
        }

        [TestMethod]
        public void TestMethod7()
        {
            Activity activity = new Activity();
            ActivityType Type = new ActivityType("Hello World", 50);

            activity.Type = Type;
            activity.Name = "name";
            activity.Notes = "notes";
            activity.ActualCost = 50;
            
            Assert.AreNotSame(activity, activity.CreateActivity());
            Assert.AreNotEqual(activity.Name, activity.CreateActivity().Name);
            Assert.AreNotEqual(activity.Notes, activity.CreateActivity().Notes);
            Assert.AreNotEqual(activity.ActualCost, activity.CreateActivity().ActualCost);
            Assert.AreEqual(activity.Type, activity.CreateActivity().Type);
        }
    }
}