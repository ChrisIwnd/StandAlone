namespace StandAlone.ProvinceForms
{
  partial class EditProvince
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.labelpro = new System.Windows.Forms.Label();
            this.TbxProvinceName = new System.Windows.Forms.TextBox();
            this.Descrlbl = new System.Windows.Forms.Label();
            this.comboBoxptovince = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(161, 83);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 38;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // labelpro
            // 
            this.labelpro.AutoSize = true;
            this.labelpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelpro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelpro.Location = new System.Drawing.Point(86, 49);
            this.labelpro.Name = "labelpro";
            this.labelpro.Size = new System.Drawing.Size(108, 17);
            this.labelpro.TabIndex = 43;
            this.labelpro.Text = "Province Name:";
            // 
            // TbxProvinceName
            // 
            this.TbxProvinceName.Location = new System.Drawing.Point(200, 48);
            this.TbxProvinceName.Name = "TbxProvinceName";
            this.TbxProvinceName.Size = new System.Drawing.Size(132, 20);
            this.TbxProvinceName.TabIndex = 32;
            // 
            // Descrlbl
            // 
            this.Descrlbl.AutoSize = true;
            this.Descrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Descrlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descrlbl.Location = new System.Drawing.Point(104, 9);
            this.Descrlbl.Name = "Descrlbl";
            this.Descrlbl.Size = new System.Drawing.Size(202, 25);
            this.Descrlbl.TabIndex = 41;
            this.Descrlbl.Text = "Edit Province Process";
            // 
            // comboBoxptovince
            // 
            this.comboBoxptovince.FormattingEnabled = true;
            this.comboBoxptovince.Location = new System.Drawing.Point(259, 48);
            this.comboBoxptovince.Name = "comboBoxptovince";
            this.comboBoxptovince.Size = new System.Drawing.Size(132, 21);
            this.comboBoxptovince.TabIndex = 44;
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(161, 83);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 45;
            this.btnselect.Text = "Select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Select the Province you want to edit :\r\n";
            // 
            // EditProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 116);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.comboBoxptovince);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.labelpro);
            this.Controls.Add(this.TbxProvinceName);
            this.Controls.Add(this.Descrlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProvince";
            this.Text = "EditProvince";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnEdit;
    private System.Windows.Forms.Label labelpro;
    private System.Windows.Forms.TextBox TbxProvinceName;
    private System.Windows.Forms.Label Descrlbl;
    private System.Windows.Forms.ComboBox comboBoxptovince;
    private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label2;
    }
}