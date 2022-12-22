namespace awayDayPlanner.GUI.View.Admin
{
    partial class AdminReviewForm
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
            this.dgvReviewActivities = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReviewActivities
            // 
            this.dgvReviewActivities.AllowUserToAddRows = false;
            this.dgvReviewActivities.AllowUserToDeleteRows = false;
            this.dgvReviewActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviewActivities.Location = new System.Drawing.Point(12, 12);
            this.dgvReviewActivities.MultiSelect = false;
            this.dgvReviewActivities.Name = "dgvReviewActivities";
            this.dgvReviewActivities.RowHeadersVisible = false;
            this.dgvReviewActivities.Size = new System.Drawing.Size(584, 426);
            this.dgvReviewActivities.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(602, 358);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(186, 80);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm Prices";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AdminReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgvReviewActivities);
            this.Name = "AdminReviewForm";
            this.Text = "AdminReviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReviewActivities;
        private System.Windows.Forms.Button btnConfirm;
    }
}