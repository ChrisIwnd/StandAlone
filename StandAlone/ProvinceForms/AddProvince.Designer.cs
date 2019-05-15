namespace StandAlone.ProvinceForms
{
    partial class AddProvince
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LblGuide = new System.Windows.Forms.Label();
            this.LblDescr = new System.Windows.Forms.Label();
            this.TbxAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdd.Location = new System.Drawing.Point(81, 90);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(87, 27);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(9, 52);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(103, 17);
            this.LblGuide.TabIndex = 11;
            this.LblGuide.Text = "Write province:";
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(30, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(205, 25);
            this.LblDescr.TabIndex = 10;
            this.LblDescr.Text = "Add Province Process";
            // 
            // TbxAdd
            // 
            this.TbxAdd.Location = new System.Drawing.Point(124, 51);
            this.TbxAdd.Name = "TbxAdd";
            this.TbxAdd.Size = new System.Drawing.Size(132, 20);
            this.TbxAdd.TabIndex = 9;
            // 
            // AddProvince
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 139);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.LblDescr);
            this.Controls.Add(this.TbxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProvince";
            this.Text = "AddProvince";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LblGuide;
        private System.Windows.Forms.Label LblDescr;
        private System.Windows.Forms.TextBox TbxAdd;
    }
}