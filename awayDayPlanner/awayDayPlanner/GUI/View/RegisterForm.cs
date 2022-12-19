using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI
{
    public partial class RegisterForm : Form, IRegisterView
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        public RegisterPresenter Presenter
        {
            private get; set;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Presenter.Submit();
        }
    }
}
