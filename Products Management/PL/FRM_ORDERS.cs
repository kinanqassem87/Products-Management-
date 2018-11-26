using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products_Management.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable dt = new DataTable();



         public void createDataTable()
          {
              dt.Columns.Add("معرف المنتج");
              dt.Columns.Add("اسم المنتج");
              dt.Columns.Add("سعر القطعة");
              dt.Columns.Add("الكمية");
              dt.Columns.Add("السعر الكلي");
              dt.Columns.Add("نسبة الخصم");
              dt.Columns.Add("السعر الاجمالي");

              dgvOrder.DataSource = dt;

              //Second method to get product to datagridView to add button
             /* DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
              btn.HeaderText = "اختيار منتج";
              btn.Text = "البحث";
              btn.UseColumnTextForButtonValue = true;
              dgvOrder.Columns.Insert(0,btn);*/


          }
         void ResizDGV()
        {
            dgvOrder.RowHeadersWidth = 37;
            dgvOrder.Columns[0].Width = 70;
            dgvOrder.Columns[1].Width = 137;
            dgvOrder.Columns[2].Width = 100;
            dgvOrder.Columns[3].Width = 100;
            dgvOrder.Columns[4].Width = 107;
            dgvOrder.Columns[5].Width = 107;
            dgvOrder.Columns[6].Width = 121;
        }
        public FRM_ORDERS()
        {
            InitializeComponent();
            createDataTable();
            //ResizDGV();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            txtOrderId.Text = order.get_last_order_id().Rows[0][0].ToString();
            btnSave.Enabled = true;
            btnNewOrder.Enabled = false;
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
            frm.ShowDialog();

            try
            {
                picCustomer.Image = null;
                txtCustID.Text = frm.dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                txtFname.Text = frm.dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                txtLName.Text = frm.dgvCustomer.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = frm.dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = frm.dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                byte[] img = (byte[])frm.dgvCustomer.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                picCustomer.Image = Image.FromStream(ms);
            }
            catch { return; }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS_LIST frm = new FRM_PRODUCTS_LIST();
            frm.ShowDialog();
            txtIDProduct.Text = frm.dgvProductList.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text=frm.dgvProductList.CurrentRow.Cells[1].Value.ToString();
            txtPriceOne.Text=frm.dgvProductList.CurrentRow.Cells[3].Value.ToString();
            

        }
    }
}
