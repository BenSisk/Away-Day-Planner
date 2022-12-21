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

        public string firstname => this.txtFirstname.Text.ToString();

        public string surname => this.txtLastname.Text.ToString();

        public string email => this.txtEmail.Text.ToString();

        public string dob => this.dtpDOB.Text.ToString();

        public string phone => this.txtPhone.Text.ToString();

        public string FirstLine => this.txtFirstline.Text.ToString();

        public string SecondLine => this.txtSecondline.Text.ToString();

        public string PostCode => this.txtPostcode.Text.ToString();

        public string Username => this.txtUsername.Text.ToString();

        public string Password => this.txtPassword.Text.ToString();

        public string Password2 => this.txtPassword2.Text.ToString();

        public string Salt;

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
