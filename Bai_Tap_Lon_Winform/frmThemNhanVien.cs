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
    public partial class frmThemNhanVien : Form
    {
        DAONhanVien dao = new DAONhanVien();
        public frmThemNhanVien()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            dgvNhanVien.DataSource = dao.getDataDGVNhanVien();
            dgvNhanVien.ClearSelection();
        }
        public void XoaTrang()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cbbChucVu.Text = "";
            radNu.Checked = false;
            radNu.Checked = false;
            radKhac.Checked = false;
        }
        public void ThemNV()
        {
            String MaNV = txtMaNV.Text;
            String HoTen = txtHoTen.Text;
            DateTime NgaySinh = dtpNgaySinh.Value;
            String GioiTinh;
            if (radNam.Checked)
            {
                 GioiTinh = "M";
            }
            else
            {
                if (radNu.Checked)
                {
                     GioiTinh = "F";
                }
                else
                {
                     GioiTinh = "K";
                }
            }
            String ChucVu = cbbChucVu.Text;
            String DiaChi = txtDiaChi.Text;
            if (MaNV.Trim().Length >0 && HoTen.Trim().Length >0 && DiaChi.Trim().Length >0 && ChucVu.Trim().Length >0)
            {
                if(dao.addNhanVien(MaNV, HoTen, NgaySinh, GioiTinh, DiaChi, ChucVu))
                {
                    HienThi();
                    DialogResult result = MessageBox.Show("Thêm nhân viên thành công, Bạn có muốn tạo tài khoản đăng nhập cho nhân viên "+MaNV, "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    
                    if (result == DialogResult.Yes)
                    {
                        grbTaoTaiKhoan.Visible = true;
                        txtMaNV.Enabled = false;
                        btnXoaTatCa.Enabled = false;
                    }
                    else
                    {
                        HuyTaoTK();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu đầu vào", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemTK()
        {
            String MaNV = txtMaNV.Text;
            String TenDN = txtUsename.Text;
            String MatKhau = txtPass.Text;
            if (MaNV.Trim().Length >0 && TenDN.Trim().Length >0 && MatKhau.Trim().Length >= 3)
            {
                if (dao.addTaiKhoanThuNgan(MaNV, TenDN, MatKhau))
                {
                    MessageBox.Show("Nhân viên có mã: "+MaNV +" đã có thể đăng nhập vào hệ thống!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grbTaoTaiKhoan.Visible = false;
                    txtMaNV.Enabled = true;
                    btnXoaTatCa.Enabled = true;
                    XoaTrang();
                }
            }
            else
            {
                MessageBox.Show("Không được để trống dữ liệu đầu vào, hoặc mật khẩu phải lớn hơn 3 kí tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void HuyTaoTK()
        {
            DialogResult result = MessageBox.Show("Nhân viên sẽ không thể đăng nhập hệ thống! bạn có chắc muốn hủy thảo tác","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                grbTaoTaiKhoan.Visible = false;
                txtMaNV.Enabled = true;
                btnXoaTatCa.Enabled = true;
                XoaTrang();
            }
            else
            {
                grbTaoTaiKhoan.Visible = true;
                txtMaNV.Enabled = false;
                btnXoaTatCa.Enabled = false;
            }
        }
        public void TimKiem()
        {
            String MaNV = txtTimKiem.Text;
            if (MaNV.Trim().Length >0)
            {
                dgvNhanVien.DataSource = dao.findNhanVien(MaNV);
                dgvNhanVien.ClearSelection();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã nhân viên!", "Lỗi dữ liệu đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            grbTaoTaiKhoan.Visible = false;
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemNV();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThemTK();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            HuyTaoTK();
        }

        private void frmThemNhanVien_Shown(object sender, EventArgs e)
        {
            dgvNhanVien.ClearSelection();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
