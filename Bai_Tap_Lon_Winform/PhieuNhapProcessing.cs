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
                string sql= "Select MaPN, NgayNhap,MaNXB  from PhieuNhap";
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
                string sql = "Insert into PhieuNhap Values('" + maPN + "','" + ngayNhap + "','" + maNXB + "')";
                db.getExecuteNonQuery(sql);
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
                string sql = "Insert Into ChiTietPhieuNhap(MaPN, MaSach,SoLuongNhap, GiaNhap)" +
                " values('" +maPN + "','" + maSach+ "'," + SLN + "," + giaNhap + ")";
                db.getExecuteNonQuery(sql);
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
                    
                    string sqlPN = "Update  PhieuNhap set NgayNhap='" + ngayNhap + "', MaNXB='" + maNXB+ "' where MaPN='" + maPN + "'";
                    db.getExecuteNonQuery(sqlPN);
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

                    string sqlCTPN = "Update  ChiTietPhieuNhap Set MaSach ='" + maSach + "', SoLuongNhap=" + slNhap + ",GiaNhap=" + giaNhap
                         + " Where MaPN='" + MaPN + "'";
                    db.getExecuteNonQuery(sqlCTPN);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi Khi Cập Nhật Chi Tiết Phiếu Nhập " + MaPN);
                }
            
        }
    
    }
}
