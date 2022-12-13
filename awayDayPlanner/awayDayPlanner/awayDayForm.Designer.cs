namespace awayDayPlanner
{
    partial class awayDayForm
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
            this.chbx_Activity1 = new System.Windows.Forms.CheckBox();
            this.chbx_Activity2 = new System.Windows.Forms.CheckBox();
            this.chbx_Activity3 = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txt_estimatedCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chbx_Activity1
            // 
            this.chbx_Activity1.AutoSize = true;
            this.chbx_Activity1.Location = new System.Drawing.Point(131, 50);
            this.chbx_Activity1.Name = "chbx_Activity1";
            this.chbx_Activity1.Size = new System.Drawing.Size(69, 17);
            this.chbx_Activity1.TabIndex = 0;
            this.chbx_Activity1.Text = "Activity 1";
            this.chbx_Activity1.UseVisualStyleBackColor = true;
            this.chbx_Activity1.CheckedChanged += new System.EventHandler(this.chbx_Activity1_CheckedChanged);
            // 
            // chbx_Activity2
            // 
            this.chbx_Activity2.AutoSize = true;
            this.chbx_Activity2.Location = new System.Drawing.Point(131, 73);
            this.chbx_Activity2.Name = "chbx_Activity2";
            this.chbx_Activity2.Size = new System.Drawing.Size(69, 17);
            this.chbx_Activity2.TabIndex = 1;
            this.chbx_Activity2.Text = "Activity 2";
            this.chbx_Activity2.UseVisualStyleBackColor = true;
            this.chbx_Activity2.CheckedChanged += new System.EventHandler(this.chbx_Activity2_CheckedChanged);
            // 
            // chbx_Activity3
            // 
            this.chbx_Activity3.AutoSize = true;
            this.chbx_Activity3.Location = new System.Drawing.Point(131, 96);
            this.chbx_Activity3.Name = "chbx_Activity3";
            this.chbx_Activity3.Size = new System.Drawing.Size(69, 17);
            this.chbx_Activity3.TabIndex = 2;
            this.chbx_Activity3.Text = "Activity 3";
            this.chbx_Activity3.UseVisualStyleBackColor = true;
            this.chbx_Activity3.CheckedChanged += new System.EventHandler(this.chbx_Activity3_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(289, 105);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 61);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txt_estimatedCost
            // 
            this.txt_estimatedCost.Location = new System.Drawing.Point(272, 229);
            this.txt_estimatedCost.Name = "txt_estimatedCost";
            this.txt_estimatedCost.ReadOnly = true;
            this.txt_estimatedCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_estimatedCost.Size = new System.Drawing.Size(212, 20);
            this.txt_estimatedCost.TabIndex = 4;
            // 
            // awayDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_estimatedCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chbx_Activity3);
            this.Controls.Add(this.chbx_Activity2);
            this.Controls.Add(this.chbx_Activity1);
            this.Name = "awayDayForm";
            this.Text = "awayDay_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbx_Activity1;
        private System.Windows.Forms.CheckBox chbx_Activity2;
        private System.Windows.Forms.CheckBox chbx_Activity3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txt_estimatedCost;
    }
}

