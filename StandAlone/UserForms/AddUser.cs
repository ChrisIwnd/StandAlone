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
    public partial class AddUser : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO users VALUES('{0}','{1}','{2}','{3}','{4}', '{5}')";

        /// <summary>
        /// In forms constractor the Combobox for User Types(CmbTypes) fills up from the table users_types 
        /// that contains all the types. The diplay member is the name of the type(Row Type) 
        /// and the value member is the same.
        /// </summary>
        public AddUser()
        {
            InitializeComponent();
            CmbTypes.DataSource = DCom.GetData("SELECT * FROM users_types");
            CmbTypes.DisplayMember = "Type";
            CmbTypes.ValueMember = "Type";
        }

        /// <summary>
        /// This state is when the client press the button to add a record.
        /// Before it goes to add the record it checks if all the fields are completed.
        /// After that checks if the username already exists.
        /// Then add the record in database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Addbtn_Click(object sender, EventArgs e)
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
                DCom.Exec(String.Format(SqlExec, this.TbxUsername.Text, this.TbxFirstName.Text, this.TbxLastName.Text, this.TbxEmail.Text, this.TbxTelephone.Text, this.CmbTypes.SelectedValue));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
