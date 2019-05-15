namespace StandAlone.DaysForms
{
    partial class AddDays
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
            this.BtnAdd.Location = new System.Drawing.Point(72, 95);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(87, 27);
            this.BtnAdd.TabIndex = 16;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblGuide
            // 
            this.LblGuide.AutoSize = true;
            this.LblGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblGuide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblGuide.Location = new System.Drawing.Point(12, 53);
            this.LblGuide.Name = "LblGuide";
            this.LblGuide.Size = new System.Drawing.Size(45, 17);
            this.LblGuide.TabIndex = 15;
            this.LblGuide.Text = "Day : ";
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(21, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(174, 25);
            this.LblDescr.TabIndex = 14;
            this.LblDescr.Text = "Add Days Process";
            // 
            // TbxAdd
            // 
            this.TbxAdd.Location = new System.Drawing.Point(63, 52);
            this.TbxAdd.Name = "TbxAdd";
            this.TbxAdd.Size = new System.Drawing.Size(132, 20);
            this.TbxAdd.TabIndex = 13;
            // 
            // AddDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 134);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblGuide);
            this.Controls.Add(this.LblDescr);
            this.Controls.Add(this.TbxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDays";
            this.Text = "AddDays";
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