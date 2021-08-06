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
