namespace Alarm501
{
    partial class Alarm501
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
            this.uxAddBtn = new System.Windows.Forms.Button();
            this.uxEditBtn = new System.Windows.Forms.Button();
            this.uxAlarmList = new System.Windows.Forms.ListBox();
            this.uxSnoozeBtn = new System.Windows.Forms.Button();
            this.uxStopBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAddBtn
            // 
            this.uxAddBtn.Location = new System.Drawing.Point(196, 39);
            this.uxAddBtn.Name = "uxAddBtn";
            this.uxAddBtn.Size = new System.Drawing.Size(100, 50);
            this.uxAddBtn.TabIndex = 0;
            this.uxAddBtn.Text = "+";
            this.uxAddBtn.UseVisualStyleBackColor = true;
            this.uxAddBtn.Click += new System.EventHandler(this.uxAddBtn_Click);
            // 
            // uxEditBtn
            // 
            this.uxEditBtn.Location = new System.Drawing.Point(37, 39);
            this.uxEditBtn.Name = "uxEditBtn";
            this.uxEditBtn.Size = new System.Drawing.Size(100, 50);
            this.uxEditBtn.TabIndex = 1;
            this.uxEditBtn.Text = "Edit";
            this.uxEditBtn.UseVisualStyleBackColor = true;
            this.uxEditBtn.Click += new System.EventHandler(this.uxEditBtn_Click);
            // 
            // uxAlarmList
            // 
            this.uxAlarmList.FormattingEnabled = true;
            this.uxAlarmList.ItemHeight = 16;
            this.uxAlarmList.Location = new System.Drawing.Point(37, 117);
            this.uxAlarmList.Name = "uxAlarmList";
            this.uxAlarmList.Size = new System.Drawing.Size(259, 180);
            this.uxAlarmList.TabIndex = 2;
            // 
            // uxSnoozeBtn
            // 
            this.uxSnoozeBtn.Location = new System.Drawing.Point(37, 368);
            this.uxSnoozeBtn.Name = "uxSnoozeBtn";
            this.uxSnoozeBtn.Size = new System.Drawing.Size(100, 50);
            this.uxSnoozeBtn.TabIndex = 3;
            this.uxSnoozeBtn.Text = "Snooze";
            this.uxSnoozeBtn.UseVisualStyleBackColor = true;
            this.uxSnoozeBtn.Click += new System.EventHandler(this.uxSnoozeBtn_Click);
            // 
            // uxStopBtn
            // 
            this.uxStopBtn.Location = new System.Drawing.Point(196, 368);
            this.uxStopBtn.Name = "uxStopBtn";
            this.uxStopBtn.Size = new System.Drawing.Size(100, 50);
            this.uxStopBtn.TabIndex = 4;
            this.uxStopBtn.Text = "Stop";
            this.uxStopBtn.UseVisualStyleBackColor = true;
            this.uxStopBtn.Click += new System.EventHandler(this.uxStopBtn_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 300);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(300, 55);
            this.label.TabIndex = 5;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 453);
            this.Controls.Add(this.label);
            this.Controls.Add(this.uxStopBtn);
            this.Controls.Add(this.uxSnoozeBtn);
            this.Controls.Add(this.uxAlarmList);
            this.Controls.Add(this.uxEditBtn);
            this.Controls.Add(this.uxAddBtn);
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxAddBtn;
        private System.Windows.Forms.Button uxEditBtn;
        private System.Windows.Forms.ListBox uxAlarmList;
        private System.Windows.Forms.Button uxSnoozeBtn;
        private System.Windows.Forms.Button uxStopBtn;
        private System.Windows.Forms.Label label;
    }
}

