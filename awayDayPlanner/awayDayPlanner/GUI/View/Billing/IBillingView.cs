using awayDayPlanner.GUI.Model.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Billing
{
    public interface IBillingView
    {
        AwayDay AwayDay { get; set; }
        System.Windows.Forms.Label BuyerName { get; set; }
        System.Windows.Forms.Label BuyerAddress { get; set; }
        System.Windows.Forms.Label BuyerPhone { get; set; }
        System.Windows.Forms.Label BuyerEmail { get; set; }
        System.Windows.Forms.Label TotalCost { get; set; }
        System.Windows.Forms.Button buttonClose { get; set; }
        System.Windows.Forms.Button buttonCapture { get; set; }
        System.Windows.Forms.Label Title { get; set; }
        System.Windows.Forms.Panel TopPanel { get ; set; }
        System.Windows.Forms.Label billingLabel { get; set; }
        System.Windows.Forms.DataGridView addItemToDGV { get; set; }



        BillingPresenter Presenter { set; }

    }
}
