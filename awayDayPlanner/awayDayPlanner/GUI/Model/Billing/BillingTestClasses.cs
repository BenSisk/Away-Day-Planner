using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Billing
{
    public class AwayDay
    {
        public int AwayDayID = 1;
        public DateTime AwayDayDate = DateTime.Now;
        public bool Confirmed = true;
        public double TotalCost = 13.45;
        public ICollection<Activity> AwayDayActivities = new List<Activity>();
        public User User = new User();

        public AwayDay()
        {
            AwayDayActivities.Add(new Activity(1));
            AwayDayActivities.Add(new Activity(2));
            AwayDayActivities.Add(new Activity(3));
        }

    }

    public class Activity
    {

        public int ActivityID;
        public ActivityType ActivityType = new ActivityType();
        public string Name = "Woods";
        public string Notes = "";
        public double EstimatedCost = 13.42;
        public double ActualCost = 20.00;

        public Activity (int ID)
        {
            ActivityID = ID;
        }

    }

    public class ActivityType
    {
        public int ActivityTypeID = 1;
        public string ActivityTypeName = "thing";
        public double ActivityTypeEstimatedPrice = 13.42;

    }


    public class User
    {
        public int userID = 1;
        public string firstname = "firstname";
        public string lastname = "lastname";
        public string email = "email";
        public DateTime dob = DateTime.Now;
        public string phone = "phone";
        public Address Address = new Address();

    }

    public class Address
    {
        public int AddressID = 1;
        public string FirstLine = "firstLine";
        public string SecondLine = "SecondLine";
        public string PostCode = "PostCode";
    }

    // awayday.User.Address.FirstLine
    // awayday.AwayDayActivities.first().ActivityType.ActivityTypeName

    // AwayDayActivities is a list, use a for loop to iterate over
    //  //fornoneconfirmed
    //  foreach(var Activity in awayday.AwayDayActivities)
    //  {
    //      
    //      view.addItemToDGV(Activity.Name, Activity.EstimatedCost)
    //  }

    //  //forconfirmed
    //  foreach(var Activity in awayday.AwayDayActivities)
    //  {
    //      
    //      view.addItemToDGV(Activity.Name, Activity.ActualCost)
    //  }
}
