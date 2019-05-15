using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.Municipality
{
    public partial class AddMunicipality : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO users VALUES('{0}','{1}')";

        /// <summary>
        /// In forms constractor the Combobox for User Types(CmbMunicipality) fills up from the table users_types 
        /// that contains all the types. The diplay member is the name of the type(Row Type) 
        /// and the value member is the same.
        /// </summary>
        public AddMunicipality()
        {
            InitializeComponent();
            CmbMunicipality.DataSource = DCom.GetData("SELECT * FROM province");
            CmbMunicipality.DisplayMember = "Name";
            CmbMunicipality.ValueMember = "Name";
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
            if (string.IsNullOrWhiteSpace(TbxMunicipality.Text) || string.IsNullOrEmpty(CmbMunicipality.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheck("municipality", "Municipality_Name", TbxMunicipality.Text) == true)
            {
                MessageBox.Show("THE NAME ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlExec, this.TbxMunicipality.Text, this.CmbMunicipality.SelectedValue));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
