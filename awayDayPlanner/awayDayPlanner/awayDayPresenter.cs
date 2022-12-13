using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner
{
    public partial class awayDayPresenter : Form, IFace_awayDayPresenter
    {
        private IFace_awayDayModel model;
        private IFace_awayDayForm view;

        public awayDayPresenter(IFace_awayDayForm view, IFace_awayDayModel model)
        {
            this.view = view;
            this.model = model;
            view.register(this);
            model.register(this);
        }

        public void submit()
        {
            List<Activity> activities = new List<Activity>();
            if (view.getActivity1)
            {
                activities.Add(Activity.activity1);
            }
            if (view.getActivity2)
            {
                activities.Add(Activity.activity2);
            }
            if (view.getActivity3)
            {
                activities.Add(Activity.activity3);
            }

            model.estimateCost(activities);
        }
    }
}