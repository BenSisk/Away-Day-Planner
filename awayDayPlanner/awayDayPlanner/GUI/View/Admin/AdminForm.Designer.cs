﻿namespace awayDayPlanner.GUI.View.Admin
{
    partial class AdminForm
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
            this.dgvReview = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReview
            // 
            this.dgvReview.AllowUserToAddRows = false;
            this.dgvReview.AllowUserToDeleteRows = false;
            this.dgvReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReview.Location = new System.Drawing.Point(12, 12);
            this.dgvReview.MultiSelect = false;
            this.dgvReview.Name = "dgvReview";
            this.dgvReview.ReadOnly = true;
            this.dgvReview.RowHeadersVisible = false;
            this.dgvReview.Size = new System.Drawing.Size(598, 426);
            this.dgvReview.TabIndex = 0;
            this.dgvReview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReview_CellDoubleClick);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(616, 355);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(174, 83);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Selected";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(675, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 67);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dgvReview);
            this.Name = "AdminForm";
            this.Text = "Admin Review";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReview;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnLogout;
    }
}