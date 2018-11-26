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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }
        }


        public FRM_MAIN()
        {
            
            InitializeComponent();
            if (frm == null) { frm = this; }
            this.المنتوجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void اضافةمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void ادارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.ShowDialog();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void اضافةعمليةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();
        }

        private void اعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG frm = new FRM_CONFIG();
            frm.ShowDialog();
        }
    }
}
