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
        public RegisterPresenter Presenter { get; set; }
        private static RegisterForm instance = null;
        private RegisterForm()
        {
            InitializeComponent();
        }

        public static RegisterForm getInstance()
        {
            if (instance == null)
            {
                instance = new RegisterForm();
            }
            return instance;
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

        public string firstname { get { return this.txtFirstname.Text; } }
        public string surname { get { return this.txtLastname.Text; } }
        public string email { get { return this.txtEmail.Text; } }
        public DateTime dob { get { return this.dtpDOB.Value; } }
        public string phone { get { return this.txtPhone.Text; } }
        public string FirstLine { get { return this.txtFirstline.Text; } }
        public string SecondLine { get { return this.txtSecondline.Text; } }
        public string PostCode { get { return this.txtPostcode.Text; } }
        public string Username { get { return this.txtUsername.Text; } }
        public string Password { get { return this.txtPassword.Text; } }
        public string Password2 { get { return this.txtPassword2.Text; } }

        public string Salt;

        public System.Windows.Forms.Label labelUsername
        {
            get { return this.lblUsername; }
            set { this.lblUsername = value; }
        }

        public System.Windows.Forms.Label labelPassword
        {
            get { return this.lblPassword; }
            set { this.lblPassword = value; }
        }

        public System.Windows.Forms.Label labelPostCode
        {
            get { return this.lblPostcode; }
            set { this.lblPostcode = value; }
        }
        public System.Windows.Forms.Label labelSecondLine
        {
            get { return this.lblSecondLine; }
            set { this.lblLastName = value; }
        }
        public System.Windows.Forms.Label labelFirstLine
        {
            get { return this.lblFirstLine; }
            set { this.lblFirstLine = value; }
        }

        public System.Windows.Forms.Label labelFirstName 
        { 
            get { return this.lblFirstName; } 
            set { this.lblFirstName = value; } 
        }

        public System.Windows.Forms.Label labelEmail
        {
            get { return this.lblEmail; }
            set { this.lblEmail = value; }
        }

        public System.Windows.Forms.Label labelDOB
        {
            get { return this.lblDOB; }
            set { this.lblDOB = value; }
        }

        public System.Windows.Forms.Label labelSecondName
        {
            get { return this.lblLastName; }
            set { this.lblLastName = value; }
        }

        public System.Windows.Forms.Label labelPhone
        {
            get { return this.lblPhone; }
            set { this.lblPhone = value; }
        }

        public System.Windows.Forms.ToolTip PasswordError
        {
            get { return this.tltPasswordError; }
            set { this.tltPasswordError = value; }
        }

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
