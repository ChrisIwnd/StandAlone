namespace StandAlone.RatingsForms
{
    partial class EditRatingsForm
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
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblComment = new System.Windows.Forms.Label();
            this.TbxComment = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.LblRatingValue = new System.Windows.Forms.Label();
            this.LblDescr = new System.Windows.Forms.Label();
            this.TbxRatingValue = new System.Windows.Forms.TextBox();
            this.LblSelect = new System.Windows.Forms.Label();
            this.CmbSelect = new System.Windows.Forms.ComboBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbUsername
            // 
            this.CmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUsername.FormattingEnabled = true;
            this.CmbUsername.Location = new System.Drawing.Point(118, 66);
            this.CmbUsername.Name = "CmbUsername";
            this.CmbUsername.Size = new System.Drawing.Size(196, 21);
            this.CmbUsername.TabIndex = 51;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblUsername.Location = new System.Drawing.Point(7, 66);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(73, 17);
            this.LblUsername.TabIndex = 50;
            this.LblUsername.Text = "Username";
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblComment.Location = new System.Drawing.Point(7, 100);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(75, 17);
            this.LblComment.TabIndex = 48;
            this.LblComment.Text = "Comment :";
            // 
            // TbxComment
            // 
            this.TbxComment.Location = new System.Drawing.Point(118, 98);
            this.TbxComment.Multiline = true;
            this.TbxComment.Name = "TbxComment";
            this.TbxComment.Size = new System.Drawing.Size(196, 81);
            this.TbxComment.TabIndex = 45;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEdit.Location = new System.Drawing.Point(10, 152);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(87, 27);
            this.BtnEdit.TabIndex = 46;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // LblRatingValue
            // 
            this.LblRatingValue.AutoSize = true;
            this.LblRatingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblRatingValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblRatingValue.Location = new System.Drawing.Point(7, 37);
            this.LblRatingValue.Name = "LblRatingValue";
            this.LblRatingValue.Size = new System.Drawing.Size(97, 17);
            this.LblRatingValue.TabIndex = 49;
            this.LblRatingValue.Text = "Rating Value :";
            // 
            // LblDescr
            // 
            this.LblDescr.AutoSize = true;
            this.LblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDescr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescr.Location = new System.Drawing.Point(74, 9);
            this.LblDescr.Name = "LblDescr";
            this.LblDescr.Size = new System.Drawing.Size(181, 25);
            this.LblDescr.TabIndex = 47;
            this.LblDescr.Text = "Edit Rating Process";
            // 
            // TbxRatingValue
            // 
            this.TbxRatingValue.Location = new System.Drawing.Point(118, 37);
            this.TbxRatingValue.Name = "TbxRatingValue";
            this.TbxRatingValue.Size = new System.Drawing.Size(196, 20);
            this.TbxRatingValue.TabIndex = 44;
            // 
            // LblSelect
            // 
            this.LblSelect.AutoSize = true;
            this.LblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblSelect.Location = new System.Drawing.Point(26, 70);
            this.LblSelect.Name = "LblSelect";
            this.LblSelect.Size = new System.Drawing.Size(138, 17);
            this.LblSelect.TabIndex = 52;
            this.LblSelect.Text = "Select rating to edit :";
            // 
            // CmbSelect
            // 
            this.CmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSelect.FormattingEnabled = true;
            this.CmbSelect.Location = new System.Drawing.Point(170, 69);
            this.CmbSelect.Name = "CmbSelect";
            this.CmbSelect.Size = new System.Drawing.Size(99, 21);
            this.CmbSelect.TabIndex = 53;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSelect.Location = new System.Drawing.Point(118, 96);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(87, 27);
            this.BtnSelect.TabIndex = 54;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // EditRatingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 193);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.CmbSelect);
            this.Controls.Add(this.LblSelect);
            this.Controls.Add(this.CmbUsername);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblComment);
            this.Controls.Add(this.TbxComment);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LblRatingValue);
            this.Controls.Add(this.LblDescr);
            this.Controls.Add(this.TbxRatingValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRatingsForm";
            this.Text = "EditRatingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.TextBox TbxComment;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label LblRatingValue;
        private System.Windows.Forms.Label LblDescr;
        private System.Windows.Forms.TextBox TbxRatingValue;
        private System.Windows.Forms.Label LblSelect;
        private System.Windows.Forms.ComboBox CmbSelect;
        private System.Windows.Forms.Button BtnSelect;
    }
}