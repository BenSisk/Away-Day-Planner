using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.View.Billing
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        public string BuyerName
        {
            get { return this.buyerNameLabel.Text; }
            set { this.buyerNameLabel.Text = value; }
        }
        public string BuyerAddress
        {
            get { return this.buyerAddressLabel.Text; }
            set { this.buyerAddressLabel.Text = value; }
        }
        public string BuyerPhone
        {
            get { return this.buyerPhoneLabel.Text; }
            set { this.buyerPhoneLabel.Text = value; }
        }
        public string BuyerEmail
        {
            get { return this.buyerEmailLabel.Text; }
            set { this.buyerEmailLabel.Text = value; }
        }










        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
