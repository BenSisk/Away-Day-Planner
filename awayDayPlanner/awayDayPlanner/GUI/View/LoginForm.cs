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
    public partial class LoginForm : Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string userName
        {
            get { return this.txtUsername.Text; }
        }

        public string password
        {
            get { return this.txtPassword.Text; }
        }

        public LoginPresenter Presenter
        { 
            private get; set; 
        }
    }
}
