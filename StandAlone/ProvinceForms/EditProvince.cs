using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone.ProvinceForms
{
  public partial class EditProvince : Form
  {
    /// <summary>
    /// This is our variables that we need to interact with our base.
    /// The DataTable is to retreve data from out base and the
    /// two string is mysql commands.
    /// </summary>
    DataTable SelectedData;
    string SqlExec = "SELECT * FROM province WHERE Province_Name = '{0}'";
    string SqlUpdate = "UPDATE province SET Province_Name = '{0}' WHERE Province_Name = '{1}'";

        /// <summary>
        /// In forms constructor the not necessarily labels, tetxboxes and comboboxes are hiding 
        /// from the form. Then the combobox for province(comboBoxptovince) is filling with the data from table province.
        /// </summary>
        public EditProvince()
    {
      InitializeComponent();

      TbxProvinceName.Hide();
      labelpro.Hide();
      BtnEdit.Hide();

      comboBoxptovince.DataSource = DCom.GetData("SELECT * FROM province");
      comboBoxptovince.DisplayMember = "Province_Name";
      comboBoxptovince.ValueMember = "Province_Name";


    }
    
    
    /// <summary>
    /// Finally when the client made the changes that he wants the program checks if all the fields 
    /// all fields are fill. If all fields are fill then the program exec the apropriate querry for the
    /// update of the province, else show a error message.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnEdit_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(TbxProvinceName.Text))
      {
        MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else if (DCom.CountCheck("province", "Province_Name", TbxProvinceName.Text) == true)
      {
        MessageBox.Show("THE USERNAME ALREADY EXIST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        DCom.Exec(String.Format(SqlUpdate, TbxProvinceName.Text, comboBoxptovince.SelectedValue));
        MessageBox.Show("Edit Complete");
        Close();
      }
    }

    /// <summary>
    /// When the client select the privince that wants to edit the not necessarily labels, tetxboxes and comboboxes are hiding 
    /// from the form and then the neccesarily labels, tetxboxes and comboboxes are pop up. Then fills all the fields with
    /// the data of the selected province.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnselect_Click(object sender, EventArgs e)
    {
      label2.Hide();
      comboBoxptovince.Hide();
      TbxProvinceName.Hide();
      btnselect.Hide();
      labelpro.Show();
      TbxProvinceName.Show();
      BtnEdit.Show();

      SelectedData = DCom.GetData(String.Format(SqlExec, comboBoxptovince.SelectedValue));
      TbxProvinceName.Text = (string)SelectedData.Rows[0]["Province_Name"];
      

     
    }
  }
}
