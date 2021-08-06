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
    class PhieuNhapProcessing
    {
        int check = 0;
        DBConnection db = new DBConnection();
        public DataTable showPhieuNhap()
        {   
                string sql= "Select *  from PhieuNhap";
                DataTable dt = db.getTable(sql);
                dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
                dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
                dt.Columns["MaNXB"].ColumnName = "Mã Nhà Xuất Bản";
                check = 0;
                return dt;
               
        }

        public DataTable showCTPhieuNhap()
        {
            string sql = "Select * ,(SoLuongNhap*GiaNhap) as Tong from ChiTietPhieuNhap";
            DataTable dt = db.getTable(sql);
            dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
            dt.Columns["MaSach"].ColumnName = "Mã Sách";
            dt.Columns["SoLuongNhap"].ColumnName = "Số Lượng Nhập";
            dt.Columns["GiaNhap"].ColumnName = "Giá Nhập";
            dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
            check = 1;
            return dt;
        }
        public void addPhieuNhap(String maPN,String ngayNhap,String maNXB )
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm phiếu nhập " + maPN, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    String sql = "Insert Into PhieuNhap Values('" + maPN + "','" + ngayNhap + "','" + maNXB + "')";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Phiếu nhập "+maPN+" đã được thêm vào hệ thống");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void addCTPhieuNhap(string maPN,string maSach,double SLN,double giaNhap)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm phiếu nhập " + maPN, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sql = "Insert Into ChiTietPhieuNhap(MaPN, MaSach,SoLuongNhap, GiaNhap)" +
                " values('" + maPN + "','" + maSach + "'," + SLN + "," + giaNhap + ")";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Mã sách " + maSach + " đã được thêm vào phiếu nhập "+maPN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void capNhatPN(string ngayNhap,string maNXB,string maPN)
        {
              try
                {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn lưu nhữn thay đổi", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sqlPN = "Update  PhieuNhap set NgayNhap='" + ngayNhap + "', MaNXB='" + maNXB + "' where MaPN='" + maPN + "'";
                    db.getExecuteNonQuery(sqlPN);
                    MessageBox.Show("Thông tin của phiếu nhập đã được cập nhật");
                }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Khi Cập Nhật Phiếu Nhập " + maPN);

                }

            
            
        }
        public void capNhatCTPN(string maSach, double slNhap, double giaNhap, string MaPN)
        {
            
                try
                {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn lưu những thay đỏi ", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sqlCTPN = "Update  ChiTietPhieuNhap Set MaSach ='" + maSach + "', SoLuongNhap=" + slNhap + ",GiaNhap=" + giaNhap
                         + " Where MaPN='" + MaPN + "'";
                    db.getExecuteNonQuery(sqlCTPN);
                    MessageBox.Show("Thông tin của sách đã được cập nhật vào phiếu nhập");
                }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Khi Cập Nhật Chi Tiết Phiếu Nhập " + MaPN);
                }
            
        }
        public void xoaPhieuNhap(string maPN)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập "+maPN, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sql = "Delete from PhieuNhap Where MaPN='" + maPN + "'";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Xóa Thành Công Phiếu Nhập " + maPN);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Khi Xóa Phiếu Nhập " + maPN);

            }
        }
        public void xoaCTPN(string MaPN)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xóa loại sách này trong phiếu nhập "+MaPN, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sql = "Delete from ChiTietPhieuNhap Where MaPN='" + MaPN + "'";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Loại sách này đã được xóa khỏi phiếu nhập " + MaPN);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Khi Xóa  Chi Tiết Phiếu Nhập Phiếu Nhập " + MaPN);

            }
        }

        public DataTable timPhieuNhap(string maPN)
        {
            String sql = "Select MaPN,NgayNhap,MaNXB from PhieuNhap Where  MaPN='" + maPN+ "'";
            DataTable dt = db.getTable(sql);
            if(dt.Rows.Count==1)
            {
                dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
                dt.Columns["NgayNhap"].ColumnName = "Ngày Nhập";
                dt.Columns["MaNXB"].ColumnName = "Mã Nhà Xuất Bản";
            } 
            else
            {
                MessageBox.Show("Không tìm thấy phiếu nhập","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            return dt;
        }
        public DataTable timCTPN(string MaPN)
        {
            String sql = "Select *,(SoLuongNhap * GiaNhap) as Tong from ChiTietPhieuNhap where MaPN = '" + MaPN + "'";
            DataTable dt = db.getTable(sql);
            if (dt.Rows.Count == 1)
            {
                dt.Columns["MaPN"].ColumnName = "Mã Phiếu Nhập";
                dt.Columns["MaSach"].ColumnName = "Mã Sách";
                dt.Columns["SoLuongNhap"].ColumnName = "Số Lượng Nhập";
                dt.Columns["GiaNhap"].ColumnName = "Giá Nhập";
                dt.Columns["Tong"].ColumnName = "Tổng Tiền ";
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết phiếu nhập", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

    }
}
