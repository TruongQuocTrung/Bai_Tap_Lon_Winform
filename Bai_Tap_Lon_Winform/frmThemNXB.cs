using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_Lon_Winform
{
    public partial class frmThemNXB : Form
    {
        DAONXB dao = new DAONXB();
        public frmThemNXB()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            dgvNXB.DataSource = dao.getDGVNXB();
            dgvNXB.ClearSelection();
        }
        public void XoaTrang()
        {
            txtTenNXB.Clear();
            txtMaNXB.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTimKiem.Clear();
            dgvNXB.ClearSelection();
        }
        public void ThemNXB()
        {
            String MaNXB = txtMaNXB.Text;
            String TenNXB = txtTenNXB.Text;
            String DiaChiNXB = txtDiaChi.Text;
            String DienThoai = txtSDT.Text;
            if (MaNXB.Trim().Length > 0 && TenNXB.Trim().Length > 0 && DiaChiNXB.Trim().Length > 0 && DienThoai.Trim().Length > 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm nhà xuất bản có mã: " + MaNXB, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    if (dao.addNXB(MaNXB, TenNXB, DiaChiNXB, DienThoai))
                    {
                        HienThi();
                        XoaTrang();
                        MessageBox.Show("Thông tin nhà xuất bản đã được thêm thành công!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XoaTrang();
                }
            }
            else
            {
                MessageBox.Show("Không được để trống các thông tin nhà xuất bản!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Sua()
        {
            int i = dgvNXB.SelectedRows.Count;
            if (i >0)
            {
                int index = dgvNXB.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvNXB.Rows[index];
                String MaNXB = row.Cells[0].Value.ToString();
                String TenNXB = txtTenNXB.Text;
                String DiaChiNXB = txtDiaChi.Text;
                String DienThoai = txtSDT.Text;
                if (TenNXB.Trim().Length > 0 && DiaChiNXB.Trim().Length > 0 && DienThoai.Trim().Length > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn muốn cập nhật thông tin nhà xuất bản có mã: " + MaNXB, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dao.editNXB(MaNXB, TenNXB, DiaChiNXB, DienThoai);
                        HienThi();
                        XoaTrang();
                        MessageBox.Show("Thông tin nhà xuất bản đã được cập nhật vào hệ thống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XoaTrang();
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống các thông tin nhà xuất bản!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn NXB cần sửa thông tin", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Xoa()
        {
            int i = dgvNXB.SelectedRows.Count;
            if (i > 0)
            {
                int index = dgvNXB.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvNXB.Rows[index];
                String MaNXB = row.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn muốn xóa thông tin nhà xuất bản có mã: " + MaNXB, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    dao.deleteNXB(MaNXB);
                    HienThi();
                    XoaTrang();
                    MessageBox.Show("Thông tin nhà xuất bản đã được xóa khỏi hệ thống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XoaTrang();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn NXB cần xóa khỏi hệ thống", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void TimKiem()
        {
            if(txtTimKiem.Text.Trim().Length > 0)
            {
                String MaNXB = txtTimKiem.Text;
                dgvNXB.DataSource = dao.findNXB(MaNXB);
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mã nhà xuất bản!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNXB_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void frmThemNXB_Shown(object sender, EventArgs e)
        {
            dgvNXB.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNXB();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTrang();
            HienThi();
        }

        private void dgvNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNXB.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvNXB.Rows[index];
            txtMaNXB.Text = row.Cells[0].Value.ToString();
            txtTenNXB.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtSDT.Text = row.Cells[3].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Sua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
