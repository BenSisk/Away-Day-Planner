using awayDayPlanner.GUI.Presenter;
using awayDayPlanner.GUI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI
{
    public partial class ControlPanelForm : Form, IControlPanelForm
    {
        private IControlPanelPresenter Presenter;

        public ControlPanelForm()
        {
            InitializeComponent();
        }

        public void register(IControlPanelPresenter presenter)
        {
            this.Presenter = presenter;
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            Presenter.newAwayDay();
        }

        private void btnExistingEvents_Click(object sender, EventArgs e)
        {
            Presenter.viewExistingAwayDays();
        }
    }
}