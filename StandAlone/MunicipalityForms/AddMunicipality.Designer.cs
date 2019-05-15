namespace StandAlone.Municipality
{
    partial class AddMunicipality
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
            this.CmbProvince = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxMunicipality = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Descrlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbProvince
            // 
            this.CmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProvince.FormattingEnabled = true;
            this.CmbProvince.Location = new System.Drawing.Point(148, 89);
            this.CmbProvince.Name = "CmbProvince";
            this.CmbProvince.Size = new System.Drawing.Size(132, 21);
            this.CmbProvince.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Province:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Municipality Name :";
            // 
            // TbxMunicipality
            // 
            this.TbxMunicipality.Location = new System.Drawing.Point(148, 57);
            this.TbxMunicipality.Name = "TbxMunicipality";
            this.TbxMunicipality.Size = new System.Drawing.Size(132, 20);
            this.TbxMunicipality.TabIndex = 15;
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Addbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Addbtn.Location = new System.Drawing.Point(102, 126);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(87, 27);
            this.Addbtn.TabIndex = 17;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Descrlbl
            // 
            this.Descrlbl.AutoSize = true;
            this.Descrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Descrlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descrlbl.Location = new System.Drawing.Point(23, 9);
            this.Descrlbl.Name = "Descrlbl";
            this.Descrlbl.Size = new System.Drawing.Size(231, 25);
            this.Descrlbl.TabIndex = 19;
            this.Descrlbl.Text = "Add Municipality Process";
            // 
            // AddMunicipality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 163);
            this.Controls.Add(this.Descrlbl);
            this.Controls.Add(this.CmbProvince);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxMunicipality);
            this.Controls.Add(this.Addbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMunicipality";
            this.Text = "AddMunicipality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbProvince;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxMunicipality;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label Descrlbl;
    }
}