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

        public void Message(string message)
        {
            MessageBox.Show(message);
        }
        public RegisterPresenter Presenter
        {
            private get; set;
        }

        public string firstname { get { return this.txtFirstname.Text; } }
        public string surname { get { return this.txtLastname.Text; } }
        public string email { get { return this.txtEmail.Text; } }
        public string dob { get { return this.dtpDOB.Text; } }
        public string phone { get { return this.txtPhone.Text; } }
        public string FirstLine { get { return this.txtFirstline.Text; } }
        public string SecondLine { get { return this.txtSecondline.Text; } }
        public string PostCode { get { return this.txtPostcode.Text; } }
        public string Username { get { return this.txtUsername.Text; } }
        public string Password { get { return this.txtPassword.Text; } }
        public string Password2 { get { return this.txtPassword2.Text; } }

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
