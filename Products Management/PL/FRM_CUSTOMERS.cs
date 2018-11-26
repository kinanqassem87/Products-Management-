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
    public partial class FRM_CUSTOMERS : Form
    {

        BL.CLS_CUSTOMERS custom = new BL.CLS_CUSTOMERS();
        int id,position;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            this.dgvCustomers.DataSource = custom.Get_All_Customers();
            dgvCustomers.Columns[0].Visible = false;
            dgvCustomers.Columns[5].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img;
                if (picCustomer.Image == null)
                {
                    img = new byte[0];
                    custom.ADD_CUSTOMER(txtFname.Text, txtLname.Text, txtPhone.Text, txtMail.Text, img, "without_image");
                    this.dgvCustomers.DataSource = custom.Get_All_Customers();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    picCustomer.Image.Save(ms, picCustomer.Image.RawFormat);
                    img = ms.ToArray();
                    custom.ADD_CUSTOMER(txtFname.Text, txtLname.Text, txtPhone.Text, txtMail.Text, img, "with_image");
                    this.dgvCustomers.DataSource = custom.Get_All_Customers();
                }
                MessageBox.Show("Customer Added", "Add customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error !! Try again please!");
            }
            finally { btnAdd.Enabled = false; btnNew.Enabled = true; }
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور | *.jpg; *.png; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picCustomer.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtMail.Clear();
            txtPhone.Clear();
            picCustomer.Image = null;
            txtFname.Focus();
            btnAdd.Enabled = true;
            btnNew.Enabled = false;

            
        }

        private void txtFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLname.Focus();
            }
        }

        private void txtLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMail.Focus();
            }
        }

        private void txtMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Focus();
            }
        }

        private void btnAdd_KeyDown(object sender, KeyEventArgs e)
        {
            btnAdd_Click(null, null);
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                picCustomer.Image = null;
                id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                txtFname.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                txtLname.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
                txtMail.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
                byte[] img = (byte[])dgvCustomers.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                picCustomer.Image = Image.FromStream(ms);
            }
            catch { return; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0) { return; }
            try
            {
                byte[] img;
                if (picCustomer.Image == null)
                {
                    img = new byte[0];
                    custom.EDIT_CUSTOMER(txtFname.Text, txtLname.Text, txtPhone.Text, txtMail.Text, img, "without_image",id);
                    this.dgvCustomers.DataSource = custom.Get_All_Customers();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    picCustomer.Image.Save(ms, picCustomer.Image.RawFormat);
                    img = ms.ToArray();
                    custom.EDIT_CUSTOMER(txtFname.Text, txtLname.Text, txtPhone.Text, txtMail.Text, img, "with_image",id);
                    this.dgvCustomers.DataSource = custom.Get_All_Customers();
                }
                MessageBox.Show("Customer Updated", "Update customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error !! Try again please!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id == 0) { return; }
            if (MessageBox.Show("Are u sure to delete this customer ? ", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                custom.Delete_Customer(id);
                MessageBox.Show("Done!");
                dgvCustomers.DataSource = custom.Get_All_Customers();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = custom.Search_Customer(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAccept_Click(sender, e);
            }
        }

        void Navigate(int index)
        {
            picCustomer.Image = null;
            DataTable dt = custom.Get_All_Customers();
            try
            {
                //or
                // DataRowCollection drc = dt.Rows;
                // txtFname.Text = drc[index][1].ToString();
                id = Convert.ToInt32(dt.Rows[index][0].ToString());
                txtFname.Text = dt.Rows[index][1].ToString();
                txtLname.Text = dt.Rows[index][2].ToString();
                txtPhone.Text = dt.Rows[index][3].ToString();
                txtMail.Text = dt.Rows[index][4].ToString();
                byte[] img = (byte[])dt.Rows[index][5];
                MemoryStream ms = new MemoryStream(img);
                picCustomer.Image = Image.FromStream(ms);
            }
            catch { return; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            position = custom.Get_All_Customers().Rows.Count-1;
            Navigate(position);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (position == 0) { return; }
              position -= 1;
              Navigate(position);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (position == custom.Get_All_Customers().Rows.Count - 1) { return; }
            position += 1;
            Navigate(position);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }
    }
}
