namespace StandAlone.UserTypesForms
{
    partial class EditUsersTypes
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
            this.LblGuide1 = new System.Windows.Forms.Label();
            this.LblGuide = new System.Windows.Forms.Label();
            this.DescrLbl = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TbxEditiUsersTypes = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.CmbUsersTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblGuide1
            // 
            this.LblGuide1.AutoSize = true;
            this.LblGuide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide1.Location = new System.Drawing.Point(46, 72);
            this.LblGuide1.Name = "LblGuide1";
            this.LblGuide1.Size = new System.Drawing.Size(123, 17);
            this.LblGuide1.TabIndex = 23;
            this.LblGuide1.Text = "Edit the user type:";
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(12, 72);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(157, 17);
            this.LblGuide.TabIndex = 22;
            this.LblGuide.Text = "Select user type to edit:";
            // 
            // DescrLbl
            // 
            this.DescrLbl.AutoSize = true;
            this.DescrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DescrLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DescrLbl.Location = new System.Drawing.Point(12, 9);
            this.DescrLbl.Name = "DescrLbl";
            this.DescrLbl.Size = new System.Drawing.Size(352, 39);
            this.DescrLbl.TabIndex = 21;
            this.DescrLbl.Text = "Edit user type process";
            // 
            // BtnEdit
            // 
            this.BtnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEdit.Location = new System.Drawing.Point(146, 108);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 19;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TbxEditiUsersTypes
            // 
            this.TbxEditiUsersTypes.Location = new System.Drawing.Point(175, 71);
            this.TbxEditiUsersTypes.Name = "TbxEditiUsersTypes";
            this.TbxEditiUsersTypes.Size = new System.Drawing.Size(106, 20);
            this.TbxEditiUsersTypes.TabIndex = 18;
            // 
            // BtnSelect
            // 
            this.BtnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSelect.Location = new System.Drawing.Point(287, 69);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 17;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // CmbUsersTypes
            // 
            this.CmbUsersTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsersTypes.FormattingEnabled = true;
            this.CmbUsersTypes.Location = new System.Drawing.Point(175, 71);
            this.CmbUsersTypes.Name = "CmbUsersTypes";
            this.CmbUsersTypes.Size = new System.Drawing.Size(106, 21);
            this.CmbUsersTypes.TabIndex = 16;
            // 
            // EditUsersTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 144);
            this.Controls.Add(this.LblGuide1);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.DescrLbl);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TbxEditiUsersTypes);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.CmbUsersTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditUsersTypes";
            this.Text = "EditUsersTypes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGuide1;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.Label DescrLbl;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TbxEditiUsersTypes;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.ComboBox CmbUsersTypes;
    }
}