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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CusDesign();
            timer1.Enabled = true;
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongTimeString();
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
            frmBienLai bl = new frmBienLai();
            bl.Show();
        }
    }
}
