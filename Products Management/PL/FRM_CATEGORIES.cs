using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Products_Management.PL
{
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlconnection = new SqlConnection(@"Server=Admin;Database=Product_DB;Integrated Security=false;User Id=sa;password=123");
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_CAT as 'المعرف',DESCRIPTION_CAT as 'الصنف' from CATEGORIES",sqlconnection);
            da.Fill(dt);
            dgvList.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "المعرف");
            txtDesc.DataBindings.Add("text", dt, "الصنف");
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position+1) + "/" + bmb.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnPreviuos_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtID.Text = id.ToString();
            txtDesc.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //end current stage
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("added", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Item Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Edited Successfuly", "Edit Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }
    }
}
