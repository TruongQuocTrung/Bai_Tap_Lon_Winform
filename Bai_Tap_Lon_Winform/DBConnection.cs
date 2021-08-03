using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bai_Tap_Lon_Winform
{
    class DBConnection
    {
        public SqlConnection getConnect()
        {
            String connString = @"Data Source=DESKTOP-QKORJ1O;Initial Catalog=QuanLyNhaSach;Persist Security Info=True;User ID=sa;Password=123";
            return new SqlConnection(connString);
        }

        public DataTable GetTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public void ExecuteNonQuery(String sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
