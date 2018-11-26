using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string id, string pwd)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID",SqlDbType.VarChar,50);
            param[0].Value = id;
            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar,50);
            param[1].Value = pwd;
            DataTable dt = new DataTable();
            dt = dal.SelectData("SP_LOGIN", param);
            return dt;
        }
    }
}
