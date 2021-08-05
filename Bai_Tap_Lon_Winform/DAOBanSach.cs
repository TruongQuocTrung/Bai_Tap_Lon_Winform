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
    class DAOBanSach
    {
        DBConnection db = new DBConnection();
        public DataTable getItemCBBTenSach()
        {
            String sql = "SELECT MaSach, TenSach FROM Sach";
            DataTable table = db.getTable(sql);
            return table;
        }
        public String getTenKHbyMaKH(String MaKH)
        {
            String sql = "SELECT TenKH FROM KhachHang WHERE MaKH = '"+MaKH+"'";
            String TenKH = db.getSingleData(sql);
            return TenKH;
        }
        public String getLoaiKHbyMaKH(String MaKH)
        {
            String sql = "SELECT LoaiKH FROM KhachHang WHERE MaKH = '" + MaKH + "'";
            String LoaiKH = db.getSingleData(sql);
            return LoaiKH;
        }
        public DataTable getTTSachBan(String MaSach)
        {
            String sql = "SELECT TenSach, SoLuong, DonGia FROM Sach WHERE MaSach ='"+MaSach+"'";
            DataTable table = db.getTable(sql);
            return table;
        }
    }
}
