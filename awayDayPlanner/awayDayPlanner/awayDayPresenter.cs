using System;
using System.Collections.Generic;
using System.Linq;
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
            MessageBox.Show("GONK!");
        }

        public void register(IFace_awayDayForm view)
        {
            this.view = view;
        }

        public void register(IFace_awayDayModel model)
        {
            this.model = model;
        }
    }
}