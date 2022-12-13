using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner
{
    public partial class awayDayForm : Form, IFace_awayDayForm
    {
        private IFace_awayDayPresenter presenter;

        public awayDayForm()
        {
            this.InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            presenter.submit();
        }

        public void register(IFace_awayDayPresenter presenter)
        {
            this.presenter = presenter;
        }

        public Boolean getActivity1
        {
            get { return chbx_Activity1.Checked; }
        }

        public Boolean getActivity2
        {
            get { return chbx_Activity2.Checked; }
        }

        public Boolean getActivity3
        {
            get { return chbx_Activity3.Checked; }
        }
    }
}
