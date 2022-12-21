using awayDayPlanner.GUI.Presenter.AwayDays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.View.AwayDays
{
    public partial class AwayDayForm : Form, IAwayDayForm
    {
        private IAwayDayPresenter presenter;


        public AwayDayForm()
        {
            InitializeComponent();
        }

        public void register(IAwayDayPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void AwayDayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            presenter.Close();
        }

        public void Reset()
        {
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
