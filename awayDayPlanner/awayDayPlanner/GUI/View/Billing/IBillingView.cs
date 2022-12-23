using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Billing
{
    public interface IBillingView
    {

        string BuyerName { get; set; }

        string BuyerAddress { get; set; }

        string BuyerPhone { get; set; }

        string BuyerEmail { get; set; }


        BillingPresenter Presenter { set; }

        void addItemToDGV(string name, double cost);
    }
}
