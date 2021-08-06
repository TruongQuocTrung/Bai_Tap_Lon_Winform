using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bai_Tap_Lon_Winform
{
    public partial class Form1 : Form
    {
        DAOLogin daolg = new DAOLogin();
        DAOBanSach dao = new DAOBanSach();
        public Form1()
        {
            InitializeComponent();
            CusDesign();
            timer1.Start();
        }
        public Form1(String TenDN, String MatKhau,String MaNV):this()
        {
           
            if (daolg.getQuyenDN(TenDN,MatKhau).Equals("Quản Lý"))
            {
            }
            else
            {
                btnQuanLy.Hide();
                btnThemNhanVien.Hide();
            }
            lblTenThuNgan.Text = daolg.getTenNV(MaNV);
            lblMaNV.Text = MaNV;
        }
        static int i = 0;
        static int SL = 0;
        static int TT = 0;
        static String LoaiKH = null;
        public void addItemCBBTenSach()
        {
            cbbTenSach.DataSource = dao.getItemCBBTenSach();
            cbbTenSach.DisplayMember = "TenSach";
            cbbTenSach.ValueMember = "MaSach";
        }
        public void getTenKH()
        {
            if (txtSoHD.Text.Trim().Length >0)
            {
                String MaKH = txtMaKhachHang.Text;
                if (MaKH.Trim().Length > 0)
                {
                    String TenNV = dao.getTenKHbyMaKH(MaKH);
                    if (TenNV != null)
                    {
                        txtTenKH.Text = TenNV;
                        LoaiKH = dao.getLoaiKHbyMaKH(MaKH);
                        if (LoaiKH.Equals("Hội Viên"))
                        {
                            lblGiamGia.Text = "10";
                        }
                        else
                        {
                            lblGiamGia.Text = "0";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống mã khách hàng", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đơn hàng chưa được tạo, cần tạo đơn hàng mới", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addSachBan()
        {
            DataTable table = dao.getTTSachBan(cbbTenSach.SelectedValue.ToString());
            int dongia = int.Parse(table.Rows[0]["DonGia"].ToString());
            int soluong = int.Parse(numerSoLuong.Value.ToString());
            float giamgia;
            if(LoaiKH == null)
            {
                MessageBox.Show("Vui lòng nhập mã khách mua hàng trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (LoaiKH.Equals("Hội Viên"))
                {
                    giamgia = (float)10 / 100;
                }
                else
                {
                    giamgia = 0;
                }
                int thanhtien = (soluong * dongia);
                if (numerSoLuong.Value >0)
                {
                    dgvDonHang.Rows.Add();
                    dgvDonHang.Rows[i].Cells[0].Value = cbbTenSach.SelectedValue.ToString();
                    dgvDonHang.Rows[i].Cells[1].Value = table.Rows[0]["TenSach"].ToString();
                    dgvDonHang.Rows[i].Cells[2].Value = table.Rows[0]["SoLuong"].ToString();
                    dgvDonHang.Rows[i].Cells[3].Value = numerSoLuong.Value.ToString();
                    dgvDonHang.Rows[i].Cells[4].Value = table.Rows[0]["DonGia"].ToString();
                    dgvDonHang.Rows[i].Cells[5].Value = thanhtien;
                    SL = SL + soluong;
                    TT = TT + thanhtien;
                    txtSLHang.Text = SL.ToString();
                   
                    txtTongTien.Text = (TT - TT * giamgia).ToString();
                    i++;
                }
                else
                {
                    MessageBox.Show("Chọn số lượng sản phẩm trước khi thêm", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CusDesign()
        {
            panelTuyChonSubMenu.Visible = false;
            panelChungTuSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelTuyChonSubMenu.Visible == true)
                panelTuyChonSubMenu.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

       
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
               activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTuyChonSubMenu);
        }

        private void ClosePicture_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChungTu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChungTuSubMenu);
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThemNhanVien());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThemSach());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin flg = new frmLogin();
            flg.Show();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGioiThieu());
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThemNXB());
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThemKhachHang());
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThemTheLoai());
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThemTacGia());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuNhap());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon());
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLy());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTraLai.Text.Trim().Length >0)
            {
                String SoHD = txtSoHD.Text.Trim();
                DateTime NgayBan = DateTime.Parse(DateTime.Now.ToShortDateString());
                String ThuNgan = lblTenThuNgan.Text;
                String GioBan = DateTime.Now.ToShortTimeString();
                int TongTien = int.Parse(txtTongTien.Text);
                int KhachDua = int.Parse(txtKhachDua.Text);
                int SoLuongHang = int.Parse(txtSLHang.Text);
                String MaNV = lblMaNV.Text;
                String MaKH = txtMaKhachHang.Text;
                int GiamGia = int.Parse(lblGiamGia.Text);
                try
                {
                    dao.addHoaDon(SoHD, NgayBan, ThuNgan, GioBan, TongTien, KhachDua, SoLuongHang, GiamGia);
                    for (int i = 0; i < dgvDonHang.Rows.Count - 1; i++)
                    {
                        String MaSach = dgvDonHang.Rows[i].Cells[0].Value.ToString();
                        // số lượng sách bán.
                        int SoLuongBan = int.Parse(dgvDonHang.Rows[i].Cells[3].Value.ToString());
                        int GiaBan = int.Parse(dgvDonHang.Rows[i].Cells[4].Value.ToString());
                        try
                        {
                            dao.addChiTietHoaDon(SoHD, MaSach, SoLuongBan, GiaBan, MaKH);
                            int SoLuongTonKho = int.Parse(dgvDonHang.Rows[i].Cells[2].Value.ToString());
                            int TTBanSach = int.Parse(dgvDonHang.Rows[i].Cells[5].Value.ToString());
                            try
                            {
                                dao.addSachBan(MaSach, MaNV, MaKH, SoHD, SoLuongTonKho, SoLuongBan, GiaBan, TTBanSach);
                                dao.updateSlTonSach(SoLuongTonKho - SoLuongBan, MaSach);
                            }
                            catch (Exception ex3)
                            {
                                MessageBox.Show(ex3.Message);
                            }
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(ex2.Message);
                        }
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
            }
            else
            {
                MessageBox.Show("Cần hoàn thiện thông tin hóa đơn trước khi thanh toán", "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //frmBienLai bl = new frmBienLai();
            //bl.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Clear();
            txtMaKhachHang.ForeColor = Color.Black;
        }
        DataTable TableDonHang = new DataTable();

        private void btnDonHangMoi_Click(object sender, EventArgs e)
        {
            numerSoLuong.Text = "0";
            txtMaKhachHang.Clear();
            txtKhachDua.Clear();
            txtTenKH.Clear();
            txtTongTien.Clear();
            txtTraLai.Clear();
            txtSLHang.Clear();
            TableDonHang.Clear();
            dgvDonHang.Rows.Clear();
            txtSoHD.Text = DateTime.Now.ToString("ssmmHHddMMyyyy");
        }
        DBConnection db = new DBConnection();
        private void btnAddSach_Click(object sender, EventArgs e)
        {
           addSachBan();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addItemCBBTenSach();
        }

        private void btnMaKH_Click(object sender, EventArgs e)
        {
            getTenKH();
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
                try
                {
                int tienKD = int.Parse(txtKhachDua.Text);
                int tongTien = int.Parse(txtTongTien.Text);
                    if (tienKD >= tongTien)
                    {
                        int tienThua = tienKD - tongTien;
                        txtTraLai.Text = tienThua.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số tiền khách đưa phải lớn hơn tổng tiền hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Số tiền khách đưa phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        public void GETMONEY(string values)
        {
            txtKhachDua.Text = values;
        }
        private void btnTienMat_Click(object sender, EventArgs e)
        {
            if (txtTongTien.Text.Length >0)
            {
                frmTienMat tt = new frmTienMat();
                tt.tinhtien = new frmTienMat.GETDATATINHTIEN(GETMONEY);
                tt.Show();
            }
            else
            {
                MessageBox.Show("Phải hoàn thiện thông tin đơn hàng trước", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
