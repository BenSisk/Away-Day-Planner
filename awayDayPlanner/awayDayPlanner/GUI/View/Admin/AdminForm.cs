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

namespace awayDayPlanner.GUI.View.Admin
{
    public partial class AdminForm : Form, IAdminForm
    {
        IAdminPresenter presenter;

        public AdminForm()
        {
            InitializeComponent();
            this.PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            dgvReview.ColumnCount = 3;

            dgvReview.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReview.Columns[1].Width = 150;
            dgvReview.Columns[2].Width = 100;

            dgvReview.Columns[0].Name = "Date";
            dgvReview.Columns[1].Name = "Number of Activities";
            dgvReview.Columns[2].Name = "Esimated Cost";

            dgvReview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReview.Columns["Esimated Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn column in dgvReview.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void Reset()
        {
            dgvReview.Rows.Clear();
            presenter.PopulateDataGrid();
        }

        public void register(IAdminPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void addItemToDGV(DateTime date, int count, double cost)
        {
            this.dgvReview.Rows.Add(date, count, cost);
        }

        private void OpenSelected()
        {
            if (dgvReview.Rows.Count > 0)
            {
                presenter.OpenSelected();
            }
        }

        private void dgvReview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.OpenSelected();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            this.OpenSelected();
        }

        public DialogResult displayFormAsDialog(Form form)
        {
            return form.ShowDialog(this);
        }

        public DataGridViewRow GetSelected()
        {
            return this.dgvReview.SelectedRows[0];
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            presenter.LogOut();
        }
    }
}
