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
    public partial class AddWorkHours : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for instert to our base.
        /// </summary>
        string SqlExec = "INSERT INTO work_hours(Start_Time, End_Time, Day) VALUES('{0}', '{1}', '{2}')";

        /// In forms constractor the Combobox for Days(CmbDays) fills up from the table days
        /// that contains all the days. The diplay member is the name of the day(Row Name) 
        /// and the value member is the same.
        public AddWorkHours()
        {
            InitializeComponent();
            CmbDays.DataSource = DCom.GetData("SELECT * FROM days");
            CmbDays.DisplayMember = "Name";
            CmbDays.ValueMember = "Name";
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
            if (string.IsNullOrWhiteSpace(DtpEndTime.Text) || string.IsNullOrWhiteSpace(DtpStartTime.Text) ||
               string.IsNullOrWhiteSpace(CmbDays.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlExec, this.DtpStartTime.Text, DtpEndTime.Text, CmbDays.SelectedValue));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
