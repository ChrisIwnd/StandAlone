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
    public partial class DeleteLogin : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for our base.
        /// </summary>
        string SqlDeleteLogin = "DELETE FROM login WHERE Username = '{0}'";

        /// <summary>
        /// In the constructor the from is created.
        /// Then the combobox of the form is fill with the Usernames 
        ///  of the table login.
        /// </summary>
        public DeleteLogin()
        {
            InitializeComponent();
            CmbUsername.DataSource = DCom.GetData("SELECT * FROM login");
            CmbUsername.DisplayMember = "Username";
            CmbUsername.ValueMember = "Username";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this login info?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DCom.Exec(String.Format(SqlDeleteLogin, CmbUsername.SelectedValue));

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
