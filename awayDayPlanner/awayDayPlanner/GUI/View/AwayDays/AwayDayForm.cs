using awayDayPlanner.GUI.Presenter.AwayDays;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.GUI.View.AwayDays
{
    public partial class AwayDayForm : Form, IAwayDayForm
    {
        private IAwayDayPresenter presenter;

        public AwayDayForm()
        {
            InitializeComponent();
            this.PopulateDataGrid();
        }

        public void register(IAwayDayPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void AwayDayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            presenter.Close();
        }

        public void Reset()
        {
            dgvAwayDays.Rows.Clear();
            presenter.PopulateDataGrid();
        }


        private void PopulateDataGrid()
        {
            dgvAwayDays.ColumnCount = 4;

            dgvAwayDays.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAwayDays.Columns[1].Width = 150;
            dgvAwayDays.Columns[2].Width = 150;
            dgvAwayDays.Columns[3].Width = 100;

            dgvAwayDays.Columns[0].Name = "Date";
            dgvAwayDays.Columns[1].Name = "Number of Activities";
            dgvAwayDays.Columns[2].Name = "Status";
            dgvAwayDays.Columns[3].Name = "Cost";

            dgvAwayDays.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAwayDays.Columns["Cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn column in dgvAwayDays.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void addItemToDGV(DateTime date, int count, string status, double cost)
        {
            this.dgvAwayDays.Rows.Add(date, count, status, cost);
        }

        private void btnOpenAwayDay_Click(object sender, EventArgs e)
        {
            presenter.OpenAwayDay();
        }

        private void dgvAwayDays_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.OpenAwayDay();
        }

        public DataGridViewRow GetSelected()
        {
            return this.dgvAwayDays.SelectedRows[0];
        }

        public DialogResult displayFormAsDialog(Form form)
        {
            return form.ShowDialog(this);
        }

        public void message(string message, string title)
        {
            MessageBox.Show(message, title);
        }
    }
}