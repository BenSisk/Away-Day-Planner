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

        public void Reset()
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        public RegisterPresenter Presenter
        {
            private get; set;
        }

        public string firstname => this.txtFirstname.Text;

        public string surname => this.txtLastname.Text;

        public string email => this.txtEmail.Text;

        public string dob => this.dtpDOB.Text;

        public string phone => this.txtPhone.Text;

        public string firstline => this.txtFirstline.Text;

        public string secondline => this.txtSecondline.Text;

        public string postcode => this.txtPostcode.Text;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Presenter.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Presenter.Submit();
        }
    }
}
