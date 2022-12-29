using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.GUI.Presenter.ControlPanel;

namespace awayDayPlanner.GUI.View.ControlPanel
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
            Presenter.NewAwayDay();
        }

        private void btnExistingEvents_Click(object sender, EventArgs e)
        {
            Presenter.ViewExistingAwayDays();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Presenter.LogOut();
        }
    }
}