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
        public void addSachBan(String MaSach, String MaNV, String MaKH, String SoHD, int SlTonKho, int SoLuongSachBan, int GiaBan, int TongTien)
        {
            try
            {
                String sql = "INSERT INTO SachBan VALUES('" + MaSach + "', '" + MaNV + "', '" + MaKH + "', '" + SoHD + "', " + SlTonKho + "," + SoLuongSachBan + "," + GiaBan + "," + TongTien + ")";
                db.getExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void addHoaDon(String SoHD, DateTime NgayBan, String ThuNgan, String GioBan, int TongTien, int KhachDua, int SlHang, int GiamGia)
        {
            try
            {
                String sql = "INSERT INTO HoaDon VALUES('" + SoHD + "', '" + NgayBan + "', N'" + ThuNgan + "', '" + GioBan + "', " + TongTien + ", " + KhachDua + ", " + SlHang + ","+GiamGia+")";
                db.getExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Số hóa đơn đã tồn tại, kiểm tra lại", "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addChiTietHoaDon(String SoHD, String MaSach, int SoLuongBan, int GiaBan, String MaKH)
        {
            try
            {
                String sql ="INSERT INTO ChiTietHoaDon VALUES('"+SoHD+"', '"+MaSach+"', "+SoLuongBan+", "+GiaBan+",'"+MaKH+"')";
                db.getExecuteNonQuery(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateSlTonSach(int SoLuong, String MaSach)
        {
            String sql = "UPDATE Sach SET SoLuong = " + SoLuong + " WHERE MaSach = '" + MaSach + "'";
            db.getExecuteNonQuery(sql);
        }
    }
}
