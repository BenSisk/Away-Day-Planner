using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.Source.Activities;
using awayDayPlanner.GUI.Presenter.Booking;

namespace awayDayPlanner.GUI.Model.Booking
{
    public partial class bookingModel : IbookingModel
    {
        private IbookingPresenter presenter;



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