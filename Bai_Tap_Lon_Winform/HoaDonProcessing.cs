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
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select SoHD , ThuNgan , GioBan, TongTien ,KhachDua ,SLHang ,NgayBan from HoaDon";
                 dt = db.getTable(sql);
                dt.Columns["SoHD"].ColumnName = "Số Hóa Đơn";
                dt.Columns["NgayBan"].ColumnName = "Ngày Bán";
                dt.Columns["ThuNgan"].ColumnName = "Thu Ngân";
                dt.Columns["GioBan"].ColumnName = "Giờ Bán";
                dt.Columns["TongTien"].ColumnName = "Tổng Tiền";
                dt.Columns["KhachDua"].ColumnName = "Khách Đưa";
                dt.Columns["SLHang"].ColumnName = "Sl Bán";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable loadCTHD()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * ,(SoLuongBan*GiaBan) as Tong from ChiTietHoaDon";
                dt = db.getTable(sql);
                dt.Columns["SoHD"].ColumnName = "Số Hóa Đơn";
                dt.Columns["MaSach"].ColumnName = "Mã Sách";
                dt.Columns["SoLuongBan"].ColumnName = "Số Lượng Bán";
                dt.Columns["GiaBan"].ColumnName = "Giá Bán";
                dt.Columns["MaKH"].ColumnName = "Mã Khách hàng";
                dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public DataTable timHD(string maHD)
        {
           
                String sql = "select SoHD , ThuNgan , GioBan, TongTien ,KhachDua ,SLHang, NgayBan from HoaDon where SoHD='" + maHD + "'";
                DataTable dt = db.getTable(sql);
                if (dt.Rows.Count == 1)
                {
                    dt.Columns["SoHD"].ColumnName = "Số Hóa Đơn";
                    dt.Columns["NgayBan"].ColumnName = "Ngày Bán";
                    dt.Columns["ThuNgan"].ColumnName = "Thu Ngân";
                    dt.Columns["GioBan"].ColumnName = "Giờ Bán";
                    dt.Columns["TongTien"].ColumnName = "Tổng Tiền";
                    dt.Columns["KhachDua"].ColumnName = "Khách Đưa";
                    dt.Columns["SLHang"].ColumnName = "Sl Bán";
                }
                else { MessageBox.Show("Không Tìm Thấy Dữ Liệu Hóa Đơn . Vui Lòng kiểm tra lại !"); }
                return dt;
        }
        public DataTable timCTHD(string ma)
        {
            String sql = "Select* ,(SoLuongBan*GiaBan) as Tong from ChiTietHoaDon where  SoHD='" + ma+ "' or MaKh" +"='" + ma + "'";
            DataTable dt = db.getTable(sql);
            if (dt.Rows.Count != 0)
            {
                dt.Columns["SoHD"].ColumnName = "Mã Hóa Đơn";
                dt.Columns["MaSach"].ColumnName = "Mã Sách";
                dt.Columns["SoLuongBan"].ColumnName = "Số Lượng Bán";
                dt.Columns["MaKH"].ColumnName = "Mã Khách Hàng";
                dt.Columns["GiaBan"].ColumnName = "Giá Bán";
                dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
            }
            else { MessageBox.Show("Không Tìm Thấy Dữ Liệu CT Hóa Đơn. Vui Lòng kiểm tra lại !"); }
            return dt;
        }
    }
}
