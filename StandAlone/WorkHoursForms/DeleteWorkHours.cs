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
    public partial class DeleteWorkHours : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for our base.
        /// </summary>
        string SqlDeleteUsers = "DELETE FROM work_hours WHERE ID = {0}";

        /// <summary>
        /// In the constructor the from is created.
        /// Then the combobox of the form is fill with the ID 
        /// of the work hours
        /// </summary>
        public DeleteWorkHours()
        {
            InitializeComponent();
            CmbWorkHours.DataSource = DCom.GetData("SELECT * FROM work_hours");
            CmbWorkHours.DisplayMember = "ID";
            CmbWorkHours.ValueMember = "ID";
        }

        /// <summary>
        /// When the client select the work hour from the combo box, press the Delete button
        /// to delete it. Then the system show up a message that warning him if he
        /// is sure for this action. If the client press YES then the system execute the
        /// querry and delete the work hour. Else the system will do nothig.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this work hour?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DCom.Exec(String.Format(SqlDeleteUsers, CmbWorkHours.SelectedValue));

                MessageBox.Show("DELETE COMPLETE");
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("DELETE CANSEL");
            }
        }
    }
}
