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
            SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = @"Data Source=TRUONGQUOCTRUNG\SQLEXPRESS;Initial Catalog=QuanLyNhaSach;Persist Security Info=True;User ID=sa;Password=123";
            connection.ConnectionString = @"Data Source=DESKTOP-QKORJ1O;Initial Catalog=QuanLyNhaSach;Persist Security Info=True;User ID=sa;Password=123";
            return connection;
        }

        public DataTable getTable(String sql)
        {
            DataTable table = new DataTable();
            SqlConnection connect = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(table);
            return table;
        }
        public String getSingleData(String sql)
        {
              SqlConnection connection = getConnect();
              connection.Open();
              SqlCommand command = new SqlCommand(sql, connection);
              SqlDataReader dataReader = command.ExecuteReader();
              while (dataReader.Read())
              {
                  return dataReader[0].ToString();
              }
              return null;
              connection.Close();
        }
        public void getExecuteNonQuery(String sql)
        {
            SqlConnection connect = getConnect();
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
