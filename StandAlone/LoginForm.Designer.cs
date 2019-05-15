namespace StandAlone
{
    partial class LoginForm
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
            this.LblDescr = new System.Windows.Forms.Label();
            this.LblGuide = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(84, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(78, 25);
            this.LblDescr.TabIndex = 11;
            this.LblDescr.Text = "LOGIN ";
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(12, 85);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(77, 17);
            this.LblGuide.TabIndex = 13;
            this.LblGuide.Text = "Password :";
            // 
            // TbxPassword
            // 
            this.TbxPassword.Location = new System.Drawing.Point(99, 85);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(132, 20);
            this.TbxPassword.TabIndex = 12;
            this.TbxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username :";
            // 
            // TbxUsername
            // 
            this.TbxUsername.Location = new System.Drawing.Point(99, 52);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(132, 20);
            this.TbxUsername.TabIndex = 14;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLogin.Location = new System.Drawing.Point(75, 122);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(87, 27);
            this.BtnLogin.TabIndex = 16;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 162);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.LblDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDescr;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.Button BtnLogin;
    }
}