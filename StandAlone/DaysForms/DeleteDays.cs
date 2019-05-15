using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.DaysForms
{
    public partial class DeleteDays : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for our base.
        /// </summary>
        string SqlDeleteDays = "DELETE FROM days WHERE Name = '{0}'";

        /// <summary>
        /// In the constructor the from is created.
        /// Then the combobox of the form is filled with the days 
        /// </summary>
        public DeleteDays()
        {
            InitializeComponent();
            CmbDay.DataSource = DCom.GetData("SELECT * FROM days");
            CmbDay.DisplayMember = "Name";
            CmbDay.ValueMember = "Name";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this day?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DCom.Exec(String.Format(SqlDeleteDays, CmbDay.SelectedValue));

                MessageBox.Show("DELETE COMPLETE");
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("CANCEL DELETE");
            }
        }
    }
}
