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

    class TheLoaiProcessing
    {
        DBConnection db = new DBConnection();

        public DataTable loadDL()
        {
            String sql = "Select *from TheLoai";
            DataTable dt = new DataTable();
            dt = db.getTable(sql);
            return dt;
        }
        public void addTheLoai(String maTL,String tenTL)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thêm thể loại "+tenTL, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    string sql = "Insert Into TheLoai Values('" + maTL + "',N'" + tenTL + "')";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Thể loại " + tenTL + " đã được thêm vào hệ thống");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void editTheLoai(String maTL,String tenTL)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn lưu những thay đổi", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    String sql = "Update  TheLoai Set TenTL=N'" + tenTL + "' where MaTL='" + maTL + "'";
                    db.getExecuteNonQuery(sql);
                   MessageBox.Show("Thông tin của thể loại "+maTL+" đã được cập nhật");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaTheLoai(String maTL)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn xóa thể loại "+maTL, "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    String sql = "Delete from TheLoai where MaTL='" + maTL + "'";
                    db.getExecuteNonQuery(sql);
                    MessageBox.Show("Thể loại "+maTL+" đã được xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public DataTable timTheLoai(String maTL)
        {
                String sql = "SELECT * FROM TheLoai WHERE MaTL = '" + maTL + "'";
                DataTable table = db.getTable(sql);
                if (table.Rows.Count > 0)
                {

                }
                else
                {
                    MessageBox.Show("Không tìm thấy thể loại này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return table;
           
        }
    }
}
