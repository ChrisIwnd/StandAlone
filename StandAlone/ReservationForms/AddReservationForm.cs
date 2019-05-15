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
    public partial class AddReservationForm : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO reservation(User, BusinessID, Date, Persons)" +
                " VALUES('{0}', '{1}', '{2}', '{3}')";

        /// <summary>
        /// In forms constractor the Combobox for business(CmbBusiness) and for username(CmbUsername) fills up from the tables users and business 
        /// that contains all the types. 
        /// </summary>
        public AddReservationForm()
        {
            InitializeComponent();

            CmbBusiness.DataSource = DCom.GetData("SELECT businesses.ID, CONCAT(businesses.Business_Name, ', ', location.Address_Name, ', ', location.Municipality) AS NAME FROM businesses, location WHERE businesses.Location_ID = location.ID");
            CmbBusiness.DisplayMember = "NAME";
            CmbBusiness.ValueMember = "ID";

            CmbUsername.DataSource = DCom.GetData("SELECT * FROM users");
            CmbUsername.DisplayMember = "Username";
            CmbUsername.ValueMember = "Username";
        }

        /// <summary>
        /// This state is when the client press the button to add a record.
        /// Before it goes to add the record it checks if all the fields are completed.
        /// Then add the record in database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxPerson.Text) || string.IsNullOrWhiteSpace(CmbBusiness.Text) ||
                string.IsNullOrWhiteSpace(CmbUsername.Text) || string.IsNullOrWhiteSpace(DtpDate.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlExec, this.CmbUsername.Text, CmbBusiness.SelectedValue, DtpDate.Value.ToString("yyyy-MM-dd"), TbxPerson.Text));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
