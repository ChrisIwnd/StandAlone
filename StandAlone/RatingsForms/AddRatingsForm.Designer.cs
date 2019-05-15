namespace StandAlone.RatingsForms
{
    partial class AddRatingsForm
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
            this.CmbUsername = new System.Windows.Forms.ComboBox();
            this.LabelMunicipality = new System.Windows.Forms.Label();
            this.LabelAddressNumber = new System.Windows.Forms.Label();
            this.TbxComment = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LabelAddressName = new System.Windows.Forms.Label();
            this.LblDescr = new System.Windows.Forms.Label();
            this.TbxRatingValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbUsername
            // 
            this.CmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsername.FormattingEnabled = true;
            this.CmbUsername.Location = new System.Drawing.Point(130, 66);
            this.CmbUsername.Name = "CmbUsername";
            this.CmbUsername.Size = new System.Drawing.Size(196, 21);
            this.CmbUsername.TabIndex = 43;
            // 
            // LabelMunicipality
            // 
            this.LabelMunicipality.AutoSize = true;
            this.LabelMunicipality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelMunicipality.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelMunicipality.Location = new System.Drawing.Point(19, 66);
            this.LabelMunicipality.Name = "LabelMunicipality";
            this.LabelMunicipality.Size = new System.Drawing.Size(73, 17);
            this.LabelMunicipality.TabIndex = 40;
            this.LabelMunicipality.Text = "Username";
            // 
            // LabelAddressNumber
            // 
            this.LabelAddressNumber.AutoSize = true;
            this.LabelAddressNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelAddressNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAddressNumber.Location = new System.Drawing.Point(19, 100);
            this.LabelAddressNumber.Name = "LabelAddressNumber";
            this.LabelAddressNumber.Size = new System.Drawing.Size(75, 17);
            this.LabelAddressNumber.TabIndex = 37;
            this.LabelAddressNumber.Text = "Comment :";
            // 
            // TbxComment
            // 
            this.TbxComment.Location = new System.Drawing.Point(130, 98);
            this.TbxComment.Multiline = true;
            this.TbxComment.Name = "TbxComment";
            this.TbxComment.Size = new System.Drawing.Size(196, 81);
            this.TbxComment.TabIndex = 32;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdd.Location = new System.Drawing.Point(22, 152);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(87, 27);
            this.BtnAdd.TabIndex = 35;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LabelAddressName
            // 
            this.LabelAddressName.AutoSize = true;
            this.LabelAddressName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelAddressName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAddressName.Location = new System.Drawing.Point(19, 37);
            this.LabelAddressName.Name = "LabelAddressName";
            this.LabelAddressName.Size = new System.Drawing.Size(97, 17);
            this.LabelAddressName.TabIndex = 38;
            this.LabelAddressName.Text = "Rating Value :";
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(86, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(184, 25);
            this.LblDescr.TabIndex = 36;
            this.LblDescr.Text = "Add Rating Process";
            // 
            // TbxRatingValue
            // 
            this.TbxRatingValue.Location = new System.Drawing.Point(130, 37);
            this.TbxRatingValue.Name = "TbxRatingValue";
            this.TbxRatingValue.Size = new System.Drawing.Size(196, 20);
            this.TbxRatingValue.TabIndex = 31;
            // 
            // AddRatingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 197);
            this.Controls.Add(this.CmbUsername);
            this.Controls.Add(this.LabelMunicipality);
            this.Controls.Add(this.LabelAddressNumber);
            this.Controls.Add(this.TbxComment);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LabelAddressName);
            this.Controls.Add(this.LblDescr);
            this.Controls.Add(this.TbxRatingValue);
            this.Name = "AddRatingsForm";
            this.Text = "AddRatingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbUsername;
        private System.Windows.Forms.Label LabelMunicipality;
        private System.Windows.Forms.Label LabelAddressNumber;
        private System.Windows.Forms.TextBox TbxComment;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label LabelAddressName;
        private System.Windows.Forms.Label LblDescr;
        private System.Windows.Forms.TextBox TbxRatingValue;
    }
}