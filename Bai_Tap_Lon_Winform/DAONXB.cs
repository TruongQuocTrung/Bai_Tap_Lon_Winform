using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Bai_Tap_Lon_Winform
{
    
    class DAONXB
    {
        DBConnection db = new DBConnection();
        // lấy dữ liệu bảng NXB
        public DataTable getDGVNXB()
        {
            String sql = "SELECT * FROM NhaXuatBan";
            DataTable table = db.getTable(sql);
            return table;
        }
        // thêm dữ liệu vào bảng NXB
        public bool addNXB(String MaNXB, String TenNXB, String DiaChiNXB, String DienThoai)
        {
            try
            {
                String sql = "INSERT INTO NhaXuatBan VALUES('" + MaNXB + "',N'" + TenNXB + "',N'" + DiaChiNXB + "','" + DienThoai + "')";
                db.getExecuteNonQuery(sql);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Trùng mã NXB", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        // sửa dữ liệu
        public void editNXB(String MaNXB, String TenNXB, String DiaChiNXB, String DienThoai)
        {
            String sql = "UPDATE NhaXuatBan SET TenNXB = N'"+TenNXB+"', DiaChiNXB = N'"+DiaChiNXB+"', DienThoai = '"+DienThoai+"' WHERE MaNXB = '"+MaNXB+"'";
            db.getExecuteNonQuery(sql);
        }
        // xóa dữ liệu
        public void deleteNXB(String MaNXB)
        {
            String sql = "DELETE FROM NhaXuatBan WHERE MaNXB = '" + MaNXB + "'";
            db.getExecuteNonQuery(sql);
        }
        // tìm kiếm
        public DataTable findNXB(String MaNXB)
        {
            String sql = "SELECT * FROM NhaXuatBan WHERE MaNXB = '" + MaNXB + "'";
            DataTable table = db.getTable(sql);
            return table;
        }
    }
}