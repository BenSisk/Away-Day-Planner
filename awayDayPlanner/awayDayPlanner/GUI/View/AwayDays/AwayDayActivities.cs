using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.Source.Activities;

namespace awayDayPlanner.GUI.View.AwayDays
{
    public partial class AwayDayActivities : Form
    {
        AwayDay awayday;
        public AwayDayActivities()
        {
            InitializeComponent();
        }

        public void PopulateDataGrid(AwayDay awayday)
        {
            this.awayday = awayday;

            dgvActivities.Rows.Clear();

            dgvActivities.ColumnCount = 3;

            dgvActivities.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvActivities.Columns[1].Width = 150;
            dgvActivities.Columns[2].Width = 100;

            dgvActivities.Columns[0].Name = "Activity Name";
            dgvActivities.Columns[1].Name = "Notes";
            dgvActivities.Columns[2].Name = "Cost";

            dgvActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActivities.Columns["Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn column in dgvActivities.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (var activity in this.awayday.AwayDayActivities)
            {
                dgvActivities.Rows.Add(activity.Name, activity.Notes, activity.ActualCost);
            }

            if (this.awayday.Confirmed)
            { 
                btnConfirm.Enabled = false;
            }
            else 
            {
                btnConfirm.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult diaglogResult = MessageBox.Show("Are you sure you would like to confirm this Away-Day?", "Confirm Away-Day", MessageBoxButtons.YesNo);
            if (diaglogResult == DialogResult.Yes)
            {
                this.awayday.Confirmed = true;
                Database.Database.Data.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}