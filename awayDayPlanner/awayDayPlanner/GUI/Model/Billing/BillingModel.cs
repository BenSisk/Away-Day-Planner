using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Billing
{
    
    public class BillingModel : IBillingModel
    {
        public bool Confirmed;
        public string BuyerFirstName;
        public string BuyerLastName;
        public string BuyerFirstLineAddress;
        public string BuyerSecondLineAddress;
        public string BuyerPostCode;
        public string BuyerPhoneNumber;
        public string BuyerEmail;
        public double TotalCost;
        public AwayDay awayDay;

        public ICollection<Activity> AwayDayActivities;

        public BillingModel()
        {

        }

        public void Submit(AwayDay awayDay)
        {
            var frm = FormProvider.BillingForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"c:\temp\screenshot.png");
            }
        }
     
    }
}
