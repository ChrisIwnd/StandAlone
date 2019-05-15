using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.UserForms
{
    public partial class EditUser : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM users WHERE Username = '{0}'";
        string SqlUpdate = "UPDATE users SET First_Name = '{0}', Last_Name = '{1}', Username = '{2}', Telephone = '{3}', Email = '{4}', Type = '{5}' WHERE Username = '{6}'";

        /// <summary>
        /// In forms constructor the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form. Then the combobox for users(CmbUser) is filling with the usernames and NAMES 
        /// from table users.
        /// </summary>
        public EditUser()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            TbxFirstName.Hide();
            TbxLastName.Hide();
            TbxUsername.Hide();
            TbxTelephone.Hide();
            TbxEmail.Hide();
            CmbTypes.Hide();
            BtnEdit.Hide();

            CmbUser.DataSource = DCom.GetData("SELECT Username,CONCAT(Last_name,' ' , First_Name) AS NAME FROM users");
            CmbUser.DisplayMember = "NAME";
            CmbUser.ValueMember = "Username";

        }

        /// <summary>
        /// When the client select the user that wants to edit the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form and then the neccesarily labels, tetxboxes and comboboxes are pop up. Then fills all the fields with
        /// the data of the selected user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Guidelbl.Hide();
            CmbUser.Hide();
            BtnSelect.Hide();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            TbxFirstName.Show();
            TbxLastName.Show();
            TbxUsername.Show();
            TbxTelephone.Show();
            TbxEmail.Show();
            CmbTypes.Show();
            BtnEdit.Show();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbUser.SelectedValue));
            TbxFirstName.Text = (string)SelectedData.Rows[0]["First_Name"];
            TbxLastName.Text = (string)SelectedData.Rows[0]["Last_Name"];
            TbxUsername.Text = (string)SelectedData.Rows[0]["Username"];
            TbxEmail.Text = (string)SelectedData.Rows[0]["Email"];
            TbxTelephone.Text = (string)SelectedData.Rows[0]["Telephone"];

            DataTable GetUserType = DCom.GetData(String.Format("SELECT users_types.Type FROM users, users_types WHERE users.Username='{0}' and users.Type=users_types.Type", CmbUser.SelectedValue));
            CmbTypes.DataSource = DCom.GetData("SELECT * FROM users_types");
            CmbTypes.DisplayMember = "Type";
            CmbTypes.ValueMember = "Type";
            CmbTypes.Text = (string)GetUserType.Rows[0]["Type"];
        }

        /// <summary>
        /// Finally when the client made the changes that he wants the program checks if all the fields 
        /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
        /// update of the user, else show a error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxFirstName.Text) || string.IsNullOrWhiteSpace(TbxLastName.Text) ||
                string.IsNullOrWhiteSpace(TbxUsername.Text) || string.IsNullOrWhiteSpace(TbxEmail.Text) ||
                string.IsNullOrWhiteSpace(TbxTelephone.Text) || string.IsNullOrEmpty(CmbTypes.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheck("users", "username", TbxUsername.Text) == true)
            {
                MessageBox.Show("THE USERNAME ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxFirstName.Text, TbxLastName.Text, TbxUsername.Text, TbxTelephone.Text, TbxEmail.Text, CmbTypes.SelectedValue, CmbUser.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
