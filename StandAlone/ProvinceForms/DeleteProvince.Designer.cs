namespace StandAlone.ProvinceForms
{
  partial class DeleteProvince
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
            this.CmbUsers = new System.Windows.Forms.ComboBox();
            this.LblDescr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDelete.Location = new System.Drawing.Point(124, 85);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(12, 49);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(168, 17);
            this.LblGuide.TabIndex = 11;
            this.LblGuide.Text = "Select province to delete:";
            // 
            // CmbUsers
            // 
            this.CmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsers.FormattingEnabled = true;
            this.CmbUsers.Location = new System.Drawing.Point(186, 48);
            this.CmbUsers.Name = "CmbUsers";
            this.CmbUsers.Size = new System.Drawing.Size(121, 21);
            this.CmbUsers.TabIndex = 10;
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(53, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(225, 25);
            this.LblDescr.TabIndex = 9;
            this.LblDescr.Text = "Delete Province Process";
            // 
            // DeleteProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 117);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.CmbUsers);
            this.Controls.Add(this.LblDescr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteProvince";
            this.Text = "DeleteProvince";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnDelete;
    private System.Windows.Forms.Label LblGuide;
    private System.Windows.Forms.ComboBox CmbUsers;
    private System.Windows.Forms.Label LblDescr;
  }
}