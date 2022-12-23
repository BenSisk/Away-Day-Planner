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
            this.PopulateDataGrid();
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

        private void PopulateDataGrid()
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





        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
