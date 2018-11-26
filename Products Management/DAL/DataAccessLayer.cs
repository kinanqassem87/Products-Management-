using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Products_Management.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        //This constructor to initialize the connection object
        public DataAccessLayer()
        {
            if (Properties.Settings.Default.Mode == "Sql")
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ";Database=" + Properties.Settings.Default.Database + ";Integrated Security=false;User Id="+Properties.Settings.Default.UserID+";password="+Properties.Settings.Default.Pwd);
            }
            else
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ";Database=" + Properties.Settings.Default.Database + ";Integrated Security=true");

            }
        }

        //Method to open connection
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
            
        }

        //Method to close connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Method to read Data from Database
        public DataTable SelectData(string stored_procedure,SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Method to Insert, Update and Delete data from database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                //for (int i = 0; i < param.Length; i++)
                //{
                //    sqlcmd.Parameters.Add(param[i]);
                //}
                //or
                sqlcmd.Parameters.AddRange(param);
                sqlcmd.ExecuteNonQuery();
            }
        }
    }
}
