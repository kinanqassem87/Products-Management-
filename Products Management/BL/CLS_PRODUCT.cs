using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    class CLS_PRODUCT
    {
        
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GET_ALL_CATEGORIES", null);
            return dt;
        }
        public void ADD_PRODUCT(int ID_cat, string label_pro, string ID_pro, int qty, string price, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;
            param[1] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar,30);
            param[1].Value = label_pro;
            param[2] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar,30);
            param[2].Value = ID_pro;
            param[3] = new SqlParameter("@QTY", SqlDbType.Int);
            param[3].Value = qty;
            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[4].Value = price;
            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = img;

            dal.ExecuteCommand("ADD_PRODUCT", param);
            dal.Close();
        }

        public DataTable verfiyProductID(string ID_pro)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Product", SqlDbType.VarChar, 30);
            param[0].Value = ID_pro;
            dt = dal.SelectData("verfiyProductID", param);
            return dt;
        }

        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GET_ALL_PRODUCTS", null);
            return dt;
        }

        public DataTable SearchProduct(string search)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@search", SqlDbType.VarChar, 50);
            param[0].Value = search;
            DataTable dt = new DataTable();
            dt = dal.SelectData("SearchProduct", param);
            return dt;
        }

        public void DeletePro(string ID_pro)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = ID_pro;
            dal.ExecuteCommand("DeletePro", param);
            dal.Close();
        }

        public DataTable Get_Image_Product(string id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = dal.SelectData("Get_Image_Product", param);
            return dt;
        }

        public void UPDATE_PRODUCT(int ID_cat, string label_pro, string ID_pro, int qty, string price, byte[] img)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;
            param[1] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar, 30);
            param[1].Value = label_pro;
            param[2] = new SqlParameter("@ID_PRODUCT", SqlDbType.VarChar, 30);
            param[2].Value = ID_pro;
            param[3] = new SqlParameter("@QTY", SqlDbType.Int);
            param[3].Value = qty;
            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = price;
            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = img;

            dal.ExecuteCommand("UPDATE_PRODUCT", param);
            dal.Close();
        }
    }
}
