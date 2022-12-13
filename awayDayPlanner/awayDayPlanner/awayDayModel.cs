using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner
{
    public partial class awayDayModel : Form, IFace_awayDayModel
    {
        private IFace_awayDayPresenter presenter;

        public awayDayModel()
        {

        }

        public void register(IFace_awayDayPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void estimateCost(List<Activity> activities)
        {
            //stuff
            generateEstimatedCostPDF(new Dictionary<Activity, float>());
        }

        private void generateEstimatedCostPDF(Dictionary<Activity, float> activities)
        {
            //other stuff
        }
    }
}
