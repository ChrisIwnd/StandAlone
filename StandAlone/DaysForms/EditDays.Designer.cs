namespace StandAlone.DaysForms
{
    partial class EditDays
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
            this.Descrlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxDays = new System.Windows.Forms.TextBox();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(152, 87);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 34;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Descrlbl
            // 
            this.Descrlbl.AutoSize = true;
            this.Descrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Descrlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Descrlbl.Location = new System.Drawing.Point(68, 9);
            this.Descrlbl.Name = "Descrlbl";
            this.Descrlbl.Size = new System.Drawing.Size(237, 31);
            this.Descrlbl.TabIndex = 35;
            this.Descrlbl.Text = "Edit Days Process";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Select the day you want to edit:";
            // 
            // TbxDays
            // 
            this.TbxDays.Location = new System.Drawing.Point(142, 51);
            this.TbxDays.Name = "TbxDays";
            this.TbxDays.Size = new System.Drawing.Size(132, 20);
            this.TbxDays.TabIndex = 38;
            // 
            // CmbDays
            // 
            this.CmbDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(223, 50);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(132, 21);
            this.CmbDays.TabIndex = 42;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(152, 87);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 51;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(95, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Day :";
            // 
            // EditDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 131);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxDays);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.Descrlbl);
            this.Controls.Add(this.BtnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDays";
            this.Text = "EditDays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label Descrlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxDays;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Label label2;
    }
}