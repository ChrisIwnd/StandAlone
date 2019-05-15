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
    public partial class DeleteBusinessesTypes : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for the deletion of user type.
        /// </summary>
        string SqlDeleteUsersTypes = "DELETE FROM businesses_types WHERE Type = '{0}'";

        /// <summary>
        /// This is forms constructor.
        /// In this constructor the combobox for user types(CmbBusinessesTypes) is
        /// filling from the user types table(businesses_types).
        /// </summary>
        public DeleteBusinessesTypes()
        {
            InitializeComponent();

            CmbBusinessesTypes.DataSource = DCom.GetData("SELECT * FROM businesses_types");
            CmbBusinessesTypes.DisplayMember = "Type";
            CmbBusinessesTypes.ValueMember = "Type";
        }

        /// <summary>
        /// When the client select the user type from the combo box, press the Delete button
        /// to delete it. Then the system show up a message that warning him if he
        /// is sure for this action. If the client press YES then the system execute the
        /// querry and delete the user type. Else the system will do nothig.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this business type?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DCom.Exec(String.Format(SqlDeleteUsersTypes, CmbBusinessesTypes.SelectedValue));

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
