using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai_Tap_Lon_Winform
{
    public partial class frmThemSach : Form
    {
        DAOSach dao = new DAOSach();
        public frmThemSach()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            
            dgvQLSach.DataSource = dao.getDGVQLSach();
            dgvQLSach.ClearSelection();
        }
        public void CBBTacGia()
        {
            cbbTacGia.DataSource = dao.getCBBTacGia();
            cbbTacGia.DisplayMember = "TenTG";
            cbbTacGia.ValueMember = "MaTG";
        }
        public void CBBTheLoai()
        {
            cbbTheLoai.DataSource = dao.getCBBTheLoai();
            cbbTheLoai.DisplayMember = "TenTL";
            cbbTheLoai.ValueMember = "MaTL";
        }
        public void CBBNXB()
        {
            cbbNhaXuatBan.DataSource = dao.getCBBNXB();
            cbbNhaXuatBan.DisplayMember = "TenNXB";
            cbbNhaXuatBan.ValueMember = "MaNXB";
        }
        public void ThemSach()
        {
            String MaSach = txtMaSach.Text;
            String TenSach = txtTenSach.Text;
            String MaTG = cbbTacGia.SelectedValue.ToString();
            String MaNXB = cbbNhaXuatBan.SelectedValue.ToString();
            String MaTL = cbbTheLoai.SelectedValue.ToString();
            try
            {
                int DonGia = int.Parse(txtDonGia.Text);
                int SoLuong = int.Parse(txtSoLuong.Text);
                if(MaSach.Trim().Length >0 && TenSach.Trim().Length > 0 && MaTG.Trim().Length > 0 && MaNXB.Trim().Length > 0 && MaTL.Trim().Length > 0)
                {
                    if(DonGia > 0 && SoLuong > 0)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn thêm sách " + TenSach + " vào hệ thống?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (dao.addSach(MaSach, TenSach, MaTG, MaNXB, MaTL, SoLuong, DonGia))
                            {
                                HienThi();
                                XoaTrang();
                                MessageBox.Show("Sách " + TenSach + " đã được thêm vào hệ thống", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi sảy ra", "Thao tác thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            XoaTrang();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng và đơn giá phải là số nguyên dương", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống các thông tin sách", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng và đơn giá phải là số nguyên!", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SuaSach()
        {
            int i = dgvQLSach.SelectedRows.Count;
            if (i==1)
            {
                int index = dgvQLSach.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvQLSach.Rows[index];
                String MaSach = row.Cells[0].Value.ToString();
                String TenSach = txtTenSach.Text;
                String MaTG = cbbTacGia.SelectedValue.ToString();
                String MaNXB = cbbNhaXuatBan.SelectedValue.ToString();
                String MaTL = cbbTheLoai.SelectedValue.ToString();
                try
                {
                    int DonGia = int.Parse(txtDonGia.Text);
                    int SoLuong = int.Parse(txtSoLuong.Text);
                    if (MaSach.Trim().Length > 0 && TenSach.Trim().Length > 0 && MaTG.Trim().Length > 0 && MaNXB.Trim().Length > 0 && MaTL.Trim().Length > 0)
                    {
                        if (DonGia > 0 && SoLuong > 0)
                        {
                            DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin sách có mã " + MaSach + " ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                dao.editSach(MaSach, TenSach, MaTG, MaNXB, MaTL, SoLuong, DonGia);
                                HienThi();
                                XoaTrang();
                                MessageBox.Show("Sách đã được sửa", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                XoaTrang();
                                dgvQLSach.ClearSelection();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số lượng và đơn giá phải là số nguyên dương", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống các thông tin sách", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Số lượng và đơn giá phải là số nguyên!", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa từ bảng bên dưới", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void XoaSach()
        {
            int i = dgvQLSach.SelectedRows.Count;
            if (i == 1)
            {
                int index = dgvQLSach.SelectedCells[0].RowIndex;
                DataGridViewRow row = dgvQLSach.Rows[index];
                String MaSach = row.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin sách " + row.Cells[1].Value.ToString() + " ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    dao.deleteSach(MaSach);
                    HienThi();
                    XoaTrang();
                    MessageBox.Show("Sách đã được xóa khỏi hệ thống", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XoaTrang();
                    dgvQLSach.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách muốn xóa từ bảng bên dưới", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            public void XoaTrang()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            cbbNhaXuatBan.Text = "";
            cbbTacGia.Text = "";
            cbbTheLoai.Text = "";
        }
        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            lblTitleThem.Visible = true;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            lblTitleThem.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSach();
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            lblTitleSave.Visible = true;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            lblTitleSave.Visible = false;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            lblTitleXoa.Visible = true;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            lblTitleXoa.Visible = false;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            lblTitleClear.Visible = true;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            lblTitleClear.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmThemSach_Load(object sender, EventArgs e)
        {
            
            HienThi();
            CBBNXB();
            CBBTacGia();
            CBBTheLoai();
        }

        private void frmThemSach_Shown(object sender, EventArgs e)
        {
            dgvQLSach.ClearSelection();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SuaSach();
        }

        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvQLSach.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvQLSach.Rows[index];
            txtMaSach.Text = row.Cells[0].Value.ToString();
            txtTenSach.Text = row.Cells[1].Value.ToString();
            cbbTacGia.SelectedValue = row.Cells[2].Value;
            cbbNhaXuatBan.SelectedValue = row.Cells[3].Value;
            cbbTheLoai.SelectedValue = row.Cells[4].Value;
            txtSoLuong.Text = row.Cells[5].Value.ToString();
            txtDonGia.Text = row.Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaSach();
        }
    }
}
