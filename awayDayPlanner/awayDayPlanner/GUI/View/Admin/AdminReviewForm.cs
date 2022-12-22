using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using awayDayPlanner.GUI.Presenter.Admin;
using awayDayPlanner.Source.Activities;

namespace awayDayPlanner.GUI.View.Admin
{
    public partial class AdminReviewForm : Form, IAdminReviewForm
    {
        IAdminReviewPresenter presenter;

        public AdminReviewForm()
        {
            InitializeComponent();
            this.PopulateDataGrid();
        }

        public void register(IAdminReviewPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void PopulateDataGrid()
        {
            dgvReviewActivities.ColumnCount = 3;

            dgvReviewActivities.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReviewActivities.Columns[1].Width = 150;
            dgvReviewActivities.Columns[2].Width = 100;

            dgvReviewActivities.Columns[0].Name = "Type";
            dgvReviewActivities.Columns[1].Name = "Name";
            dgvReviewActivities.Columns[2].Name = "Actual Cost";

            dgvReviewActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReviewActivities.Columns["Actual Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReviewActivities.Columns["Type"].ReadOnly = true;
            dgvReviewActivities.Columns["Name"].ReadOnly = true;

            foreach (DataGridViewColumn column in dgvReviewActivities.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void Reset()
        {
            dgvReviewActivities.Rows.Clear();
            presenter.PopulateDataGrid();
        }

        public void addItemToDGV(ActivityType type, string name, double cost)
        {
            this.dgvReviewActivities.Rows.Add(type, name, cost);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to confirm these activity prices?", "Confirm Prices?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.Submit();
            }
        }

        public DataGridViewRowCollection GetPrices()
        {
            return dgvReviewActivities.Rows;
        }

        public void Exit()
        {
            this.DialogResult = DialogResult.OK;
        }

        public void Message(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}
