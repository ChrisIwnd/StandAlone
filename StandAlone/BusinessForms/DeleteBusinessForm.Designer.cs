namespace StandAlone.BusinessForms
{
    partial class DeleteBusinessForm
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
            this.CmbBusiness = new System.Windows.Forms.ComboBox();
            this.LblDescr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDelete.Location = new System.Drawing.Point(148, 95);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 20;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(12, 56);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(170, 17);
            this.LblGuide.TabIndex = 19;
            this.LblGuide.Text = "Select business to delete:";
            // 
            // CmbBusiness
            // 
            this.CmbBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBusiness.FormattingEnabled = true;
            this.CmbBusiness.Location = new System.Drawing.Point(188, 55);
            this.CmbBusiness.Name = "CmbBusiness";
            this.CmbBusiness.Size = new System.Drawing.Size(186, 21);
            this.CmbBusiness.TabIndex = 18;
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(73, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(250, 25);
            this.LblDescr.TabIndex = 17;
            this.LblDescr.Text = "Delete Businesses Process";
            // 
            // DeleteBusinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 130);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.CmbBusiness);
            this.Controls.Add(this.LblDescr);
            this.Name = "DeleteBusinessForm";
            this.Text = "DeleteBusinessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.ComboBox CmbBusiness;
        private System.Windows.Forms.Label LblDescr;
    }
}