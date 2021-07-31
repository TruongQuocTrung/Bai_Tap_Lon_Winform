using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Bai_Tap_Lon_Winform
{
    class TestConnect
    {
        //Xin chao thay va cac ban
        SqlConnection connection = new SqlConnection();
        public SqlConnection getConnect()
        {
            //connection.ConnectionString = @"Data Source=TRUONGQUOCTRUNG\SQLEXPRESS;Initial Catalog=Bai1_27/7;Persist Security Info=True;User ID=sa;Password=123";
            connection.ConnectionString = Bai_Tap_Lon_Winform.Properties.Settings.Default.ChuoiKetNoi;
            return connection;
        }
    }
}
