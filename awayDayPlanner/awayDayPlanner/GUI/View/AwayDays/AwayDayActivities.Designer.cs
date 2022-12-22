namespace awayDayPlanner.GUI.View.AwayDays
{
    partial class AwayDayActivities
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
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(12, 139);
            this.dgvActivities.MultiSelect = false;
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            this.dgvActivities.RowHeadersVisible = false;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(540, 281);
            this.dgvActivities.TabIndex = 0;
            this.dgvActivities.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(558, 337);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(174, 83);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm Away Day";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(598, 298);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(134, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(558, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(558, 267);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(174, 20);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.TabStop = false;
            // 
            // AwayDayActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 432);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvActivities);
            this.Name = "AwayDayActivities";
            this.Text = "AwayDayActivities";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}