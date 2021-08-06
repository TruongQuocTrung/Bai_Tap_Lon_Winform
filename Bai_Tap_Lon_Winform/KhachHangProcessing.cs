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
    class KhachHangProcessing
    {
        DBConnection db = new DBConnection();
        public DataTable showKH()
        {
            string sql = "Select * from KhachHang";
            DataTable dt= db.getTable(sql);
            return dt;
        }
        public void addKH(string maKH,string hoTen,string gt,string maSoThue,string diaChi,string SDT,string loaiKH)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm khách hàng  " + hoTen + "", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sql = "Insert Into KhachHang Values('" + maKH + "',N'" + hoTen + "','" + gt + "','" + maSoThue + "',N'" + diaChi + "',N'" + SDT + "','" + loaiKH + "')";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Khách hàng" + hoTen + "đã được thêm vào hệ thống");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void editKH(string maKH, string hoTen, string gt, string maSoThue, string diaChi, string SDT, string loaiKH)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn lưu những thay đổi ", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sql = "Update KhachHang Set TenKH=N'"+hoTen+"',GioiTinh='"+gt+"',MaSoThue='"+maSoThue+"',DiaChi=N'"+diaChi+"',DienThoai='"+SDT+"',LoaiKH=N'"+loaiKH+"' Where MaKH='"+maKH+"'";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Thông thách hàng đã được cập nhật");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaKH(string maKH)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng " + maKH, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    String sql = "Delete from KhachHang Where MaKH='" + maKH + "'";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Khách hàng " + maKH + " đã được xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable timKH(String maKH)
        {
            String sql = "SELECT * FROM KhachHang WHERE MaKH = '" + maKH + "'";
            DataTable table = db.getTable(sql);
            if (table.Rows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;

        }
    }
}
