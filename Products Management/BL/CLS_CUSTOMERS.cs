using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.BL
{
    class CLS_CUSTOMERS
    {
        public void ADD_CUSTOMER(string Fname, string Lname, string Tel, string Email, byte[] img,string criterion)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar,25);
            param[0].Value = Fname;
            param[1] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 25);
            param[1].Value = Lname;
            param[2] = new SqlParameter("@TEL", SqlDbType.NChar, 15);
            param[2].Value = Tel;
            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar,25);
            param[3].Value = Email;
            param[4] = new SqlParameter("@IMAGE_CUSTOMER", SqlDbType.Image);
            param[4].Value = img;
            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = criterion;

            dal.ExecuteCommand("ADD_CUSTOMER", param);
            dal.Close();
        }

        public void EDIT_CUSTOMER(string Fname, string Lname, string Tel, string Email, byte[] img, string criterion,int id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@FIRST_NAME", SqlDbType.VarChar, 25);
            param[0].Value = Fname;
            param[1] = new SqlParameter("@LAST_NAME", SqlDbType.VarChar, 25);
            param[1].Value = Lname;
            param[2] = new SqlParameter("@TEL", SqlDbType.NChar, 15);
            param[2].Value = Tel;
            param[3] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 25);
            param[3].Value = Email;
            param[4] = new SqlParameter("@IMAGE_CUSTOMER", SqlDbType.Image);
            param[4].Value = img;
            param[5] = new SqlParameter("@criterion", SqlDbType.VarChar, 50);
            param[5].Value = criterion;
            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Value = id;

            dal.ExecuteCommand("EDIT_CUSTOMER", param);
            dal.Close();
        }

        public DataTable Get_All_Customers()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_All_Customers", null);
            return dt;
        }
        public void Delete_Customer(int ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;
            dal.ExecuteCommand("Delete_Customer", param);
            dal.Close();
        }

        public DataTable Search_Customer(string search)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            dt = dal.SelectData("Search_Customer", param);
            return dt;
        }
    }
}
