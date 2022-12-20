using awayDayPlanner.Booking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Booking
{
    public enum ActivityEnum
    {
        Activity1,
        Activity2,
        Activity3,
        Custom
    }

    public class ActivityFactory
    {
        private static ActivityFactory _activityFactory;
        private Hashtable ActivityMapping = new Hashtable();
        #region Singleton Instantiation
        public static ActivityFactory ActivityFactorySingleton
        {
            get
            {
                if (_activityFactory == null)
                {
                    _activityFactory = new ActivityFactory();
                }
                return _activityFactory;
            }
        }
        #endregion

        public void RegisterActivity (Enum activityType, IActivity activity)
        {
            if (!ActivityMapping.ContainsKey(activityType))
            {
                ActivityMapping.Add(activityType, activity);
            }
        }

        public IActivity getActivityInstance(Enum activityType)
        {
            IActivity activity = null;
            if (ActivityMapping.ContainsKey(activityType))
            {
                activity = (IActivity)ActivityMapping[activityType];
                return activity.CreateActivity();
            }
            throw new Exception();
        }
    }


    public abstract class Activity : IActivity
    {
        public Enum Type { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public double EstimatedCost { get; set; }
        public abstract void RegisterActivity();
        public abstract IActivity CreateActivity();
    }

    public class ActivityNormal : Activity
    {
        override public void RegisterActivity()
        {
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(this.Type, new ActivityNormal());
        }

        override public IActivity CreateActivity()
        {
            return new ActivityNormal();
        }
    }

    public class ActivityCustom : Activity
    {
        public ActivityCustom()
        {
            this.EstimatedCost = 0;
        }

        override public void RegisterActivity()
        {
            ActivityFactory.ActivityFactorySingleton.RegisterActivity(this.Type, new ActivityCustom());
        }

        override public IActivity CreateActivity()
        {
            return new ActivityCustom();
        }
    }

    public interface IActivity
    {
        Enum Type { get; set; }
        string Name { get; set; }
        string Notes { get; set; }
        double EstimatedCost { get; set; }
        void RegisterActivity();
        IActivity CreateActivity();
    }
}