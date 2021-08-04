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
    class DAOLogin
    {
        DBConnection db = new DBConnection();
        public String getLogin(String TenDN, String MatKhau)
        {
            String sql = " SELECT MaNV FROM ThuNgan WHERE TenDN = '" + TenDN + "' AND MatKhau='" + MatKhau + "'";
            String MaNV = db.getSingleData(sql);
            return MaNV;
        }
        public String getQuyenDN(String TenDN, String MatKhau)
        {
            String MaNV = getLogin(TenDN,MatKhau);
            string sql = "SELECT ChucVu FROM NhanVien WHERE MaNV ='" + MaNV + "'";
            String ChucVu = db.getSingleData(sql);
            return ChucVu;
        }
        public String getTenNV(String MaNV)
        {
            String sql = "SELECT HoTen FROM NhanVien WHERE MaNV = '" + MaNV + "'";
            String TenNV = db.getSingleData(sql);
            return TenNV;
        }
    }
}
