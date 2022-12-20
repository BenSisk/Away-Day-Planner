using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Activities
{
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

        public void RegisterActivity(Enum activityType, IActivity activity)
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
}
