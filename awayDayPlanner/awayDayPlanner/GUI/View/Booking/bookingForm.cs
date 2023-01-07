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
using awayDayPlanner.GUI.Presenter.Booking;
using awayDayPlanner.GUI.View.NewItem;

namespace awayDayPlanner.GUI.View.Booking
{
    public partial class BookingForm : Form, IBookingForm
    {
        private IBookingPresenter presenter;

        public BookingForm()
        {
            this.InitializeComponent();
            this.PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            DGV_Activities.Controls.Clear();
            this.Controls.Add(DGV_Activities);

            DGV_Activities.ColumnCount = 3;
            DGV_Activities.RowHeadersVisible = false;

            DGV_Activities.Columns[0].Width = 200;
            DGV_Activities.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_Activities.Columns[2].Width = 100;

            DGV_Activities.Columns[0].Name = "Activity";
            DGV_Activities.Columns[1].Name = "Notes";
            DGV_Activities.Columns[2].Name = "Estimated Cost";

            DGV_Activities.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DGV_Activities.MultiSelect = true;

            foreach (DataGridViewColumn column in DGV_Activities.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult diaglogResult = MessageBox.Show("Are you sure you would like to submit this away-day application?", "Submit Application", MessageBoxButtons.YesNo);
            if (diaglogResult == DialogResult.Yes)
            {
                presenter.Submit();
                FormProvider.BillingForm.Execute();
                FormProvider.BookingForm.Hide();
            }
        }

        public void Register(IBookingPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void Message(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            presenter.AddActivity();
        }

        public void AddItemToDGV(string name, string notes, double price)
        {
            this.DGV_Activities.Rows.Add(name, notes, price);
        }

        public DialogResult DisplayFormAsDialog(IAddNewItem form)
        {
            return form.GetForm().ShowDialog(this);
        }

        private void btnRemoveActivity_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want really to delete the selected row", "Confirm Deletion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                presenter.DeleteRows(DGV_Activities.SelectedRows);
            }
        }

        public void DeleteRow(DataGridViewRow row)
        {
            DGV_Activities.Rows.Remove(row);
        }

        private void bookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            DialogResult diaglogResult = MessageBox.Show("Are you sure you would like to cancel this application?\n\nYour changes will not be saved.", "Cancel Application", MessageBoxButtons.YesNo);
            if (diaglogResult == DialogResult.Yes)
            {
                presenter.Close();
            }
        }

        public DateTime GetDate()
        {
            return dtpAwayDayDate.Value;
        }

        public void Reset()
        {
            DGV_Activities.Rows.Clear();
        }
    }
}