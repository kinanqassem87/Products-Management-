﻿using System;
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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtId.Text, txtPwd.Text);
            if (dt.Rows.Count > 0)
            {
                FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.المستخدمونToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else { MessageBox.Show("البيانات المدخلة خاطئة"); }
        }
    }
}
