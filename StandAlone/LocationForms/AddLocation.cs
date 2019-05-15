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
    public partial class AddLocation : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO location(Address_Name, Postal_Code, `Long`, Lat, Address_Number, Municipality)" +
                " VALUES('{0}','{1}','{2}','{3}','{4}', '{5}')";

        /// <summary>
        /// In forms constractor the Combobox for User Types(CmbTypes) fills up from the table users_types 
        /// that contains all the types. The diplay member is the name of the type(Row Type) 
        /// and the value member is the same.
        /// </summary>
        public AddLocation()
        {
            InitializeComponent();
            CmbMunicipality.DataSource = DCom.GetData("SELECT Municipality_Name FROM municipality");
            CmbMunicipality.DisplayMember = "Municipality_Name";
            CmbMunicipality.ValueMember = "Municipality_Name";
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
            if (string.IsNullOrWhiteSpace(TbxAdressName.Text) || string.IsNullOrWhiteSpace(TbxAddressNumber.Text) ||
                string.IsNullOrWhiteSpace(TbxPostalCode.Text) || string.IsNullOrWhiteSpace(CmbMunicipality.Text) ||
                string.IsNullOrWhiteSpace(TbxLat.Text) || string.IsNullOrEmpty(TbxLong.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlExec, this.TbxAdressName.Text, int.Parse(this.TbxPostalCode.Text), double.Parse(this.TbxLong.Text), 
                    double.Parse(this.TbxLat.Text), int.Parse(this.TbxAddressNumber.Text), this.CmbMunicipality.SelectedValue));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
