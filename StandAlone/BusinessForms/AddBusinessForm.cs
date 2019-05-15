using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.BusinessForms
{
    public partial class AddBusinessForm : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO businesses (`Business_Name`, `Type`, `Category`, `Location_ID`, `Telephone`, `Website`, `Description`, `Work_hours_ID`, `User`, `Rating`, `Price_Range`, `Allow_Reservation`) " +
            "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')";

        /// <summary>
        /// In forms constractor all the comboboxes are filling from their table from database.
        /// </summary>
        public AddBusinessForm()
        {
            InitializeComponent();

            CmbLocation.DataSource = DCom.GetData("SELECT ID,CONCAT(Address_Name, ', ', Address_Number) AS NAME FROM location");
            CmbLocation.DisplayMember = "NAME";
            CmbLocation.ValueMember = "ID";

            CmbTypes.DataSource = DCom.GetData("SELECT * FROM businesses_types");
            CmbTypes.DisplayMember = "Type";
            CmbTypes.ValueMember = "Type";

            CmbUser.DataSource = DCom.GetData("SELECT * FROM users");
            CmbUser.DisplayMember = "Username";
            CmbUser.ValueMember = "Username";

            CmbWorkHours.DataSource = DCom.GetData("SELECT * FROM work_hours");
            CmbWorkHours.DisplayMember = "ID";
            CmbWorkHours.ValueMember = "ID";
        }

        /// <summary>
        /// This state is when the client press the button to add a record.
        /// Before it goes to add the record it checks if all the fields are completed.
        /// Then add the record in database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxBusinessName.Text) || string.IsNullOrWhiteSpace(TbxCategory.Text) || string.IsNullOrWhiteSpace(TbxDescription.Text)
                || string.IsNullOrWhiteSpace(TbxPrice.Text) || string.IsNullOrWhiteSpace(TbxWebsite.Text) || string.IsNullOrWhiteSpace(CmbLocation.Text)
                || string.IsNullOrWhiteSpace(CmbTypes.Text) || string.IsNullOrWhiteSpace(CmbUser.Text) || string.IsNullOrWhiteSpace(CmbWorkHours.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ChbReservation.Checked)
                {
                    DCom.Exec(String.Format(SqlExec, TbxBusinessName.Text, CmbTypes.SelectedValue, TbxCategory.Text, CmbLocation.SelectedValue, TbxTelephone.Text,
                        TbxWebsite.Text, TbxDescription.Text, CmbWorkHours.SelectedValue, CmbUser.SelectedValue, TbxRating.Text, TbxPrice.Text, '1'));
                    MessageBox.Show("ADD COMPLETE");
                    Close();
                }
                else
                {
                    DCom.Exec(String.Format(SqlExec, TbxBusinessName.Text, CmbTypes.SelectedValue, TbxCategory.Text, CmbLocation.SelectedValue, TbxTelephone.Text,
                        TbxWebsite.Text, TbxDescription.Text, CmbWorkHours.SelectedValue, CmbUser.SelectedValue, TbxRating.Text, TbxPrice.Text, '0'));
                    MessageBox.Show("ADD COMPLETE");
                    Close();
                }               
            }
        }
    }
}
