using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.WorkHoursForms
{
    public partial class EditWorkHours : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM work_hours WHERE ID = {0}";
        string SqlUpdate = "UPDATE work_hours SET Start_Time = '{0}', End_Time = '{1}', Day = '{2}' WHERE ID = {3}";

        /// <summary>
        /// In forms constructor the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form. Then the combobox for work hours(CmbWorkHours) is filling with the ID of work hours.
        /// </summary>
        public EditWorkHours()
        {
            InitializeComponent();

            LblDays.Hide();
            LblEndTime.Hide();
            LblStartTime.Hide();
            DtpEndTime.Hide();
            DtpStartTime.Hide();
            CmbDays.Hide();
            BtnEdit.Hide();

            CmbWorkHours.DataSource = DCom.GetData("SELECT * FROM work_hours");
            CmbWorkHours.DisplayMember = "ID";
            CmbWorkHours.ValueMember = "ID";
        }

        /// <summary>
        /// When the client select the work hour that wants to edit the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form and then the neccesarily labels, tetxboxes and comboboxes are pop up. Then fills all the fields with
        /// the data of the selected work hour.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            LblDays.Show();
            LblEndTime.Show();
            LblStartTime.Show();
            DtpEndTime.Show();
            DtpStartTime.Show();
            CmbDays.Show();
            BtnEdit.Show();

            label1.Hide();
            CmbWorkHours.Hide();
            BtnSelect.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbWorkHours.SelectedValue));
            DtpEndTime.Text = SelectedData.Rows[0]["End_Time"].ToString();
            DtpStartTime.Text = SelectedData.Rows[0]["Start_Time"].ToString();

            CmbDays.DataSource = DCom.GetData("SELECT * FROM days");
            CmbDays.DisplayMember = "NAME";
            CmbDays.ValueMember = "NAME";
            CmbDays.Text = SelectedData.Rows[0]["Day"].ToString();
        }

        /// <summary>
        /// Finally when the client made the changes that he wants the program checks if all the fields 
        /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
        /// update of the work hour, else show a error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DtpStartTime.Text) || string.IsNullOrWhiteSpace(DtpEndTime.Text) ||
               string.IsNullOrWhiteSpace(CmbDays.Text) )
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, DtpStartTime.Text, DtpEndTime.Text, CmbDays.SelectedValue, CmbWorkHours.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }
    }
}
