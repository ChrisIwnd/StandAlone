namespace StandAlone.DaysForms
{
    partial class DeleteDays
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblGuide = new System.Windows.Forms.Label();
            this.CmbDay = new System.Windows.Forms.ComboBox();
            this.LblDescr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDelete.Location = new System.Drawing.Point(100, 92);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(12, 55);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(137, 17);
            this.LblGuide.TabIndex = 15;
            this.LblGuide.Text = "Select day to delete:";
            // 
            // CmbDay
            // 
            this.CmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDay.FormattingEnabled = true;
            this.CmbDay.Location = new System.Drawing.Point(155, 54);
            this.CmbDay.Name = "CmbDay";
            this.CmbDay.Size = new System.Drawing.Size(121, 21);
            this.CmbDay.TabIndex = 14;
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(43, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(194, 25);
            this.LblDescr.TabIndex = 13;
            this.LblDescr.Text = "Delete Days Process";
            // 
            // DeleteDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 127);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.CmbDay);
            this.Controls.Add(this.LblDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteDays";
            this.Text = "DeleteDays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.ComboBox CmbDay;
        private System.Windows.Forms.Label LblDescr;
    }
}