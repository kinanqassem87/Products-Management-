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
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMERS cust = new BL.CLS_CUSTOMERS();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            dgvCustomer.DataSource = cust.Get_All_Customers();
            dgvCustomer.Columns[0].Visible = false;
            dgvCustomer.Columns[5].Visible = false;
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
