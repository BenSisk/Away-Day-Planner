namespace awayDayPlanner.GUI.View.NewItem
{
    partial class AddNewItem
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
            this.cmbxActivity = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtCustomActivity = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstimatedCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxActivity
            // 
            this.cmbxActivity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxActivity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbxActivity.FormattingEnabled = true;
            this.cmbxActivity.Location = new System.Drawing.Point(12, 35);
            this.cmbxActivity.Name = "cmbxActivity";
            this.cmbxActivity.Size = new System.Drawing.Size(173, 21);
            this.cmbxActivity.TabIndex = 0;
            this.cmbxActivity.SelectedIndexChanged += new System.EventHandler(this.cmbxActivity_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 213);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(364, 67);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtCustomActivity
            // 
            this.txtCustomActivity.Enabled = false;
            this.txtCustomActivity.Location = new System.Drawing.Point(191, 36);
            this.txtCustomActivity.Name = "txtCustomActivity";
            this.txtCustomActivity.Size = new System.Drawing.Size(185, 20);
            this.txtCustomActivity.TabIndex = 1;
            this.txtCustomActivity.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 124);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(364, 83);
            this.txtNotes.TabIndex = 2;
            this.txtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(13, 105);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes:";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(12, 13);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(44, 13);
            this.lblActivity.TabIndex = 6;
            this.lblActivity.Text = "Activity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Custom Activity Name:";
            // 
            // txtEstimatedCost
            // 
            this.txtEstimatedCost.Enabled = false;
            this.txtEstimatedCost.Location = new System.Drawing.Point(274, 74);
            this.txtEstimatedCost.Name = "txtEstimatedCost";
            this.txtEstimatedCost.ReadOnly = true;
            this.txtEstimatedCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEstimatedCost.Size = new System.Drawing.Size(102, 20);
            this.txtEstimatedCost.TabIndex = 8;
            this.txtEstimatedCost.TabStop = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(188, 77);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(80, 13);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "Estimated Cost:";
            // 
            // AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 292);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtEstimatedCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtCustomActivity);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cmbxActivity);
            this.Name = "AddNewItem";
            this.Text = "addNewItem";
            this.Load += new System.EventHandler(this.addNewItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxActivity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtCustomActivity;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstimatedCost;
        private System.Windows.Forms.Label lblCost;
    }
}