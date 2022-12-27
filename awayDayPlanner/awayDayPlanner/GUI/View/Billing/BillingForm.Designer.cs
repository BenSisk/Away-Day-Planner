namespace awayDayPlanner.GUI.View.Billing
{
    partial class BillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buyerPhoneLabel = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.GroupBox();
            this.buyerEmailLabel = new System.Windows.Forms.Label();
            this.buyerAddressLabel = new System.Windows.Forms.Label();
            this.buyerNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvActivityList = new System.Windows.Forms.DataGridView();
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Details.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buyerPhoneLabel
            // 
            this.buyerPhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buyerPhoneLabel.AutoSize = true;
            this.buyerPhoneLabel.Location = new System.Drawing.Point(14, 105);
            this.buyerPhoneLabel.Name = "buyerPhoneLabel";
            this.buyerPhoneLabel.Size = new System.Drawing.Size(172, 21);
            this.buyerPhoneLabel.TabIndex = 2;
            this.buyerPhoneLabel.Text = "Buyer Phone Number";
            // 
            // Details
            // 
            this.Details.BackColor = System.Drawing.Color.White;
            this.Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Details.Controls.Add(this.buyerEmailLabel);
            this.Details.Controls.Add(this.buyerPhoneLabel);
            this.Details.Controls.Add(this.buyerAddressLabel);
            this.Details.Controls.Add(this.buyerNameLabel);
            this.Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Details.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Details.Location = new System.Drawing.Point(415, 65);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(320, 184);
            this.Details.TabIndex = 1;
            this.Details.TabStop = false;
            this.Details.Text = "Bill to:";
            // 
            // buyerEmailLabel
            // 
            this.buyerEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buyerEmailLabel.AutoSize = true;
            this.buyerEmailLabel.Location = new System.Drawing.Point(14, 138);
            this.buyerEmailLabel.Name = "buyerEmailLabel";
            this.buyerEmailLabel.Size = new System.Drawing.Size(102, 21);
            this.buyerEmailLabel.TabIndex = 2;
            this.buyerEmailLabel.Text = "Buyer E-mail";
            // 
            // buyerAddressLabel
            // 
            this.buyerAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buyerAddressLabel.AutoSize = true;
            this.buyerAddressLabel.Location = new System.Drawing.Point(14, 70);
            this.buyerAddressLabel.Name = "buyerAddressLabel";
            this.buyerAddressLabel.Size = new System.Drawing.Size(118, 21);
            this.buyerAddressLabel.TabIndex = 2;
            this.buyerAddressLabel.Text = "Buyer Address";
            // 
            // buyerNameLabel
            // 
            this.buyerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buyerNameLabel.AutoSize = true;
            this.buyerNameLabel.Location = new System.Drawing.Point(14, 38);
            this.buyerNameLabel.Name = "buyerNameLabel";
            this.buyerNameLabel.Size = new System.Drawing.Size(223, 21);
            this.buyerNameLabel.TabIndex = 2;
            this.buyerNameLabel.Text = "Buyer Name/Buisness Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvActivityList);
            this.panel2.Controls.Add(this.invoiceLabel);
            this.panel2.Controls.Add(this.totalCost);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnCapture);
            this.panel2.Controls.Add(this.Details);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 657);
            this.panel2.TabIndex = 3;
            // 
            // dgvActivityList
            // 
            this.dgvActivityList.AllowUserToAddRows = false;
            this.dgvActivityList.AllowUserToDeleteRows = false;
            this.dgvActivityList.AllowUserToResizeColumns = false;
            this.dgvActivityList.AllowUserToResizeRows = false;
            this.dgvActivityList.BackgroundColor = System.Drawing.Color.White;
            this.dgvActivityList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvActivityList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivityList.EnableHeadersVisualStyles = false;
            this.dgvActivityList.GridColor = System.Drawing.Color.White;
            this.dgvActivityList.Location = new System.Drawing.Point(59, 267);
            this.dgvActivityList.MultiSelect = false;
            this.dgvActivityList.Name = "dgvActivityList";
            this.dgvActivityList.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActivityList.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActivityList.RowTemplate.ReadOnly = true;
            this.dgvActivityList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvActivityList.Size = new System.Drawing.Size(676, 337);
            this.dgvActivityList.TabIndex = 0;
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLabel.Location = new System.Drawing.Point(59, 11);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(144, 36);
            this.invoiceLabel.TabIndex = 19;
            this.invoiceLabel.Text = "INVOICE";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(677, 608);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(58, 20);
            this.totalCost.TabIndex = 20;
            this.totalCost.Text = "£??.??";
            this.totalCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(59, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "KV5 3FU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Altis,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Aggelochori,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "24 Sandy Beaches,";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Away Day Planning";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "07444444444";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "enquires@adp.co.uk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(558, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total Cost:";
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapture.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(640, 6);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(148, 35);
            this.btnCapture.TabIndex = 12;
            this.btnCapture.Text = "Delete Me Please";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(748, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(253, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADP Billing Form";
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 727);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "billing";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label buyerPhoneLabel;
        private System.Windows.Forms.GroupBox Details;
        private System.Windows.Forms.Label buyerNameLabel;
        private System.Windows.Forms.Label buyerAddressLabel;
        private System.Windows.Forms.Label buyerEmailLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label invoiceLabel;
        private System.Windows.Forms.DataGridView dgvActivityList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}