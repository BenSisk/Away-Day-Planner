namespace awayDayPlanner.GUI
{
    partial class ControlPanelForm
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
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.btnExistingEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Location = new System.Drawing.Point(258, 82);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(252, 114);
            this.btnNewEvent.TabIndex = 0;
            this.btnNewEvent.Text = "Plan New Away Day";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // btnExistingEvents
            // 
            this.btnExistingEvents.Location = new System.Drawing.Point(258, 262);
            this.btnExistingEvents.Name = "btnExistingEvents";
            this.btnExistingEvents.Size = new System.Drawing.Size(252, 114);
            this.btnExistingEvents.TabIndex = 1;
            this.btnExistingEvents.Text = "View Your Planned Away Days";
            this.btnExistingEvents.UseVisualStyleBackColor = true;
            this.btnExistingEvents.Click += new System.EventHandler(this.btnExistingEvents_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExistingEvents);
            this.Controls.Add(this.btnNewEvent);
            this.Name = "ControlPanelForm";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Button btnExistingEvents;
    }
}