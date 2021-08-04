using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai_Tap_Lon_Winform
{
    class DAONhanVien
    {
        // lấy connect
        DBConnection db = new DBConnection();
        // Lấy dữ liệu từ bảng nhân viên
        public DataTable getDataDGVNhanVien() 
        {
            String sql = "SELECT * FROM NhanVien";
            DataTable table = db.getTable(sql);
            return table;
        }
        // thêm dữ liệu vào bảng nhân viên
        public bool addNhanVien(String MaNV, String HoTen, DateTime NgaySinh, String GioiTinh, String DiaChi, String ChucVu)
        {
            try
            {
                String sql = "INSERT INTO NhanVien VALUES('" + MaNV + "',N'" + HoTen + "','" + NgaySinh + "','" + GioiTinh + "',N'" + ChucVu + "',N'" + DiaChi + "')";
                db.getExecuteNonQuery(sql);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Trùng mã nhân viên", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        // thêm dữ liệu đăng nhập vào tài khoản thu ngân
        public bool addTaiKhoanThuNgan(String MaNV, String TenDN, String MatKhau)
        {
            try
            {
                String sql = "INSERT INTO ThuNgan VALUES('" + MaNV + "',N'" + TenDN + "',N'" + MatKhau + "')";
                db.getExecuteNonQuery(sql);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản", "Có lỗi không xác định", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
