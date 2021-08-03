using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Bai_Tap_Lon_Winform
{
    class DataProcessing
    {
        DBConnection dataConn = new DBConnection();

        public void AddTenSach(ComboBox cbb)  // Thêm sữ liệu vào combobox tên sách
        {
            try
            {
                DBConnection db = new DBConnection();
                SqlConnection conn = db.getConnect();
                conn.Open();
                string sql1 = "Select * from Sach";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                cbb.DataSource = table.Copy();
                cbb.DisplayMember = "TenSach";
                cbb.ValueMember = "MaSach";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
    }
}
