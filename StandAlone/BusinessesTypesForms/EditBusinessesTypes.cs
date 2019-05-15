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
    public partial class EditBusinessesTypes : Form
    {
        /// <summary>
        /// his is our variables that we need to interact with our base.
        /// The DataTable is to retreve data from out base and the
        /// two string is mysql commands for. The first command is for the
        /// selection of data from the base and the second for the update.
        /// </summary>
        DataTable SelectedData;
        string SqlExec = "SELECT * FROM businesses_types WHERE Type = '{0}'";
        string SqlUpdate = "UPDATE businesses_types SET Type = '{0}' WHERE Type = '{1}'";

        /// <summary>
        /// In forms constructor the not necessarily labels and tetxboxes are hiding 
        /// from the form. Then the combobox for businesses types(CmbBusinessesTypes) is filling
        /// from the businesses types(businesses_types) table.
        /// /// </summary>
        public EditBusinessesTypes()
        {
            InitializeComponent();
            BtnEdit.Hide();
            LblGuide1.Hide();
            TbxEditiBusinessesTypes.Hide();

            CmbBusinessesTypes.DataSource = DCom.GetData("SELECT * FROM businesses_types");
            CmbBusinessesTypes.DisplayMember = "Type";
            CmbBusinessesTypes.ValueMember = "Type";
        }

        /// <summary>
        /// When the client select the user type that wants to edit the not necessarily labels and comboboxes are hiding 
        /// from the form and then the neccesarily labels and tetxboxes are pop up. Then fills all the fields with
        /// the data of the selected user type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            BtnEdit.Show();
            LblGuide1.Show();
            TbxEditiBusinessesTypes.Show();
            BtnSelect.Hide();
            CmbBusinessesTypes.Hide();
            LblGuide.Hide();

            SelectedData = DCom.GetData(String.Format(SqlExec, CmbBusinessesTypes.SelectedValue));
            TbxEditiBusinessesTypes.Text = (string)SelectedData.Rows[0]["Type"];
        }

        /// <summary>
        /// Finally when the client made the changes that he wants the program checks if all the fields 
        /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
        /// update of the user type, else show a error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxEditiBusinessesTypes.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DCom.Exec(String.Format(SqlUpdate, TbxEditiBusinessesTypes.Text, CmbBusinessesTypes.SelectedValue));
                MessageBox.Show("Edit Complete");
                Close();
            }
        }     
    }
}
