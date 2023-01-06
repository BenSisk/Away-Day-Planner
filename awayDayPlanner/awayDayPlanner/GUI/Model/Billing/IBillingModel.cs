using awayDayPlanner.Source.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.GUI.Model.Billing
{
    public interface IBillingModel
    {
        void Submit(AwayDay awayDay);

        void SaveImageAsPdf(string imageFileName, string pdfFileName, int width = 600, bool deleteImage = false);



    }
}
