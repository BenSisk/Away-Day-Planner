using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner
{
    public partial class awayDayModel : IFace_awayDayModel
    {
        private IFace_awayDayPresenter presenter;
        private activityPrices prices;



        public awayDayModel()
        {

        }


        public void register(IFace_awayDayPresenter presenter)
        {
            this.presenter = presenter;

            // not how prices will eventually be set, placeholder for testing
            this.prices = new activityPrices();
            prices.setPrice("activity1", 4.02);
            prices.setPrice("activity2", 27.54);
            /*prices.setPrice("activity3", 2.08);
            prices.setPrice("activity3", 57.98);*/
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


        private void generateEstimatedCostPDF(Dictionary<string, double> activities, double total)
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


        public void estimateCost(List<string> activities)
        {
            Dictionary<string, double> activityCosts = costPerActivity(activities);
            double total = subtotal(activityCosts.Values.ToList());
            presenter.setEstimatedCost(total);
        }


        public int submit(List<string> activities)
        {
            Dictionary<string, double> activityCosts = costPerActivity(activities);
            if (activityCosts.Count == 0)
            {
                return -1;
            }
            else
            {
                double total = subtotal(activityCosts.Values.ToList());
                generateEstimatedCostPDF(activityCosts, total);
                return 0;
            }
        }
    }
}