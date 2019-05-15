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
        /// from the form. Then the combobox for municipality(CmbMunicipality_Name) is filling
        /// from the municipality(municipality) table.
        /// /// </summary>
        public EditMunicipality()
        {
            InitializeComponent();
            guidelbl.Hide();
            label2.Hide();
            TbxName.Hide();
            CmbProvince.Hide();
            BtnEdit.Hide();

            CmbMunicipality_Name.DataSource = DCom.GetData("SELECT * FROM municipality");
            CmbMunicipality_Name.DisplayMember = "Municipality_Name";
            CmbMunicipality_Name.ValueMember = "Municipality_Name";
        }

        /// <summary>
        /// When the client select the minicipality that wants to edit the not necessarily labels and comboboxes are hiding 
        /// from the form and then the neccesarily labels and tetxboxes are pop up. Then fills all the fields with
        /// the data of the selected municipality.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            label2.Show();
            TbxName.Show();
            CmbProvince.Show();
            guidelbl.Show();
            BtnEdit.Show();
            
            label1.Hide();
            CmbMunicipality_Name.Hide();
            BtnSelect.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbMunicipality_Name.SelectedValue));
            TbxName.Text = (string)SelectedData.Rows[0]["Municipality_Name"];

            CmbProvince.DataSource = DCom.GetData("SELECT * FROM province");
            CmbProvince.DisplayMember = "Province_Name";
            CmbProvince.ValueMember = "Province_Name";
            CmbProvince.Text = (string)SelectedData.Rows[0]["Province"]; ;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxName.Text) || string.IsNullOrEmpty(CmbProvince.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheck("municipality", "Municipality_Name", TbxName.Text) == true)
            {
                MessageBox.Show("THE MUNICIPALITY ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxName.Text, CmbProvince.SelectedValue, CmbMunicipality_Name.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
