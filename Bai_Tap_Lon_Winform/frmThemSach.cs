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
    }
}
