using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.BusinessForms
{
    public partial class DeleteBusinessForm : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for the deletion of user type.
        /// </summary>
        string SqlDelete = "DELETE FROM businesses WHERE ID = {0}";

        public DeleteBusinessForm()
        {
            InitializeComponent();

            CmbBusiness.DataSource = DCom.GetData("SELECT businesses.ID, CONCAT(businesses.Business_Name, ', ', location.Address_Name, ', ', location.Municipality) AS NAME FROM businesses, location WHERE businesses.Location_ID = location.ID");
            CmbBusiness.DisplayMember = "NAME";
            CmbBusiness.ValueMember = "ID";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this business?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DCom.Exec(String.Format(SqlDelete, CmbBusiness.SelectedValue));

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
