using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            txtSever.Text = Properties.Settings.Default.Server;
            txtDB.Text = Properties.Settings.Default.Database;

            if (Properties.Settings.Default.Mode.Equals("Sql"))
            {
                rbSQL.Checked = true;
                txtUserName.Text = Properties.Settings.Default.UserID;
                txtPassword.Text = Properties.Settings.Default.Pwd;
            }
            else
            {
                rbWindows.Checked = true;
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.ReadOnly = txtPassword.ReadOnly = true;
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtSever.Text;
            Properties.Settings.Default.Database = txtDB.Text;
            Properties.Settings.Default.Mode = rbSQL.Checked == true ? "Sql" : "Windows";
            Properties.Settings.Default.UserID = txtUserName.Text;
            Properties.Settings.Default.Pwd = txtPassword.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح");
            Close();
        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.ReadOnly = txtPassword.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.ReadOnly = txtPassword.ReadOnly = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
