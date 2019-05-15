using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.LoginForms
{
    public partial class EditLogin : Form
    {
        /// <summary>
        /// his is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands for. The first command is for the
        /// selection of data from the base and the second for the update.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM login WHERE Username = '{0}'";
        string SqlUpdate = "UPDATE login SET Password = '{0}' WHERE Username = '{1}'";

        /// <summary>
        /// In forms constructor the not necessarily labels and tetxboxes are hiding 
        /// from the form. Then the combobox for login(CmbUsername) is filling
        /// from the user types(users_types) table.
        /// /// </summary>
        public EditLogin()
        {
            InitializeComponent();
            guidelbl.Hide();
            label2.Hide();
            TbxUsername.Hide();
            TbxPassword.Hide();
            BtnEdit.Hide();

            CmbUsername.DataSource = DCom.GetData("SELECT * FROM login");
            CmbUsername.DisplayMember = "Username";
            CmbUsername.ValueMember = "Username";
        }

        /// <summary>
        /// When the client select the login that wants to edit the not necessarily labels and comboboxes are hiding 
        /// from the form and then the neccesarily labels and tetxboxes are pop up. Then fills all the fields with
        /// the data of the selected login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            guidelbl.Show();
            label2.Show();
            TbxUsername.Show();
            TbxPassword.Show();
            BtnEdit.Show();

            label1.Hide();
            CmbUsername.Hide();
            BtnSelect.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbUsername.SelectedValue));

            TbxUsername.Text = (string)SelectedData.Rows[0]["Username"];
            TbxPassword.Text = (string)SelectedData.Rows[0]["Password"];
        }

        /// <summary>
        /// Finally when the client made the changes that he wants the program checks if all the fields 
        /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
        /// update of the login, else show a error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxPassword.Text) || string.IsNullOrWhiteSpace(TbxUsername.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxPassword.Text, TbxUsername.Text));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
