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
    class DAOSach
    {
        // gọi lớp kết nối
        DBConnection db = new DBConnection();
        // lấy dữ liệu từ bảng Sách
        public DataTable getDGVQLSach()
        {
            String sql = "SELECT * FROM Sach";
            DataTable table = db.getTable(sql);
            return table;
        }
        // lấy dữ liệu bảng TacGia vào cbbTacGia
        public DataTable getCBBTacGia()
        {
            String sql = "SELECT MaTG, TenTG FROM TacGia";
            DataTable table = db.getTable(sql);
            return table;
        }
        // lấy dữ liệu từ bảng TheLoai vào cbbTheLoai
        public DataTable getCBBTheLoai()
        {
            String sql = "SELECT MaTL, TenTL FROM TheLoai";
            DataTable table = db.getTable(sql);
            return table;
        }
        // lấy dữ liệu từ bảng NhaXuatBan vào cbbNhaXB
        public DataTable getCBBNXB()
        {
            String sql = "SELECT MaNXB, TenNXB FROM NhaXuatBan";
            DataTable table = db.getTable(sql);
            return table;
        }
    }
}
