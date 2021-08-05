using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai_Tap_Lon_Winform
{
    class KhachHangProcessing
    {
        DBConnection db = new DBConnection();
        public DataTable showKH()
        {
            string sql = "Select * from KhachHang";
            DataTable dt= db.getTable(sql);
            return dt;
        }
        public void addKH(string maKH,string hoTen,string gt,string maSoThue,string diaChi,string SDT,string loaiKH)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm khách hàng  " + hoTen + "", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                string sql = "Insert Into KhachHang Values('" + maKH + "',N'" + hoTen + "','" + gt + "','" +maSoThue+ "',N'" + diaChi + "',N'" + SDT + "','" + loaiKH + "')";
                db.getExecuteNonQuery(sql);
            }
        }
    }
}
