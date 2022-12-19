using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awayDayPlanner.Booking
{
    public partial class addNewItem : Form
    {
        public addNewItem()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void addNewItem_Load(object sender, EventArgs e)
        {
            txtCustomActivity.Enabled = false;
            txtCustomActivity.TabStop = false;
            txtCustomActivity.Text = "";
            txtNotes.Text = "";
            cmbxActivity.SelectedIndex = 0;
        }


        private void populateComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(ActivityEnum)))
            {
                cmbxActivity.Items.Add(item);
            }
            if (cmbxActivity.Items.Count > 0)
            {
                cmbxActivity.SelectedIndex = 0;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbxActivity.SelectedItem.Equals(ActivityEnum.Custom))
            {
                if (txtCustomActivity.Text.Length == 0)
                {
                    MessageBox.Show("You must enter a name for the custom activity", "Error");
                    txtCustomActivity.Focus();
                    return;
                }
            }
            else
            {
                txtCustomActivity.Text = cmbxActivity.SelectedItem.ToString();
            }
            this.DialogResult = DialogResult.OK;
        }

        public ActivityEnum getActivityType()
        {
            return (ActivityEnum) cmbxActivity.SelectedItem;
        }

        public string getCustomRequest()
        {
            return (string)txtCustomActivity.Text;
        }

        public string getNotes()
        {
            return txtNotes.Text;
        }

        private void cmbxActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ActivityEnum) cmbxActivity.SelectedItem == ActivityEnum.Custom)
            {
                txtCustomActivity.Enabled = true;
                txtCustomActivity.TabStop = true;
                txtCustomActivity.Focus();
            }
            else
            {
                txtCustomActivity.Enabled = false;
                txtCustomActivity.TabStop = false;
                txtCustomActivity.Text = "";
            }
        }
    }
}