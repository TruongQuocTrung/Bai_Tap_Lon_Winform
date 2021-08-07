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
<<<<<<< HEAD
        static int check = 0;
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

=======
        int check = 0;       
>>>>>>> 8f56ede29293a3caf600d5820b8550d234684e05
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
        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(check==0)
            {
                GridviewHD.DataSource= hoaDon.timHD(txtTim.Text);
                GridviewHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GridviewHD.ClearSelection();
            }
            else
            {
                GridviewHD.DataSource = hoaDon.timCTHD(txtTim.Text);
                GridviewHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GridviewHD.ClearSelection();
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            GridviewHD.ClearSelection();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.ForeColor = Color.Black;
            txtTim.Clear();
        }
    }
}
