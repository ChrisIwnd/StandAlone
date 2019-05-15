using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandAlone
{
    public partial class LoginForm : Form
    {
        int checktries = 1;

        public LoginForm()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbxPassword.Text) || string.IsNullOrWhiteSpace(TbxPassword.Text))
            {
                MessageBox.Show("PLEASE ADD ALL THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                DataTable getLogin = DCom.GetData(String.Format("SELECT COUNT(*) FROM login WHERE Username = '{0}' AND Password = '{1}'", TbxUsername.Text, TbxPassword.Text));
                string getCount = getLogin.Rows[0]["COUNT(*)"].ToString();


                if (getCount == "1")
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    checktries++;
                    if (checktries > 3)
                    {
                        MessageBox.Show("USER NOT FOUND, PLEASE TRY AGAIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                    MessageBox.Show("USER NOT FOUND, PLEASE TRY AGAIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
