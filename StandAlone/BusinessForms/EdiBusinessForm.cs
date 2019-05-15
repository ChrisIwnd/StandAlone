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
    public partial class EdiBusinessForm : Form
    {
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM businesses WHERE ID = {0}";
        string SqlUpdate = "UPDATE businesses SET `Business_Name`='{0}', `Type`='{1}', `Category`='{2}', `Location_ID`='{3}', `Telephone`='{4}', `Website`='{5}', `Description`='{6}', `Work_hours_ID`='{7}', `User`='{8}',  `Rating`='{9}', `Price_Range`='{10}', `Allow_Reservation`='{11}' WHERE ID = '{12}'";

        public EdiBusinessForm()
        {
            InitializeComponent();

            LblBusinessDescription.Hide();
            LblBusinessName.Hide();
            LblCategory.Hide();
            LblPrice.Hide();
            LblRating.Hide();
            LblTelephone.Hide();
            LblUser.Hide();
            LblWebsite.Hide();
            LblWorkHours.Hide();
            LblBusinessType.Hide();
            LblLocation.Hide();

            TbxBusinessName.Hide();
            TbxCategory.Hide();
            TbxDescription.Hide();
            TbxPrice.Hide();
            TbxRating.Hide();
            TbxTelephone.Hide();
            TbxWebsite.Hide();

            CmbLocation.Hide();
            CmbTypes.Hide();
            CmbUser.Hide();
            CmbWorkHours.Hide();

            ChbReservation.Hide();

            BtnEdit.Hide();

            CmbBusinesses.DataSource = DCom.GetData("SELECT businesses.ID, CONCAT(businesses.Business_Name, ', ', location.Address_Name, ', ', location.Municipality) AS NAME FROM businesses, location WHERE businesses.Location_ID = location.ID");
            CmbBusinesses.DisplayMember = "NAME";
            CmbBusinesses.ValueMember = "ID";
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            LblBusinessDescription.Show();
            LblBusinessName.Show();
            LblCategory.Show();
            LblPrice.Show();
            LblRating.Show();
            LblTelephone.Show();
            LblUser.Show();
            LblWebsite.Show();
            LblWorkHours.Show();
            LblBusinessType.Show();
            LblLocation.Show();

            TbxBusinessName.Show();
            TbxCategory.Show();
            TbxDescription.Show();
            TbxPrice.Show();
            TbxRating.Show();
            TbxTelephone.Show();
            TbxWebsite.Show();

            CmbLocation.Show();
            CmbTypes.Show();
            CmbUser.Show();
            CmbWorkHours.Show();

            ChbReservation.Show();

            BtnEdit.Show();

            LblSelect.Hide();
            CmbBusinesses.Hide();
            BtnSelect.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbBusinesses.SelectedValue));
            TbxBusinessName.Text = (string)SelectedData.Rows[0]["Business_Name"];
            TbxCategory.Text = (string)SelectedData.Rows[0]["Category"];
            TbxDescription.Text = (string)SelectedData.Rows[0]["Description"];
            TbxPrice.Text = SelectedData.Rows[0]["Price_Range"].ToString();
            TbxRating.Text = (string)SelectedData.Rows[0]["Rating"].ToString();
            TbxTelephone.Text = (string)SelectedData.Rows[0]["Telephone"];
            TbxWebsite.Text = (string)SelectedData.Rows[0]["Website"];

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

        private void BtnEdit_Click(object sender, EventArgs e)
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
                    DCom.Exec(String.Format(SqlUpdate, TbxBusinessName.Text, CmbTypes.SelectedValue, TbxCategory.Text, CmbLocation.SelectedValue, TbxTelephone.Text,
                        TbxWebsite.Text, TbxDescription.Text, CmbWorkHours.SelectedValue, CmbUser.SelectedValue, TbxRating.Text, TbxPrice.Text, '1', CmbBusinesses.SelectedValue));
                    MessageBox.Show("EDIT COMPLETE");
                    Close();
                }
                else
                {
                    DCom.Exec(String.Format(SqlUpdate, TbxBusinessName.Text, CmbTypes.SelectedValue, TbxCategory.Text, CmbLocation.SelectedValue, TbxTelephone.Text,
                        TbxWebsite.Text, TbxDescription.Text, CmbWorkHours.SelectedValue, CmbUser.SelectedValue, TbxRating.Text, TbxPrice.Text, '0', CmbBusinesses.SelectedValue));
                    MessageBox.Show("EDIT COMPLETE");
                    Close();
                }
            }
        }
    }
}
