using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.ReservationForms
{
    public partial class EditReservationForm : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM reservation WHERE ID = {0}";
        string SqlUpdate = "UPDATE reservation SET User = '{0}', BusinessID = '{1}', Date = '{2}', Persons = '{3}' WHERE ID = '{4}'";

        /// <summary>
        /// In forms constructor the not necessarily labels and tetxboxes are hiding 
        /// from the form. Then the combobox for ratings(CmbSelect) is filling
        /// from the rating(rating) table.
        /// </summary>
        public EditReservationForm()
        {
            InitializeComponent();

            LblBusiness.Hide();
            LblDate.Hide();
            LblPerson.Hide();
            LblUsername.Hide();

            CmbBusiness.Hide();
            CmbUsername.Hide();

            BtnEdit.Hide();

            TbxPerson.Hide();
            DtpDate.Hide();

            CmbSelect.DataSource = DCom.GetData("SELECT *, CONCAT(Username, ', ', Rating_Value) AS NAME FROM ratings");
            CmbSelect.DisplayMember = "NAME";
            CmbSelect.ValueMember = "ID";

        }

        /// <summary>
        /// When the client select the rating that wants to edit the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form and then the neccesarily labels, tetxboxes and comboboxes are pop up. Then fills all the fields with
        /// the data of the selected rating.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            LblBusiness.Show();
            LblDate.Show();
            LblPerson.Show();
            LblUsername.Show();
            CmbBusiness.Show();
            CmbUsername.Show();
            BtnEdit.Show();
            TbxPerson.Show();
            DtpDate.Show();

            LblSelect.Hide();
            CmbSelect.Hide();
            BtnSelect.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbSelect.SelectedValue));
            TbxPerson.Text = SelectedData.Rows[0]["Persons"].ToString();

            CmbBusiness.DataSource = DCom.GetData("SELECT businesses.ID, CONCAT(businesses.Business_Name, ', ', location.Address_Name, ', ', location.Municipality) AS NAME FROM businesses, location WHERE businesses.Location_ID = location.ID");
            CmbBusiness.DisplayMember = "NAME";
            CmbBusiness.ValueMember = "ID";

            CmbUsername.DataSource = DCom.GetData("SELECT * FROM users");
            CmbUsername.DisplayMember = "Username";
            CmbUsername.ValueMember = "Username";

            CmbUsername.Text = SelectedData.Rows[0]["User"].ToString();
            CmbBusiness.Text = SelectedData.Rows[0]["BusinessID"].ToString();
        }

        /// <summary>
        /// Finally when the client made the changes that he wants the program checks if all the fields 
        /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
        /// update of the reservation, else show a error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxPerson.Text) || string.IsNullOrWhiteSpace(CmbUsername.Text) || string.IsNullOrWhiteSpace(CmbBusiness.Text) || string.IsNullOrWhiteSpace(DtpDate.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, CmbUsername.SelectedValue, CmbBusiness.SelectedValue, DtpDate.Value.ToString("yyyy-MM-dd"), TbxPerson.Text, CmbSelect.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
