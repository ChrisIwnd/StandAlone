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
    public partial class AddRatingsForm : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO ratings(Rating_Value, Username, Comment)" +
                " VALUES('{0}','{1}','{2}')";

        /// <summary>
        /// In forms constractor the Combobox for Username(CmbUsername) fills up from the table users 
        /// that contains all the users. The diplay member is the name of the Username(Row Username) 
        /// and the value member is the same.
        /// </summary>
        public AddRatingsForm()
        {
            InitializeComponent();

            CmbUsername.DataSource = DCom.GetData("SELECT Username FROM users");
            CmbUsername.DisplayMember = "Username";
            CmbUsername.ValueMember = "Username";
        }

        /// <summary>
        /// This state is when the client press the button to add a record.
        /// Before it goes to add the record it checks if all the fields are completed.
        /// Then add the record in database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxComment.Text) || string.IsNullOrWhiteSpace(TbxRatingValue.Text) ||
                string.IsNullOrWhiteSpace(CmbUsername.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlExec, this.TbxRatingValue.Text, CmbUsername.SelectedValue, TbxComment.Text));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
