using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Sourav
{
    public class DBoperation
    {
        //Show Table

        string connec = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public DataTable GetDataTable(string _query)
        {
            SqlConnection con = new SqlConnection(connec);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(_query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //insert Operation

        public int ExecuteQuery(string query)
        {
            SqlConnection conn = new SqlConnection(connec);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.ExecuteNonQuery();
                return 1;


            }
            catch (SqlException ex)
            {
                return 0;
            }

        }
    }
}