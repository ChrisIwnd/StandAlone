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
    public partial class AddLogin : Form
    {

        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO login VALUES('{0}','{1}')";

        /// <summary>
        /// In forms constractor the Combobox for Usernames(CmbUsername) fills up from the table users 
        /// that contains all the users. The diplay member is the usenrame of the user(Row Username) 
        /// and the value member is the same.
        /// </summary>
        public AddLogin()
        {
            InitializeComponent();
            CmbUsername.DataSource = DCom.GetData("SELECT users.Username FROM users WHERE users.Username NOT IN (SELECT login.Username FROM login)");
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
            if (string.IsNullOrWhiteSpace(CmbUsername.Text) || string.IsNullOrEmpty(TbxPassword.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlExec, this.CmbUsername.Text, this.TbxPassword.Text));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
