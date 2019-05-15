using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.RatingsForms
{
    public partial class EditRatingsForm : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM ratings WHERE ID = {0}";
        string SqlUpdate = "UPDATE ratings SET Rating_Value = '{0}', Username = '{1}', Comment = '{2}' WHERE ID = '{3}'";

        /// <summary>
        /// In forms constructor the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form. Then the combobox for ratings(CmbSelect) is filling with the data of the table.
        /// </summary>
        public EditRatingsForm()
        {
            InitializeComponent();

            LblRatingValue.Hide();
            LblComment.Hide();
            LblUsername.Hide();

            TbxComment.Hide();
            TbxRatingValue.Hide();
            CmbUsername.Hide();

            BtnEdit.Hide();

            CmbSelect.DataSource = DCom.GetData("SELECT *, CONCAT(Username, ', ', Rating_Value) AS NAME FROM ratings");
            CmbSelect.DisplayMember = "NAME";
            CmbSelect.ValueMember = "ID";
        }

        /// <summary>
        /// Finally when the client made the changes that he wants the program checks if all the fields 
        /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
        /// update of the rating, else show a error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            LblRatingValue.Show();
            LblComment.Show();
            LblUsername.Show();

            TbxComment.Show();
            TbxRatingValue.Show();
            CmbUsername.Show();

            BtnEdit.Show();

            LblSelect.Hide();
            CmbSelect.Hide();
            BtnSelect.Hide();


            SelectedData = DCom.GetData(String.Format(SqlExec, CmbSelect.SelectedValue));
            TbxRatingValue.Text = SelectedData.Rows[0]["Rating_Value"].ToString();
            TbxComment.Text = SelectedData.Rows[0]["Comment"].ToString();

            CmbUsername.DataSource = DCom.GetData("SELECT * FROM users");
            CmbUsername.DisplayMember = "Username";
            CmbUsername.ValueMember = "Username";
        }

        /// <summary>
        /// When the client select the rating that wants to edit the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form and then the neccesarily labels, tetxboxes and comboboxes are pop up. Then fills all the fields with
        /// the data of the selected rating.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxComment.Text) || string.IsNullOrWhiteSpace(TbxRatingValue.Text) || string.IsNullOrWhiteSpace(CmbUsername.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxRatingValue.Text, CmbUsername.SelectedValue, TbxComment.Text, CmbSelect.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
