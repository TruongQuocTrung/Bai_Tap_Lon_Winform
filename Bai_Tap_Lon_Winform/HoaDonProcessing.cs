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

    class HoaDonProcessing
    {
        DBConnection db = new DBConnection();
        public DataTable loadHD()
        {
            
            string sql= "Select SoHD , ThuNgan , GioBan, TongTien ,KhachDua ,SLHang ,NgayBan from HoaDon";
            DataTable dt = db.getTable(sql);
            dt.Columns["SoHD"].ColumnName = "Số Hóa Đơn";
            dt.Columns["NgayBan"].ColumnName = "Ngày Bán";
            dt.Columns["ThuNgan"].ColumnName = "Thu Ngân";
            dt.Columns["GioBan"].ColumnName = "Giờ Bán";
            dt.Columns["TongTien"].ColumnName = "Tổng Tiền";
            dt.Columns["KhachDua"].ColumnName = "Khách Đưa";
            dt.Columns["SLHang"].ColumnName = "Sl Bán";
            return dt;
        }
        public DataTable loadCTHD()
        {
           
            string sql = "Select * ,(SoLuongBan*GiaBan) as Tong from ChiTietHoaDon";
            DataTable dt = db.getTable(sql); 
            dt.Columns["SoHD"].ColumnName = "Số Hóa Đơn";
            dt.Columns["MaSach"].ColumnName = "Mã Sách";
            dt.Columns["SoLuongBan"].ColumnName = "Số Lượng Bán";
            dt.Columns["GiaBan"].ColumnName = "Giá Bán";
            dt.Columns["MaKH"].ColumnName = "Mã Khách hàng";
            dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
            return dt;
        }
    }
}
