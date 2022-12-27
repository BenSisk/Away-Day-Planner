using awayDayPlanner.GUI.Billing;
using awayDayPlanner.GUI.Model.Billing; //this needs to be bens namespace
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
    public partial class BillingForm : Form, IBillingView
    {
        
        public BillingForm()
        {
            this.AwayDay = new AwayDay();
            //this should be bens awayday object
            InitializeComponent();
        }

        public System.Windows.Forms.Button buttonClose
        {
            get { return this.btnClose; }
            set { this.btnClose = value; }
        }

        public System.Windows.Forms.Button buttonCapture
        {
            get { return this.btnCapture; }
            set { this.btnCapture = value; }
        }

        public System.Windows.Forms.Label TotalCost
        {
            get { return this.totalCost; }
            set { this.totalCost = value; }
        }

        public System.Windows.Forms.Label Title
        {
            get { return this.label2; }
            set { this.label2 = value; }
        }
        public System.Windows.Forms.Panel TopPanel
        {
            get { return this.panel1; }
            set { this.panel1 = value; }
        }

        public BillingPresenter Presenter { private get; set; }

        public AwayDay AwayDay { get; set; }
        public System.Windows.Forms.Label BuyerName
        {
            get { return this.buyerNameLabel; }
            set { this.buyerNameLabel = value; }
        }
        public System.Windows.Forms.Label BuyerAddress
        {
            get { return this.buyerAddressLabel; }
            set { this.buyerAddressLabel = value; }
        }
        public System.Windows.Forms.Label BuyerPhone
        {
            get { return this.buyerPhoneLabel; }
            set { this.buyerPhoneLabel = value; }
        }
        public System.Windows.Forms.Label BuyerEmail
        {
            get { return this.buyerEmailLabel; }
            set { this.buyerEmailLabel = value; }
        }

        public System.Windows.Forms.DataGridView addItemToDGV
        {
            get { return this.dgvActivityList; }
            set { this.dgvActivityList = value; }
        }

        public System.Windows.Forms.Label billingLabel
        {
            get { return this.invoiceLabel; }
            set { this.invoiceLabel = value; }
        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            Presenter.Submit();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            Presenter.BillingLoad(this.AwayDay);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Presenter.Close();
        }
    }
}
