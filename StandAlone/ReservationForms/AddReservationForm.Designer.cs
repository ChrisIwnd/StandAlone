namespace StandAlone.ReservationForms
{
    partial class AddReservationForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmbUsername = new System.Windows.Forms.ComboBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.guidelbl = new System.Windows.Forms.Label();
            this.Descrlbl = new System.Windows.Forms.Label();
            this.CmbBusiness = new System.Windows.Forms.ComboBox();
            this.LblPerson = new System.Windows.Forms.Label();
            this.TbxPerson = new System.Windows.Forms.TextBox();
            this.LblBusiness = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(230, 109);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 23;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmbUsername
            // 
            this.CmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsername.FormattingEnabled = true;
            this.CmbUsername.Location = new System.Drawing.Point(98, 43);
            this.CmbUsername.Name = "CmbUsername";
            this.CmbUsername.Size = new System.Drawing.Size(132, 21);
            this.CmbUsername.TabIndex = 22;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDate.Location = new System.Drawing.Point(12, 83);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(73, 17);
            this.LblDate.TabIndex = 20;
            this.LblDate.Text = "Password:";
            // 
            // guidelbl
            // 
            this.guidelbl.AutoSize = true;
            this.guidelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guidelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guidelbl.Location = new System.Drawing.Point(12, 44);
            this.guidelbl.Name = "guidelbl";
            this.guidelbl.Size = new System.Drawing.Size(77, 17);
            this.guidelbl.TabIndex = 21;
            this.guidelbl.Text = "Username:";
            // 
            // Descrlbl
            // 
            this.Descrlbl.AutoSize = true;
            this.Descrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Descrlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descrlbl.Location = new System.Drawing.Point(155, 9);
            this.Descrlbl.Name = "Descrlbl";
            this.Descrlbl.Size = new System.Drawing.Size(232, 25);
            this.Descrlbl.TabIndex = 19;
            this.Descrlbl.Text = "Add Reservation Process";
            // 
            // CmbBusiness
            // 
            this.CmbBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBusiness.FormattingEnabled = true;
            this.CmbBusiness.Location = new System.Drawing.Point(324, 43);
            this.CmbBusiness.Name = "CmbBusiness";
            this.CmbBusiness.Size = new System.Drawing.Size(185, 21);
            this.CmbBusiness.TabIndex = 27;
            // 
            // LblPerson
            // 
            this.LblPerson.AutoSize = true;
            this.LblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblPerson.Location = new System.Drawing.Point(245, 83);
            this.LblPerson.Name = "LblPerson";
            this.LblPerson.Size = new System.Drawing.Size(61, 17);
            this.LblPerson.TabIndex = 25;
            this.LblPerson.Text = "Person :";
            // 
            // TbxPerson
            // 
            this.TbxPerson.Location = new System.Drawing.Point(324, 83);
            this.TbxPerson.Name = "TbxPerson";
            this.TbxPerson.Size = new System.Drawing.Size(185, 20);
            this.TbxPerson.TabIndex = 24;
            // 
            // LblBusiness
            // 
            this.LblBusiness.AutoSize = true;
            this.LblBusiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblBusiness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblBusiness.Location = new System.Drawing.Point(245, 44);
            this.LblBusiness.Name = "LblBusiness";
            this.LblBusiness.Size = new System.Drawing.Size(73, 17);
            this.LblBusiness.TabIndex = 26;
            this.LblBusiness.Text = "Business :";
            // 
            // DtpDate
            // 
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(98, 83);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(132, 20);
            this.DtpDate.TabIndex = 28;
            // 
            // AddReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 151);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.CmbBusiness);
            this.Controls.Add(this.LblPerson);
            this.Controls.Add(this.TbxPerson);
            this.Controls.Add(this.LblBusiness);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmbUsername);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.guidelbl);
            this.Controls.Add(this.Descrlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReservationForm";
            this.Text = "AddReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CmbUsername;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label guidelbl;
        private System.Windows.Forms.Label Descrlbl;
        private System.Windows.Forms.ComboBox CmbBusiness;
        private System.Windows.Forms.Label LblPerson;
        private System.Windows.Forms.TextBox TbxPerson;
        private System.Windows.Forms.Label LblBusiness;
        private System.Windows.Forms.DateTimePicker DtpDate;
    }
}