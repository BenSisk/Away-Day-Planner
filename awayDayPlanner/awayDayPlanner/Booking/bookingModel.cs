using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.Booking
{
    public partial class bookingModel : IbookingModel
    {
        private IbookingPresenter presenter;
        private activityPrices prices;



        public bookingModel()
        {

        }

        public void register(IbookingPresenter presenter)
        {
            this.presenter = presenter;
        }

        public Dictionary<string, double> costPerActivity(List<string> activities)
        {
            Dictionary<string, double> activityEstimatedCosts = new Dictionary<string, double>();
            double temp;

            foreach (string activity in activities)
            {
                try
                {
                    temp = prices.getPrice(activity);
                }
                catch (KeyNotFoundException)
                {
                    temp = 0;
                }
                activityEstimatedCosts.Add(activity, temp);
            }

            return activityEstimatedCosts;
        }

        private void generatePDF()
        {
            //make itemised PDF
        }

        private double subtotal(List<double> costs)
        {
            double total = 0;
            foreach (double activityEstimatedCost in costs)
            {
                total += activityEstimatedCost;
            }

            return total;
        }

        public int submit(List<IActivity> activities)
        {
            return 0;
        }
    }
}