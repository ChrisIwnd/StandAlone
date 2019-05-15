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
    public partial class DeleteUser : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for our base.
        /// </summary>
        string SqlDeleteUsers = "DELETE FROM users WHERE Username = '{0}'";

        /// <summary>
        /// In the constructor the from is created.
        /// Then the combobox of the form is fill with the Usernames 
        /// and NAMES of users.
        /// </summary>
        public DeleteUser()
        {
            InitializeComponent();
            CmbUsers.DataSource = DCom.GetData("SELECT Username,CONCAT(Last_name,' ' , First_Name) AS NAME FROM users");
            CmbUsers.DisplayMember = "NAME";
            CmbUsers.ValueMember = "Username";
        }

        /// <summary>
        /// When the client select the user from the combo box, press the Delete button
        /// to delete him. Then the system show up a message that warning him if he
        /// is sure for this action. If the client press YES then the system execute the
        /// querry and delete the user. Else the system will do nothig.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DCom.Exec(String.Format(SqlDeleteUsers, CmbUsers.SelectedValue));

                MessageBox.Show("DELETE COMPLETE");
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("DELETE CANSEL");
            }
        }
    }
}
