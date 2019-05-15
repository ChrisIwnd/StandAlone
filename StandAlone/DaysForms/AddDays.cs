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
    public partial class AddDays : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is the mysql command for the insert of user type.
        /// </summary>
        string SqlInsert = "INSERT INTO days VALUES ('{0}')";

        /// <summary>
        /// This is the constructor of the form.
        /// </summary>
        public AddDays()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This state is when the client press the button to add a record.
        /// Before it goes to add the record it checks if all the fields are completed.
        /// After that checks if the province already exists.
        /// Then add the record in database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxAdd.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheck("days", "Name", TbxAdd.Text) == true)
            {
                MessageBox.Show("THE DAY ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlInsert, TbxAdd.Text));
                MessageBox.Show("ADD COMPLETE");
                Close();
            }
        }
    }
}
