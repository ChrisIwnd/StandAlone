namespace StandAlone.Municipality
{
    partial class DeleteMunicipality
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
            this.CmbMunicipality = new System.Windows.Forms.ComboBox();
            this.LblDescr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDelete.Location = new System.Drawing.Point(143, 131);
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
            this.LblGuide.Location = new System.Drawing.Point(21, 81);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(187, 17);
            this.LblGuide.TabIndex = 11;
            this.LblGuide.Text = "Select municipality to delete:";
            // 
            // CmbMunicipality
            // 
            this.CmbMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMunicipality.FormattingEnabled = true;
            this.CmbMunicipality.Location = new System.Drawing.Point(214, 81);
            this.CmbMunicipality.Name = "CmbMunicipality";
            this.CmbMunicipality.Size = new System.Drawing.Size(121, 21);
            this.CmbMunicipality.TabIndex = 10;
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(56, 33);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(251, 25);
            this.LblDescr.TabIndex = 9;
            this.LblDescr.Text = "Delete Municipality Process";
            // 
            // DeleteMunicipality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 191);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.CmbMunicipality);
            this.Controls.Add(this.LblDescr);
            this.Name = "DeleteMunicipality";
            this.Text = "DeleteMunicipality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.ComboBox CmbMunicipality;
        private System.Windows.Forms.Label LblDescr;
    }
}