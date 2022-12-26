namespace awayDayPlanner.GUI
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFirstLine = new System.Windows.Forms.Label();
            this.txtFirstline = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSecondLine = new System.Windows.Forms.Label();
            this.txtSecondline = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.Details = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tltPassword = new System.Windows.Forms.ToolTip(this.components);
            this.tltPasswordError = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.Details.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(211, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADP Registration Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.Details);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 388);
            this.panel2.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(532, 322);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(148, 35);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Submit";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.flowLayoutPanel10);
            this.groupBox2.Controls.Add(this.flowLayoutPanel7);
            this.groupBox2.Controls.Add(this.flowLayoutPanel9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(433, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 152);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Details";
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel10.Controls.Add(this.lblConfirm);
            this.flowLayoutPanel10.Controls.Add(this.txtPassword2);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(6, 104);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel10.TabIndex = 5;
            // 
            // lblConfirm
            // 
            this.lblConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(3, 6);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(91, 21);
            this.lblConfirm.TabIndex = 2;
            this.lblConfirm.Text = "Confirm:    ";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(100, 3);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(205, 27);
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel7.Controls.Add(this.lblUsername);
            this.flowLayoutPanel7.Controls.Add(this.txtUsername);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(6, 26);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel7.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 6);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(101, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 27);
            this.txtUsername.TabIndex = 3;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel9.Controls.Add(this.lblPassword);
            this.flowLayoutPanel9.Controls.Add(this.txtPassword);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(6, 65);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel9.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 6);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 21);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password: ";
            this.tltPassword.SetToolTip(this.lblPassword, "Password must be 5 Characters or Larger");
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(205, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.flowLayoutPanel5);
            this.groupBox1.Controls.Add(this.flowLayoutPanel6);
            this.groupBox1.Controls.Add(this.flowLayoutPanel8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(433, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel5.Controls.Add(this.lblFirstLine);
            this.flowLayoutPanel5.Controls.Add(this.txtFirstline);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(6, 26);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // lblFirstLine
            // 
            this.lblFirstLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstLine.AutoSize = true;
            this.lblFirstLine.Location = new System.Drawing.Point(3, 6);
            this.lblFirstLine.Name = "lblFirstLine";
            this.lblFirstLine.Size = new System.Drawing.Size(85, 21);
            this.lblFirstLine.TabIndex = 2;
            this.lblFirstLine.Text = "First Line:  ";
            // 
            // txtFirstline
            // 
            this.txtFirstline.Location = new System.Drawing.Point(94, 3);
            this.txtFirstline.Name = "txtFirstline";
            this.txtFirstline.Size = new System.Drawing.Size(210, 27);
            this.txtFirstline.TabIndex = 3;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel6.Controls.Add(this.lblSecondLine);
            this.flowLayoutPanel6.Controls.Add(this.txtSecondline);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(6, 65);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel6.TabIndex = 4;
            // 
            // lblSecondLine
            // 
            this.lblSecondLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSecondLine.AutoSize = true;
            this.lblSecondLine.Location = new System.Drawing.Point(3, 6);
            this.lblSecondLine.Name = "lblSecondLine";
            this.lblSecondLine.Size = new System.Drawing.Size(84, 21);
            this.lblSecondLine.TabIndex = 2;
            this.lblSecondLine.Text = "Town:       ";
            // 
            // txtSecondline
            // 
            this.txtSecondline.Location = new System.Drawing.Point(93, 3);
            this.txtSecondline.Name = "txtSecondline";
            this.txtSecondline.Size = new System.Drawing.Size(211, 27);
            this.txtSecondline.TabIndex = 3;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel8.Controls.Add(this.lblPostcode);
            this.flowLayoutPanel8.Controls.Add(this.txtPostcode);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(6, 104);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel8.TabIndex = 5;
            // 
            // lblPostcode
            // 
            this.lblPostcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(3, 6);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(87, 21);
            this.lblPostcode.TabIndex = 2;
            this.lblPostcode.Text = "Postcode:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPostcode.Location = new System.Drawing.Point(96, 3);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(208, 27);
            this.txtPostcode.TabIndex = 3;
            // 
            // Details
            // 
            this.Details.BackColor = System.Drawing.Color.Gainsboro;
            this.Details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Details.Controls.Add(this.flowLayoutPanel1);
            this.Details.Controls.Add(this.flowLayoutPanel2);
            this.Details.Controls.Add(this.flowLayoutPanel11);
            this.Details.Controls.Add(this.flowLayoutPanel4);
            this.Details.Controls.Add(this.flowLayoutPanel3);
            this.Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Details.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Details.Location = new System.Drawing.Point(45, 48);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(320, 236);
            this.Details.TabIndex = 1;
            this.Details.TabStop = false;
            this.Details.Text = "Details";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel1.Controls.Add(this.lblFirstName);
            this.flowLayoutPanel1.Controls.Add(this.txtFirstname);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(99, 21);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(108, 3);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(194, 27);
            this.txtFirstname.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel2.Controls.Add(this.lblLastName);
            this.flowLayoutPanel2.Controls.Add(this.txtLastname);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 65);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 6);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(97, 21);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(106, 3);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(196, 27);
            this.txtLastname.TabIndex = 3;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel11.Controls.Add(this.lblPhone);
            this.flowLayoutPanel11.Controls.Add(this.txtPhone);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(6, 187);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel11.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 6);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(95, 21);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:        ";
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhone.Location = new System.Drawing.Point(104, 3);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel4.Controls.Add(this.lblDOB);
            this.flowLayoutPanel4.Controls.Add(this.dtpDOB);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 143);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(3, 6);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(97, 21);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "DOB             ";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(106, 3);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(195, 27);
            this.dtpDOB.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(148)))), ((int)(((byte)(3)))));
            this.flowLayoutPanel3.Controls.Add(this.lblEmail);
            this.flowLayoutPanel3.Controls.Add(this.txtEmail);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 104);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(308, 33);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(99, 21);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:           ";
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEmail.Location = new System.Drawing.Point(108, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // tltPassword
            // 
            this.tltPassword.IsBalloon = true;
            // 
            // tltPasswordError
            // 
            this.tltPasswordError.ForeColor = System.Drawing.Color.Red;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.Details.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Details;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lblFirstLine;
        private System.Windows.Forms.TextBox txtFirstline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label lblSecondLine;
        private System.Windows.Forms.TextBox txtSecondline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ToolTip tltPassword;
        private System.Windows.Forms.ToolTip tltPasswordError;
    }
}