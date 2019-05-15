using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.LocationForms
{
    public partial class EditLocation : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM location WHERE ID = {0}";
        string SqlUpdate = "UPDATE location SET Address_Name = '{0}', Postal_Code = {1}, location.Long = {2}, Lat = {3}, Address_Number = {4}, Municipality = '{5}' WHERE ID = {6}";

        /// <summary>
        /// In forms constructor the not necessarily labels and tetxboxes are hiding 
        /// from the form. Then the combobox for location(CmbLocation) is filling
        /// from the location(location) table.
        /// </summary>
        public EditLocation()
        { 
            InitializeComponent();

            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            TbxAddressNumber.Hide();
            TbxAdressName.Hide();
            TbxLat.Hide();
            TbxLong.Hide();
            TbxPostalCode.Hide();
            CmbMunicipality.Hide();
            BtnEdit.Hide();

            CmbLocation.DataSource = DCom.GetData("SELECT ID, CONCAT(Address_Name, ', ', Municipality) AS ADDRESS  FROM location");
            CmbLocation.DisplayMember = "ADDRESS";
            CmbLocation.ValueMember = "ID";
        }

        /// <summary>
        /// When the client select the user that wants to edit the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form and then the neccesarily labels, tetxboxes and comboboxes are pop up. Then fills all the fields with
        /// the data of the selected user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            TbxAddressNumber.Show();
            TbxAdressName.Show();
            TbxLat.Show();
            TbxLong.Show();
            TbxPostalCode.Show();
            CmbMunicipality.Show();
            BtnEdit.Show();

            label1.Hide();
            CmbLocation.Hide();
            BtnSelect.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbLocation.SelectedValue));
            TbxAdressName.Text = SelectedData.Rows[0]["Address_Name"].ToString();
            TbxAddressNumber.Text = SelectedData.Rows[0]["Address_Number"].ToString();
            TbxLat.Text = SelectedData.Rows[0]["Lat"].ToString();
            TbxLong.Text = SelectedData.Rows[0]["Long"].ToString();
            TbxPostalCode.Text = SelectedData.Rows[0]["Postal_Code"].ToString();
           
            CmbMunicipality.DataSource = DCom.GetData("SELECT * FROM municipality");
            CmbMunicipality.DisplayMember = "Municipality_Name";
            CmbMunicipality.ValueMember = "Municipality_Name";
            CmbMunicipality.Text = SelectedData.Rows[0]["Municipality"].ToString();
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
            if (string.IsNullOrWhiteSpace(TbxAddressNumber.Text) || string.IsNullOrWhiteSpace(TbxAdressName.Text) ||
               string.IsNullOrWhiteSpace(TbxLat.Text) || string.IsNullOrWhiteSpace(TbxLong.Text) ||
               string.IsNullOrWhiteSpace(TbxPostalCode.Text) || string.IsNullOrEmpty(CmbMunicipality.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxAdressName.Text, int.Parse(TbxPostalCode.Text), double.Parse(TbxLong.Text), double.Parse(TbxLat.Text), int.Parse(TbxAddressNumber.Text), CmbMunicipality.SelectedValue, CmbLocation.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
