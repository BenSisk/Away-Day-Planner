using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.Booking
{
    public partial class bookingForm : Form, IbookingForm
    {
        private IbookingPresenter presenter;

        public bookingForm()
        {
            this.InitializeComponent();
            this.populateDataGrid();
        }

        private void populateDataGrid()
        {
            this.Controls.Add(dgvActivities);

            dgvActivities.ColumnCount = 2;
            dgvActivities.RowHeadersVisible = false;

            dgvActivities.Columns[0].Width = 200;
            dgvActivities.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActivities.Columns[0].Name = "Activity";
            dgvActivities.Columns[1].Name = "Notes";

            dgvActivities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvActivities.MultiSelect = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult diaglogResult = MessageBox.Show("Are you sure you would like to submit this away-day application?", "Submit Application", MessageBoxButtons.YesNo);
            if (diaglogResult == DialogResult.Yes)
            {
                presenter.submit();
            }
        }

        public void register(IbookingPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void message(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            presenter.addActivity();
        }

        public void addItemToDGV(string name, string notes)
        {
            this.dgvActivities.Rows.Add(name, notes);
        }

        public DialogResult displayFormAsDialog(Form form)
        {
            return form.ShowDialog(this);
        }

        private void btnRemoveActivity_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want really to delete the selected row", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                presenter.deleteRows(dgvActivities.SelectedRows);
            }
        }

        public void deleteRow(DataGridViewRow row)
        {
            dgvActivities.Rows.Remove(row);
        }
    }
}