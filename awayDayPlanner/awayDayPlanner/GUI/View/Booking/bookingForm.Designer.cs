namespace awayDayPlanner.GUI.View.Booking
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.DGV_Activities = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveActivity = new System.Windows.Forms.Button();
            this.dtpAwayDayDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Activities)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(707, 378);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(216, 79);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // DGV_Activities
            // 
            this.DGV_Activities.AllowUserToAddRows = false;
            this.DGV_Activities.AllowUserToDeleteRows = false;
            this.DGV_Activities.AllowUserToResizeColumns = false;
            this.DGV_Activities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Activities.Location = new System.Drawing.Point(12, 38);
            this.DGV_Activities.Name = "DGV_Activities";
            this.DGV_Activities.ReadOnly = true;
            this.DGV_Activities.Size = new System.Drawing.Size(689, 419);
            this.DGV_Activities.TabIndex = 4;
            this.DGV_Activities.TabStop = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(707, 38);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(216, 79);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add New Activity";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveActivity
            // 
            this.btnRemoveActivity.Location = new System.Drawing.Point(707, 123);
            this.btnRemoveActivity.Name = "btnRemoveActivity";
            this.btnRemoveActivity.Size = new System.Drawing.Size(216, 79);
            this.btnRemoveActivity.TabIndex = 2;
            this.btnRemoveActivity.Text = "Remove Selected Activity";
            this.btnRemoveActivity.UseVisualStyleBackColor = true;
            this.btnRemoveActivity.Click += new System.EventHandler(this.btnRemoveActivity_Click);
            // 
            // dtpAwayDayDate
            // 
            this.dtpAwayDayDate.Location = new System.Drawing.Point(12, 12);
            this.dtpAwayDayDate.Name = "dtpAwayDayDate";
            this.dtpAwayDayDate.Size = new System.Drawing.Size(207, 20);
            this.dtpAwayDayDate.TabIndex = 0;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 469);
            this.Controls.Add(this.dtpAwayDayDate);
            this.Controls.Add(this.btnRemoveActivity);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.DGV_Activities);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookingForm";
            this.Text = "awayDay_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bookingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Activities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView DGV_Activities;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveActivity;
        private System.Windows.Forms.DateTimePicker dtpAwayDayDate;
    }
}

