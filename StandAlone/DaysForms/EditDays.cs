using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.DaysForms
{
    public partial class EditDays : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM days";
        string SqlUpdate = "UPDATE days SET Name = '{0}'";

        /// <summary>
        /// In forms constructor the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form. Then the combobox for users(CmbDays) is filling with the usernames and NAMES 
        /// from table users.
        /// </summary>
        public EditDays()
        {
            InitializeComponent();
            label2.Hide();
            TbxDays.Hide();

            CmbDays.DataSource = DCom.GetData("SELECT * FROM days");
            CmbDays.DisplayMember = "Name";
            CmbDays.ValueMember = "Name";
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
            if (string.IsNullOrWhiteSpace(TbxDays.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheck("days", "Name", TbxDays.Text) == true)
            {
                MessageBox.Show("THE USERNAME ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxDays.Text));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            TbxDays.Show();
            BtnEdit.Show();
            label2.Show();
            label3.Hide();
            CmbDays.Hide();
            BtnSelect.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbDays.SelectedValue));
            TbxDays.Text = (string)SelectedData.Rows[0]["Name"];
          
        }
    }
}
