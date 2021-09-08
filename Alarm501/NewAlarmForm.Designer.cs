namespace Alarm501
{
    partial class NewAlarmForm
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
            this.uxDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxSetOnOff = new System.Windows.Forms.CheckBox();
            this.uxCancelBtn = new System.Windows.Forms.Button();
            this.uxSetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDateTimePicker
            // 
            this.uxDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxDateTimePicker.Location = new System.Drawing.Point(41, 38);
            this.uxDateTimePicker.Name = "uxDateTimePicker";
            this.uxDateTimePicker.Size = new System.Drawing.Size(330, 22);
            this.uxDateTimePicker.TabIndex = 0;
            // 
            // uxSetOnOff
            // 
            this.uxSetOnOff.AutoSize = true;
            this.uxSetOnOff.Location = new System.Drawing.Point(410, 39);
            this.uxSetOnOff.Name = "uxSetOnOff";
            this.uxSetOnOff.Size = new System.Drawing.Size(49, 21);
            this.uxSetOnOff.TabIndex = 1;
            this.uxSetOnOff.Text = "Off";
            this.uxSetOnOff.UseVisualStyleBackColor = true;
            this.uxSetOnOff.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // uxCancelBtn
            // 
            this.uxCancelBtn.Location = new System.Drawing.Point(12, 131);
            this.uxCancelBtn.Name = "uxCancelBtn";
            this.uxCancelBtn.Size = new System.Drawing.Size(120, 50);
            this.uxCancelBtn.TabIndex = 2;
            this.uxCancelBtn.Text = "Cancel";
            this.uxCancelBtn.UseVisualStyleBackColor = true;
            this.uxCancelBtn.Click += new System.EventHandler(this.uxCancelBtn_Click);
            // 
            // uxSetBtn
            // 
            this.uxSetBtn.Location = new System.Drawing.Point(400, 131);
            this.uxSetBtn.Name = "uxSetBtn";
            this.uxSetBtn.Size = new System.Drawing.Size(120, 50);
            this.uxSetBtn.TabIndex = 3;
            this.uxSetBtn.Text = "Set";
            this.uxSetBtn.UseVisualStyleBackColor = true;
            this.uxSetBtn.Click += new System.EventHandler(this.uxSetBtn_Click);
            // 
            // NewAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 193);
            this.Controls.Add(this.uxSetBtn);
            this.Controls.Add(this.uxCancelBtn);
            this.Controls.Add(this.uxSetOnOff);
            this.Controls.Add(this.uxDateTimePicker);
            this.Name = "NewAlarmForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxDateTimePicker;
        private System.Windows.Forms.CheckBox uxSetOnOff;
        private System.Windows.Forms.Button uxCancelBtn;
        private System.Windows.Forms.Button uxSetBtn;
    }
}