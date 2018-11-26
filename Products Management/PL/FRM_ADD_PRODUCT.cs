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

namespace Products_Management.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "add";

        BL.CLS_PRODUCT PRODUCT = new BL.CLS_PRODUCT();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            cmbCategories.DataSource = PRODUCT.GET_ALL_CATEGORIES();
            cmbCategories.DisplayMember = "DESCRIPTION_CAT";
            cmbCategories.ValueMember = "ID_CAT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg; *.png; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImg = ms.ToArray();
                PRODUCT.ADD_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDesc.Text, txtRef.Text,
                    Convert.ToInt32(txtQty.Text), txtPrice.Text, byteImg);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesc.Text = txtPrice.Text = txtQty.Text = txtRef.Text = "";
                pbox.Image = null;
            }
            else
            {
                MemoryStream ms1 = new MemoryStream();
                pbox.Image.Save(ms1, pbox.Image.RawFormat);
                byte[] byteImg1 = ms1.ToArray();
                PRODUCT.UPDATE_PRODUCT(Convert.ToInt32(cmbCategories.SelectedValue), txtDesc.Text, txtRef.Text,
                    Convert.ToInt32(txtQty.Text), txtPrice.Text, byteImg1);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesc.Text = txtPrice.Text = txtQty.Text = txtRef.Text = "";
                pbox.Image = null;
            }
            FRM_PRODUCTS.getMainForm.dataGridView1.DataSource= PRODUCT.GET_ALL_PRODUCTS();

        }

        private void txtRef_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = PRODUCT.verfiyProductID(txtRef.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("معرف المنتج موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRef.Focus();
                    txtRef.SelectionStart = 0;
                    txtRef.SelectionLength = txtRef.Text.Length;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
