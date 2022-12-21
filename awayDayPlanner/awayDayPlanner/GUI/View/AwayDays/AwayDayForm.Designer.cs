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
            this.btnOpenAwayDay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayDays)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAwayDays
            // 
            this.dgvAwayDays.AllowUserToAddRows = false;
            this.dgvAwayDays.AllowUserToDeleteRows = false;
            this.dgvAwayDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwayDays.Location = new System.Drawing.Point(12, 65);
            this.dgvAwayDays.MultiSelect = false;
            this.dgvAwayDays.Name = "dgvAwayDays";
            this.dgvAwayDays.ReadOnly = true;
            this.dgvAwayDays.RowHeadersVisible = false;
            this.dgvAwayDays.Size = new System.Drawing.Size(607, 373);
            this.dgvAwayDays.TabIndex = 0;
            this.dgvAwayDays.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAwayDays_CellDoubleClick);
            // 
            // btnOpenAwayDay
            // 
            this.btnOpenAwayDay.Location = new System.Drawing.Point(625, 368);
            this.btnOpenAwayDay.Name = "btnOpenAwayDay";
            this.btnOpenAwayDay.Size = new System.Drawing.Size(162, 70);
            this.btnOpenAwayDay.TabIndex = 2;
            this.btnOpenAwayDay.Text = "Open Selected Away Day";
            this.btnOpenAwayDay.UseVisualStyleBackColor = true;
            this.btnOpenAwayDay.Click += new System.EventHandler(this.btnOpenAwayDay_Click);
            // 
            // AwayDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenAwayDay);
            this.Controls.Add(this.dgvAwayDays);
            this.Name = "AwayDayForm";
            this.Text = "Your Planned Away Days";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AwayDayForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAwayDays;
        private System.Windows.Forms.Button btnOpenAwayDay;
    }
}