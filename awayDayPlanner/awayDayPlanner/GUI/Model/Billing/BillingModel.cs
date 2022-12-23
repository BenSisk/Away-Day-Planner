using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Billing
{
    
    class BillingModel : IBillingModel
    {

        public BillingModel()
        {




        }

        // data passing format: class  awayday : int AwayDayID, DataTime AwayDayDate, bool Confirmed, double TotalCost
        //                                      virtual ICollection <Activity> AwayDayActivities, virtual User User


        public void GetDataFromDatabase(int _billingID)
        {
        //    var query = from b in Database.Database.Data.Billing
        //                 where b.billingID == _billingID
        //                 select b;

        //    Console.WriteLine("All users in the database:");
        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item.firstname);
        //    }
        }

        


    }
}
