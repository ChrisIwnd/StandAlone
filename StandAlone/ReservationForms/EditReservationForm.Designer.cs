namespace StandAlone.ReservationForms
{
    partial class EditReservationForm
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
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.CmbBusiness = new System.Windows.Forms.ComboBox();
            this.LblPerson = new System.Windows.Forms.Label();
            this.TbxPerson = new System.Windows.Forms.TextBox();
            this.LblBusiness = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.CmbUsername = new System.Windows.Forms.ComboBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.Descrlbl = new System.Windows.Forms.Label();
            this.CmbSelect = new System.Windows.Forms.ComboBox();
            this.LblSelect = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(103, 83);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(132, 20);
            this.DtpDate.TabIndex = 38;
            // 
            // CmbBusiness
            // 
            this.CmbBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBusiness.FormattingEnabled = true;
            this.CmbBusiness.Location = new System.Drawing.Point(329, 43);
            this.CmbBusiness.Name = "CmbBusiness";
            this.CmbBusiness.Size = new System.Drawing.Size(185, 21);
            this.CmbBusiness.TabIndex = 37;
            // 
            // LblPerson
            // 
            this.LblPerson.AutoSize = true;
            this.LblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblPerson.Location = new System.Drawing.Point(250, 83);
            this.LblPerson.Name = "LblPerson";
            this.LblPerson.Size = new System.Drawing.Size(61, 17);
            this.LblPerson.TabIndex = 35;
            this.LblPerson.Text = "Person :";
            // 
            // TbxPerson
            // 
            this.TbxPerson.Location = new System.Drawing.Point(329, 83);
            this.TbxPerson.Name = "TbxPerson";
            this.TbxPerson.Size = new System.Drawing.Size(185, 20);
            this.TbxPerson.TabIndex = 34;
            // 
            // LblBusiness
            // 
            this.LblBusiness.AutoSize = true;
            this.LblBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblBusiness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblBusiness.Location = new System.Drawing.Point(250, 44);
            this.LblBusiness.Name = "LblBusiness";
            this.LblBusiness.Size = new System.Drawing.Size(73, 17);
            this.LblBusiness.TabIndex = 36;
            this.LblBusiness.Text = "Business :";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(235, 109);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 33;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // CmbUsername
            // 
            this.CmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsername.FormattingEnabled = true;
            this.CmbUsername.Location = new System.Drawing.Point(103, 43);
            this.CmbUsername.Name = "CmbUsername";
            this.CmbUsername.Size = new System.Drawing.Size(132, 21);
            this.CmbUsername.TabIndex = 32;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDate.Location = new System.Drawing.Point(17, 83);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(73, 17);
            this.LblDate.TabIndex = 30;
            this.LblDate.Text = "Password:";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblUsername.Location = new System.Drawing.Point(17, 44);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(77, 17);
            this.LblUsername.TabIndex = 31;
            this.LblUsername.Text = "Username:";
            // 
            // Descrlbl
            // 
            this.Descrlbl.AutoSize = true;
            this.Descrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Descrlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descrlbl.Location = new System.Drawing.Point(160, 9);
            this.Descrlbl.Name = "Descrlbl";
            this.Descrlbl.Size = new System.Drawing.Size(232, 25);
            this.Descrlbl.TabIndex = 29;
            this.Descrlbl.Text = "Add Reservation Process";
            // 
            // CmbSelect
            // 
            this.CmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSelect.FormattingEnabled = true;
            this.CmbSelect.Location = new System.Drawing.Point(279, 62);
            this.CmbSelect.Name = "CmbSelect";
            this.CmbSelect.Size = new System.Drawing.Size(185, 21);
            this.CmbSelect.TabIndex = 40;
            // 
            // LblSelect
            // 
            this.LblSelect.AutoSize = true;
            this.LblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblSelect.Location = new System.Drawing.Point(115, 63);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(158, 17);
            this.LblSelect.TabIndex = 39;
            this.LblSelect.Text = "Select business to edit :";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(236, 109);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 41;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // EditReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 141);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.CmbSelect);
            this.Controls.Add(this.LblSelect);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.CmbBusiness);
            this.Controls.Add(this.LblPerson);
            this.Controls.Add(this.TbxPerson);
            this.Controls.Add(this.LblBusiness);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.CmbUsername);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.Descrlbl);
            this.Name = "EditReservationForm";
            this.Text = "EditReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.ComboBox CmbBusiness;
        private System.Windows.Forms.Label LblPerson;
        private System.Windows.Forms.TextBox TbxPerson;
        private System.Windows.Forms.Label LblBusiness;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ComboBox CmbUsername;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label Descrlbl;
        private System.Windows.Forms.ComboBox CmbSelect;
        private System.Windows.Forms.Label LblSelect;
        private System.Windows.Forms.Button BtnSelect;
    }
}