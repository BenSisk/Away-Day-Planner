using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.Booking
{
    public partial class awayDayPresenter : IFace_awayDayPresenter
    {
        private IFace_awayDayModel model;
        private IFace_awayDayForm view;

        public awayDayPresenter(IFace_awayDayForm view, IFace_awayDayModel model)
        {
            this.view = view;
            this.model = model;
            view.register(this);
            model.register(this);
            this.initialiseForm();
        }

        private void initialiseForm()
        {
            this.setEstimatedCost(0);
        }

        public void estimateCost()
        {
            model.estimateCost(this.getActivityList());
        }

        private void setEstimatedCost(string total)
        {
            view.setEstimatedCost(total);
        }

        public void setEstimatedCost(double total)
        {
            this.setEstimatedCost(String.Format("{0:0.00}", Math.Round(total, 2)));
        }

        public void submit()
        {
            if (model.submit(this.getActivityList()) == 0)
            {
                view.message("Application Submitted Successfully");
            }
            else
            {
                view.message("Something went wrong.");
            }
        }


        private List<string> getActivityList()
        {
            List<string> activities = new List<string>();
            if (view.getActivity1)
            {
                activities.Add("activity1");
            }
            if (view.getActivity2)
            {
                activities.Add("activity2");
            }
            if (view.getActivity3)
            {
                activities.Add("activity3");
            }
            return activities;
        }
    }
}