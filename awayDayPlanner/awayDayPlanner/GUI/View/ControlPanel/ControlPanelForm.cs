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
using awayDayPlanner.Lib.Users;

namespace awayDayPlanner.GUI.View.ControlPanel
{
    public partial class ControlPanelForm : Form, IControlPanelForm
    {
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        public IControlPanelPresenter Presenter
        {
            private get; set;
        }

        public User user { get; set; }

        public void Register(IControlPanelPresenter presenter)
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnAdmin.Enabled = false;
            btnAdmin.Visible = false;
            Presenter.AdminShow();
        }

        public void ShowAdminButton()
        {
            btnAdmin.Enabled = true;
            btnAdmin.Visible = true;
        }

        public void HideAdminButton()
        {
            btnAdmin.Enabled = false;
            btnAdmin.Visible = false;
        }

        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Presenter.LogOut();
        }
    }
}