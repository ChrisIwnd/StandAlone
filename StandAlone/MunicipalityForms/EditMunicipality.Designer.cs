namespace StandAlone.Municipality
{
    partial class EditMunicipality
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
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guidelbl = new System.Windows.Forms.Label();
            this.CmbMunicipality_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescrLbl = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.CmbProvince = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(177, 114);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 39;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(177, 114);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 38;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(103, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Province:";
            // 
            // guidelbl
            // 
            this.guidelbl.AutoSize = true;
            this.guidelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guidelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guidelbl.Location = new System.Drawing.Point(103, 58);
            this.guidelbl.Name = "guidelbl";
            this.guidelbl.Size = new System.Drawing.Size(125, 17);
            this.guidelbl.TabIndex = 37;
            this.guidelbl.Text = "Minicipality Name :";
            // 
            // CmbMunicipality_Name
            // 
            this.CmbMunicipality_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMunicipality_Name.FormattingEnabled = true;
            this.CmbMunicipality_Name.Location = new System.Drawing.Point(296, 69);
            this.CmbMunicipality_Name.Name = "CmbMunicipality_Name";
            this.CmbMunicipality_Name.Size = new System.Drawing.Size(121, 21);
            this.CmbMunicipality_Name.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Select the municipality that you want to edit:";
            // 
            // DescrLbl
            // 
            this.DescrLbl.AutoSize = true;
            this.DescrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DescrLbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DescrLbl.Location = new System.Drawing.Point(22, 9);
            this.DescrLbl.Name = "DescrLbl";
            this.DescrLbl.Size = new System.Drawing.Size(396, 39);
            this.DescrLbl.TabIndex = 32;
            this.DescrLbl.Text = "Edit Municipality Process";
            // 
            // TbxName
            // 
            this.TbxName.Location = new System.Drawing.Point(234, 55);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(132, 20);
            this.TbxName.TabIndex = 40;
            // 
            // CmbProvince
            // 
            this.CmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProvince.FormattingEnabled = true;
            this.CmbProvince.Location = new System.Drawing.Point(234, 87);
            this.CmbProvince.Name = "CmbProvince";
            this.CmbProvince.Size = new System.Drawing.Size(132, 21);
            this.CmbProvince.TabIndex = 41;
            // 
            // EditMunicipality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 148);
            this.Controls.Add(this.CmbProvince);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guidelbl);
            this.Controls.Add(this.CmbMunicipality_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescrLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMunicipality";
            this.Text = "EditMunicipality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label guidelbl;
        private System.Windows.Forms.ComboBox CmbMunicipality_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DescrLbl;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.ComboBox CmbProvince;
    }
}