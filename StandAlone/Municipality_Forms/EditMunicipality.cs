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
    public partial class EditMunicipality : Form
    {
        /// <summary>
        /// his is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands for. The first command is for the
        /// selection of data from the base and the second for the update.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM municipality WHERE Municipality_Name = '{0}'";
        string SqlUpdate = "UPDATE municipality SET Municipality_Name = '{0}', Province = '{1} WHERE Municipality_Name = '{2}'";

        /// <summary>
        /// In forms constructor the not necessarily labels and tetxboxes are hiding 
        /// from the form. Then the combobox for login(CmbUsername) is filling
        /// from the user types(users_types) table.
        /// /// </summary>
        public EditMunicipality()
        {
            InitializeComponent();
            guidelbl.Hide();
            label2.Hide();
            TbxName.Hide();
            CmbProvince.Hide();

            CmbMunicipality_Name.DataSource = DCom.GetData("SELECT * FROM municipality WHERE Municipality_Name = '{0}'");
            CmbMunicipality_Name.DisplayMember = "NAME";
            CmbMunicipality_Name.ValueMember = "NAME";
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
            label2.Show();
            TbxName.Show();
            CmbProvince.Show();
            guidelbl.Show();
            
            label1.Hide();
            CmbMunicipality_Name.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbMunicipality_Name.SelectedValue));
            TbxName.Text = (string)SelectedData.Rows[0]["Name"];

            CmbProvince.DataSource = DCom.GetData("SELECT * FROM municipality");
            CmbProvince.DisplayMember = "Municipality_Name";
            CmbProvince.ValueMember = "Municipality_Name";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxName.Text) || string.IsNullOrEmpty(CmbProvince.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheck("municipality", "Municipality_Name", TbxName.Text) == true)
            {
                MessageBox.Show("THE USERNAME ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxName.Text, CmbProvince.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
