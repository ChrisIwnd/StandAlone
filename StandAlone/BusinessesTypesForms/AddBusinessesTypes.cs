using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.Businesses_Types
{
    public partial class AddBusinessesTypes : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is the mysql command for the insert of user type.
        /// </summary>
        string SqlInsert = "INSERT INTO businesses_types VALUES ('{0}')";

        /// <summary>
        /// This is the constructor of the form.
        /// </summary>
        public AddBusinessesTypes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the user write the name of the type that wants to
        /// add and press the Add button the system checks if 
        /// the field is fill. If if the field is fill the program
        /// add the type else shows the error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxAdd.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DCom.CountCheck("businesses_types", "Type", TbxAdd.Text) == true)
            {
                MessageBox.Show("THE TYPE ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
