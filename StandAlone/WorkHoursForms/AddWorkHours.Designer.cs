namespace StandAlone.WorkHoursForms
{
    partial class AddWorkHours
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
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.LblDays = new System.Windows.Forms.Label();
            this.LblStartTime = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.LblDescr = new System.Windows.Forms.Label();
            this.DtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.DtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CmbDays
            // 
            this.CmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(135, 124);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(132, 21);
            this.CmbDays.TabIndex = 43;
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblEndTime.Location = new System.Drawing.Point(12, 89);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(72, 17);
            this.LblEndTime.TabIndex = 30;
            this.LblEndTime.Text = "End Time:";
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDays.Location = new System.Drawing.Point(12, 125);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(48, 17);
            this.LblDays.TabIndex = 40;
            this.LblDays.Text = "Days :";
            // 
            // LblStartTime
            // 
            this.LblStartTime.AutoSize = true;
            this.LblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblStartTime.Location = new System.Drawing.Point(12, 58);
            this.LblStartTime.Name = "LblStartTime";
            this.LblStartTime.Size = new System.Drawing.Size(81, 17);
            this.LblStartTime.TabIndex = 39;
            this.LblStartTime.Text = "Start Time :";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Addbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Addbtn.Location = new System.Drawing.Point(98, 173);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(87, 27);
            this.Addbtn.TabIndex = 35;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(22, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(233, 25);
            this.LblDescr.TabIndex = 36;
            this.LblDescr.Text = "Add Work Hours Process";
            // 
            // DtpStartTime
            // 
            this.DtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpStartTime.Location = new System.Drawing.Point(135, 58);
            this.DtpStartTime.Name = "DtpStartTime";
            this.DtpStartTime.ShowUpDown = true;
            this.DtpStartTime.Size = new System.Drawing.Size(132, 20);
            this.DtpStartTime.TabIndex = 44;
            // 
            // DtpEndTime
            // 
            this.DtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpEndTime.Location = new System.Drawing.Point(135, 89);
            this.DtpEndTime.Name = "DtpEndTime";
            this.DtpEndTime.ShowUpDown = true;
            this.DtpEndTime.Size = new System.Drawing.Size(132, 20);
            this.DtpEndTime.TabIndex = 45;
            // 
            // AddWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 219);
            this.Controls.Add(this.DtpEndTime);
            this.Controls.Add(this.DtpStartTime);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.LblEndTime);
            this.Controls.Add(this.LblDays);
            this.Controls.Add(this.LblStartTime);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.LblDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWorkHours";
            this.Text = "AddWorkHours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.Label LblDays;
        private System.Windows.Forms.Label LblStartTime;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label LblDescr;
        private System.Windows.Forms.DateTimePicker DtpStartTime;
        private System.Windows.Forms.DateTimePicker DtpEndTime;
    }
}