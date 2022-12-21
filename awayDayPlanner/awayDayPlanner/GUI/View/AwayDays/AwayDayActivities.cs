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
        public AwayDayActivities()
        {
            InitializeComponent();
        }

        public void PopulateDataGrid(AwayDay awayday)
        {
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

            foreach (var activity in awayday.AwayDayActivities)
            {
                dgvActivities.Rows.Add(activity.Name, activity.Notes, activity.ActualCost);
            }
        }
    }
}
