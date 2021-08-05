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
    public partial class frmHoaDon : Form
    {
        HoaDonProcessing hoaDon = new HoaDonProcessing();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int check = 0;
        private void bthHuyHD_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Clear();
            dtpNgayBan.Value = DateTime.Now;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyCTHD_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtMaSach.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtKhachHang.Clear();
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {

        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            GridviewHD.DataSource = hoaDon.loadHD();
            GridviewHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            check = 0;
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            GridviewHD.DataSource = hoaDon.loadCTHD();
            GridviewHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            check = 1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void GridviewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
