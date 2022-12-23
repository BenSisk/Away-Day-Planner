using awayDayPlanner.GUI.Billing;
using awayDayPlanner.GUI.Model.Billing;
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
            InitializeComponent();
            
            //this.PopulateDataGrid();
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



        /*
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

                public void PopulateDataGrid()
                {
                    dgvActivityList.ColumnCount = 2;

                    dgvActivityList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvActivityList.Columns[1].Width = 150;

                    dgvActivityList.Columns[0].Name = "Activity";
                    dgvActivityList.Columns[1].Name = "Cost";


                    dgvActivityList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvActivityList.Columns["Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    foreach (DataGridViewColumn column in dgvActivityList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }


                public void addItemToDGV(string name, double cost)
                {
                    this.dgvActivityList.Rows.Add(name, cost);
                }


        */


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
