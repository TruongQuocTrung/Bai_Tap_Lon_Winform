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
        DBConnection db = new DBConnection();
       
        public void AddTenSach(ComboBox cbb)  // Thêm sữ liệu vào combobox tên sách
        {
            try
            {
                string sql = "Select * from Sach";
                db.getExecuteNonQuery(sql);
                DataTable table = db.getTable(sql);
                cbb.DataSource = table.Copy();
                cbb.DisplayMember = "TenSach";
                cbb.ValueMember = "MaSach";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
        public string chucVuNV;
        public void getLogin(String userName,String passWord, Form fr)
        {
           // Kiểm tra tài khoản có trong bảng tài khoản hay không, nếu có thì cho đăng nhập
            String login = "Select * from ThuNgan where TenDN='" + userName + "' and MatKhau='" + passWord + "'";
            db.getExecuteNonQuery(login);
            DataTable table= db.getTable(login);
           
            if (table.Rows.Count == 1)   // Tài khoản có tồn tại trong bảng ThuNgan
            {
               string maNV = table.Rows[0]["MaNV"].ToString().Trim();
               Form1 frmMain = new Form1();
                fr.Hide();  // Ẩn form đăng nhập đi
                frmMain.Show(); // show form chính lên

                // Lấy tên thu ngân dựa vào MaNV lấy được khi đăng nhập
                String getName = "Select HoTen,ChucVu from NhanVien Where MaNV='" + maNV + "'";
                db.getExecuteNonQuery(getName);
                DataTable tableNhanVien = db.getTable(getName);

                if (table.Rows.Count == 1) // Mã nhân viên có tồn tại trong bảng NhanVien
                {

                    frmMain.tenNV = tableNhanVien.Rows[0]["HoTen"].ToString().Trim();
                    frmMain.showTenThuNgan();
                    //Lấy ra chức vụ để phân quyền trong form chính
                    chucVuNV = tableNhanVien.Rows[0]["ChucVu"].ToString().Trim();
                    
                        frmMain.chucVu=chucVuNV;
                        frmMain.phanQuyen();       
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên nhân viên");
                   
                }
            }
            else
            {
                MessageBox.Show("Không Thể Đăng Nhập Vui lòng Liên Hệ Quản Lý Hỗ trợ !", "" +
                    "Lost Login!");
               
            } 
        }
        DataTable TableDonHang = new DataTable();

        
        
    }
}
