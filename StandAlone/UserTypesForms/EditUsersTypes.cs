using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.UserTypesForms
{
    public partial class EditUsersTypes : Form
    {
        /// <summary>
        /// his is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands for. The first command is for the
        /// selection of data from the base and the second for the update.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM users_types WHERE Type = '{0}'";
        string SqlUpdate = "UPDATE users_types SET Type = '{0}' WHERE Type = '{1}'";

        /// <summary>
        /// In forms constructor the not necessarily labels and tetxboxes are hiding 
        /// from the form. Then the combobox for user types(CmbUsersTypes) is filling
        /// from the user types(users_types) table.
        /// /// </summary>
        public EditUsersTypes()
        {
            InitializeComponent();
            BtnEdit.Hide();
            LblGuide1.Hide();
            TbxEditiUsersTypes.Hide();

            CmbUsersTypes.DataSource = DCom.GetData("SELECT * FROM users_types");
            CmbUsersTypes.DisplayMember = "Type";
            CmbUsersTypes.ValueMember = "Type";
        }

        /// <summary>
        /// When the client select the user type that wants to edit the not necessarily labels and comboboxes are hiding 
        /// from the form and then the neccesarily labels and tetxboxes are pop up. Then fills all the fields with
        /// the data of the selected user type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            BtnEdit.Show();
            LblGuide1.Show();
            TbxEditiUsersTypes.Show();
            BtnSelect.Hide();
            CmbUsersTypes.Hide();
            LblGuide.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbUsersTypes.SelectedValue));
            TbxEditiUsersTypes.Text = (string)SelectedData.Rows[0]["Type"];
        }

        /// <summary>
        /// Finally when the client made the changes that he wants the program checks if all the fields 
        /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
        /// update of the user type, else show a error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxEditiUsersTypes.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxEditiUsersTypes.Text, CmbUsersTypes.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
