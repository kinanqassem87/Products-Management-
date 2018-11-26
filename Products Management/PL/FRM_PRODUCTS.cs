using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.CrystalReports;
//using CrystalDecisions.Shared;

namespace Products_Management.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        private static FRM_PRODUCTS frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }
        }




        BL.CLS_PRODUCT pdr = new BL.CLS_PRODUCT();
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null) { frm = this; }
            this.dataGridView1.DataSource = pdr.GET_ALL_PRODUCTS();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pdr.SearchProduct(textBox1.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف هذا العنصر ؟", "حذف عنصر", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pdr.DeletePro(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تم الحذف بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = pdr.GET_ALL_PRODUCTS();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDesc.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQty.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تحديث المنتج:  " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnAdd.Text = "تعديل المنتج";
            frm.state = "update";
            frm.txtRef.ReadOnly = true;
            byte[] img = (byte[])pdr.Get_Image_Product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
            byte[] img = (byte[])pdr.Get_Image_Product(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            frm.imgView.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void saveToExcel_Click(object sender, EventArgs e)
        {
            //Depend on Reports 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
