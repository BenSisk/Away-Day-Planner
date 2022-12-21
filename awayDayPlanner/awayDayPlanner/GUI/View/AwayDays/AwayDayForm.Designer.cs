namespace awayDayPlanner.GUI.View.AwayDays
{
    partial class AwayDayForm
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
            this.dgvAwayDays = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayDays)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAwayDays
            // 
            this.dgvAwayDays.AllowUserToAddRows = false;
            this.dgvAwayDays.AllowUserToDeleteRows = false;
            this.dgvAwayDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwayDays.Location = new System.Drawing.Point(12, 86);
            this.dgvAwayDays.Name = "dgvAwayDays";
            this.dgvAwayDays.ReadOnly = true;
            this.dgvAwayDays.Size = new System.Drawing.Size(536, 352);
            this.dgvAwayDays.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(554, 318);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(233, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(554, 344);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(233, 94);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // AwayDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvAwayDays);
            this.Name = "AwayDayForm";
            this.Text = "Your Planned Away Days";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AwayDayForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAwayDays;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConfirm;
    }
}