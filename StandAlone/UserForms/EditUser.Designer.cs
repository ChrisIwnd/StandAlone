namespace StandAlone.UserForms
{
    partial class EditUser
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
            this.Guidelbl = new System.Windows.Forms.Label();
            this.Descrlbl = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.CmbUser = new System.Windows.Forms.ComboBox();
            this.CmbTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxTelephone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Guidelbl
            // 
            this.Guidelbl.AutoSize = true;
            this.Guidelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Guidelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Guidelbl.Location = new System.Drawing.Point(96, 107);
            this.Guidelbl.Name = "Guidelbl";
            this.Guidelbl.Size = new System.Drawing.Size(126, 17);
            this.Guidelbl.TabIndex = 14;
            this.Guidelbl.Text = "Select user to edit:";
            // 
            // Descrlbl
            // 
            this.Descrlbl.AutoSize = true;
            this.Descrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Descrlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descrlbl.Location = new System.Drawing.Point(90, 9);
            this.Descrlbl.Name = "Descrlbl";
            this.Descrlbl.Size = new System.Drawing.Size(341, 46);
            this.Descrlbl.TabIndex = 13;
            this.Descrlbl.Text = "Edit User Process";
            // 
            // BtnSelect
            // 
            this.BtnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSelect.Location = new System.Drawing.Point(356, 105);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 9;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // CmbUser
            // 
            this.CmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUser.FormattingEnabled = true;
            this.CmbUser.Location = new System.Drawing.Point(244, 107);
            this.CmbUser.Name = "CmbUser";
            this.CmbUser.Size = new System.Drawing.Size(106, 21);
            this.CmbUser.TabIndex = 8;
            // 
            // CmbTypes
            // 
            this.CmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypes.FormattingEnabled = true;
            this.CmbTypes.Location = new System.Drawing.Point(349, 145);
            this.CmbTypes.Name = "CmbTypes";
            this.CmbTypes.Size = new System.Drawing.Size(132, 21);
            this.CmbTypes.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(263, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(29, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telephone:";
            // 
            // TbxTelephone
            // 
            this.TbxTelephone.Location = new System.Drawing.Point(115, 149);
            this.TbxTelephone.Name = "TbxTelephone";
            this.TbxTelephone.Size = new System.Drawing.Size(132, 20);
            this.TbxTelephone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(263, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-mail:";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(349, 107);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(132, 20);
            this.TbxEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(29, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username:";
            // 
            // TbxUsername
            // 
            this.TbxUsername.Location = new System.Drawing.Point(115, 107);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(132, 20);
            this.TbxUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(263, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last Name:";
            // 
            // TbxLastName
            // 
            this.TbxLastName.Location = new System.Drawing.Point(349, 68);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(132, 20);
            this.TbxLastName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(29, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "First Name:";
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Location = new System.Drawing.Point(115, 68);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(132, 20);
            this.TbxFirstName.TabIndex = 0;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(221, 185);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 6;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 230);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.CmbTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxTelephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbxFirstName);
            this.Controls.Add(this.Guidelbl);
            this.Controls.Add(this.Descrlbl);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.CmbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Guidelbl;
        private System.Windows.Forms.Label Descrlbl;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.ComboBox CmbUser;
        private System.Windows.Forms.ComboBox CmbTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxTelephone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxFirstName;
        private System.Windows.Forms.Button BtnEdit;
    }
}