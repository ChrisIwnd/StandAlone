namespace StandAlone.WorkHoursForms
{
    partial class EditWorkHours
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
            this.DtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.DtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.LblDays = new System.Windows.Forms.Label();
            this.LblStartTime = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LblDescr = new System.Windows.Forms.Label();
            this.CmbWorkHours = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DtpEndTime
            // 
            this.DtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpEndTime.Location = new System.Drawing.Point(137, 89);
            this.DtpEndTime.Name = "DtpEndTime";
            this.DtpEndTime.ShowUpDown = true;
            this.DtpEndTime.Size = new System.Drawing.Size(132, 20);
            this.DtpEndTime.TabIndex = 53;
            // 
            // DtpStartTime
            // 
            this.DtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpStartTime.Location = new System.Drawing.Point(137, 58);
            this.DtpStartTime.Name = "DtpStartTime";
            this.DtpStartTime.ShowUpDown = true;
            this.DtpStartTime.Size = new System.Drawing.Size(132, 20);
            this.DtpStartTime.TabIndex = 52;
            // 
            // CmbDays
            // 
            this.CmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(137, 124);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(132, 21);
            this.CmbDays.TabIndex = 51;
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblEndTime.Location = new System.Drawing.Point(14, 89);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(72, 17);
            this.LblEndTime.TabIndex = 46;
            this.LblEndTime.Text = "End Time:";
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDays.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDays.Location = new System.Drawing.Point(14, 125);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(48, 17);
            this.LblDays.TabIndex = 50;
            this.LblDays.Text = "Days :";
            // 
            // LblStartTime
            // 
            this.LblStartTime.AutoSize = true;
            this.LblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblStartTime.Location = new System.Drawing.Point(14, 58);
            this.LblStartTime.Name = "LblStartTime";
            this.LblStartTime.Size = new System.Drawing.Size(81, 17);
            this.LblStartTime.TabIndex = 49;
            this.LblStartTime.Text = "Start Time :";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEdit.Location = new System.Drawing.Point(100, 173);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(87, 27);
            this.BtnEdit.TabIndex = 47;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(24, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(230, 25);
            this.LblDescr.TabIndex = 48;
            this.LblDescr.Text = "Edit Work Hours Process";
            // 
            // CmbWorkHours
            // 
            this.CmbWorkHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbWorkHours.FormattingEnabled = true;
            this.CmbWorkHours.Location = new System.Drawing.Point(137, 88);
            this.CmbWorkHours.Name = "CmbWorkHours";
            this.CmbWorkHours.Size = new System.Drawing.Size(132, 21);
            this.CmbWorkHours.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Select work hour :";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSelect.Location = new System.Drawing.Point(100, 173);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(87, 27);
            this.BtnSelect.TabIndex = 56;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // EditWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 216);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.CmbWorkHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpEndTime);
            this.Controls.Add(this.DtpStartTime);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.LblEndTime);
            this.Controls.Add(this.LblDays);
            this.Controls.Add(this.LblStartTime);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LblDescr);
            this.Name = "EditWorkHours";
            this.Text = "EditWorkHours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpEndTime;
        private System.Windows.Forms.DateTimePicker DtpStartTime;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.Label LblDays;
        private System.Windows.Forms.Label LblStartTime;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label LblDescr;
        private System.Windows.Forms.ComboBox CmbWorkHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelect;
    }
}