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
    class TacGiaProcessing
    {
        DBConnection db = new DBConnection();
        public DataTable showTG()
        {
            String sql = "Select *from TacGia";
            DataTable dt = db.getTable(sql);
            return dt;
        }

        public void addTacGia(String maTG, String tenTG,String lienHe)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm tác giả "+tenTG, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sql = "Insert Into TacGia Values('" + maTG + "',N'" + tenTG + "','" + lienHe + "')";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Tác giả " + tenTG + " đã được thêm vào hệ thống");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void editTacGia(String maTG, String tenTG,String lienHe)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn lưu những thay đổi ", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {

                    String sql = "Update  TacGia Set TenTG=N'" + tenTG + "',LienHe='" + lienHe + "' where MaTG='" + maTG + "'";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Thông tin của tác giả "+maTG+" đã được cập nhật");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaTacGia(String maTG)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xóa tác giả " + maTG, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    String sql = "Delete from TacGia where MaTG='" + maTG + "'";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Tác giả "+maTG+" đã bị xóa");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Khi Xóa Thể Loại" + maTG);

            }
        }
        public DataTable timTheLoai(String maTL)
        {

            String sql = "SELECT * FROM TheLoai WHERE MaTL = '" + maTL + "'";
            DataTable table = db.getTable(sql);
            return table;

        }
    }
}
