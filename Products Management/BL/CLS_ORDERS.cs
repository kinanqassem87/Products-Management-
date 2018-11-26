using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Products_Management.BL
{
    
    class CLS_ORDERS
    {
        public DataTable get_last_order_id()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = dal.SelectData("get_last_order_id", null);
            dal.Close();
            return dt;
        }
    }
}
