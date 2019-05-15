namespace StandAlone.LoginForms
{
    partial class EditLogin
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
            this.DescrLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbUsername = new System.Windows.Forms.ComboBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.guidelbl = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DescrLbl
            // 
            this.DescrLbl.AutoSize = true;
            this.DescrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DescrLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DescrLbl.Location = new System.Drawing.Point(38, 9);
            this.DescrLbl.Name = "DescrLbl";
            this.DescrLbl.Size = new System.Drawing.Size(301, 39);
            this.DescrLbl.TabIndex = 22;
            this.DescrLbl.Text = "Edit Login Process";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select the login that you want to edit:";
            // 
            // CmbUsername
            // 
            this.CmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsername.FormattingEnabled = true;
            this.CmbUsername.Location = new System.Drawing.Point(262, 80);
            this.CmbUsername.Name = "CmbUsername";
            this.CmbUsername.Size = new System.Drawing.Size(121, 21);
            this.CmbUsername.TabIndex = 24;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(144, 141);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(74, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password:";
            // 
            // TbxPassword
            // 
            this.TbxPassword.Location = new System.Drawing.Point(160, 97);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(132, 20);
            this.TbxPassword.TabIndex = 25;
            this.TbxPassword.UseSystemPasswordChar = true;
            // 
            // guidelbl
            // 
            this.guidelbl.AutoSize = true;
            this.guidelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guidelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guidelbl.Location = new System.Drawing.Point(74, 58);
            this.guidelbl.Name = "guidelbl";
            this.guidelbl.Size = new System.Drawing.Size(77, 17);
            this.guidelbl.TabIndex = 27;
            this.guidelbl.Text = "Username:";
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(144, 141);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 30;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // TbxUsername
            // 
            this.TbxUsername.Location = new System.Drawing.Point(160, 58);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.ReadOnly = true;
            this.TbxUsername.Size = new System.Drawing.Size(132, 20);
            this.TbxUsername.TabIndex = 31;
            // 
            // EditLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.guidelbl);
            this.Controls.Add(this.CmbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescrLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLogin";
            this.Text = "EditLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescrLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbUsername;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label guidelbl;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox TbxUsername;
    }
}