namespace StandAlone.Businesses_Types
{
    partial class EditBusinessesTypes
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
            this.TbxEditiBusinessesTypes = new System.Windows.Forms.TextBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.CmbBusinessesTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblGuide1
            // 
            this.LblGuide1.AutoSize = true;
            this.LblGuide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide1.Location = new System.Drawing.Point(108, 63);
            this.LblGuide1.Name = "LblGuide1";
            this.LblGuide1.Size = new System.Drawing.Size(166, 17);
            this.LblGuide1.TabIndex = 30;
            this.LblGuide1.Text = "Edit the businesses type:";
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(74, 62);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(200, 17);
            this.LblGuide.TabIndex = 29;
            this.LblGuide.Text = "Select businesses type to edit:";
            // 
            // DescrLbl
            // 
            this.DescrLbl.AutoSize = true;
            this.DescrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DescrLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DescrLbl.Location = new System.Drawing.Point(12, 9);
            this.DescrLbl.Name = "DescrLbl";
            this.DescrLbl.Size = new System.Drawing.Size(477, 39);
            this.DescrLbl.TabIndex = 28;
            this.DescrLbl.Text = "Edit Businesses Type Process";
            // 
            // BtnEdit
            // 
            this.BtnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEdit.Location = new System.Drawing.Point(173, 102);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 27;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // TbxEditiBusinessesTypes
            // 
            this.TbxEditiBusinessesTypes.Location = new System.Drawing.Point(281, 62);
            this.TbxEditiBusinessesTypes.Name = "TbxEditiBusinessesTypes";
            this.TbxEditiBusinessesTypes.Size = new System.Drawing.Size(106, 20);
            this.TbxEditiBusinessesTypes.TabIndex = 26;
            // 
            // BtnSelect
            // 
            this.BtnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSelect.Location = new System.Drawing.Point(173, 102);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 25;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // CmbBusinessesTypes
            // 
            this.CmbBusinessesTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBusinessesTypes.FormattingEnabled = true;
            this.CmbBusinessesTypes.Location = new System.Drawing.Point(280, 62);
            this.CmbBusinessesTypes.Name = "CmbBusinessesTypes";
            this.CmbBusinessesTypes.Size = new System.Drawing.Size(106, 21);
            this.CmbBusinessesTypes.TabIndex = 24;
            // 
            // EditBusinessesTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 135);
            this.Controls.Add(this.LblGuide1);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.DescrLbl);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TbxEditiBusinessesTypes);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.CmbBusinessesTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBusinessesTypes";
            this.Text = "EditBusinessesTypes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGuide1;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.Label DescrLbl;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TbxEditiBusinessesTypes;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.ComboBox CmbBusinessesTypes;
    }
}