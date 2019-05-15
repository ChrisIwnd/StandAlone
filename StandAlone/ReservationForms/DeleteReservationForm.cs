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
    public partial class DeleteReservationForm : Form
    {
        /// <summary>
        /// This is our variables that we need to interact with our base.
        /// The string below is a mysql command for our base.
        /// </summary>
        string SqlDelete = "DELETE FROM reservation WHERE ID = {0}";

        /// <summary>
        /// In the constructor the from is created.
        /// Then the combobox of the form is fill with the ID and NAME  
        /// from reservation.
        /// </summary>
        public DeleteReservationForm()
        {
            InitializeComponent();

            CmbReservations.DataSource = DCom.GetData("SELECT ID, CONCAT(ID, ', ', User, ', ', BusinessID) AS NAME FROM reservation");
            CmbReservations.DisplayMember = "NAME";
            CmbReservations.ValueMember = "ID";
        }

        /// <summary>
        /// When the client select the reservation from the combo box, press the Delete button
        /// to delete him. Then the system show up a message that warning him if he
        /// is sure for this action. If the client press YES then the system execute the
        /// querry and delete the reservation. Else the system will do nothig.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this reservation?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DCom.Exec(String.Format(SqlDelete, CmbReservations.SelectedValue));

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
