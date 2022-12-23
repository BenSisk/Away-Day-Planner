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

        System.Windows.Forms.DataGridView addItemToDGV { get; set; }



        BillingPresenter Presenter { set; }

    }
}
