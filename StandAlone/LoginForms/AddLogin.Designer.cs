namespace StandAlone.LoginForms
{
    partial class AddLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.guidelbl = new System.Windows.Forms.Label();
            this.Descrlbl = new System.Windows.Forms.Label();
            this.CmbUsername = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password:";
            // 
            // TbxPassword
            // 
            this.TbxPassword.Location = new System.Drawing.Point(98, 111);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(132, 20);
            this.TbxPassword.TabIndex = 12;
            this.TbxPassword.UseSystemPasswordChar = true;
            // 
            // guidelbl
            // 
            this.guidelbl.AutoSize = true;
            this.guidelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guidelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guidelbl.Location = new System.Drawing.Point(12, 72);
            this.guidelbl.Name = "guidelbl";
            this.guidelbl.Size = new System.Drawing.Size(77, 17);
            this.guidelbl.TabIndex = 15;
            this.guidelbl.Text = "Username:";
            // 
            // Descrlbl
            // 
            this.Descrlbl.AutoSize = true;
            this.Descrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Descrlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descrlbl.Location = new System.Drawing.Point(38, 9);
            this.Descrlbl.Name = "Descrlbl";
            this.Descrlbl.Size = new System.Drawing.Size(177, 25);
            this.Descrlbl.TabIndex = 13;
            this.Descrlbl.Text = "Add Login Process";
            // 
            // CmbUsername
            // 
            this.CmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsername.FormattingEnabled = true;
            this.CmbUsername.Location = new System.Drawing.Point(98, 71);
            this.CmbUsername.Name = "CmbUsername";
            this.CmbUsername.Size = new System.Drawing.Size(132, 21);
            this.CmbUsername.TabIndex = 16;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(82, 155);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 206);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.guidelbl);
            this.Controls.Add(this.Descrlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLogin";
            this.Text = "AddLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label guidelbl;
        private System.Windows.Forms.Label Descrlbl;
        private System.Windows.Forms.ComboBox CmbUsername;
        private System.Windows.Forms.Button BtnAdd;
    }
}