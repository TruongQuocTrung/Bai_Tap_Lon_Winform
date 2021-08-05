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
    public partial class frmThemKhachHang : Form
    {
        KhachHangProcessing khachHang = new KhachHangProcessing();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            if (txtMaKH.Text.Trim() == "" || txtHoTen.Text.Trim() == ""
              || (rdbNam.Checked == false && rdbNu.Checked == false && rdbKhac.Checked == false)
              || txtDiaChi.Text.Trim() == "" || txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy đủ Thông Tin !");

            }
            else
            {
              string gt="";

                if (rdbNam.Checked == true)
                {
                    gt = "M";
                }
                else if (rdbNu.Checked == true)
                {
                    gt = "F";
                }
                else if (rdbKhac.Checked == true)
                {

                    gt = "K";
                }
                khachHang.addKH(txtMaKH.Text, txtHoTen.Text, gt, txtMaSoThue.Text, txtDiaChi.Text,txtSDT.Text, cbbLoaiKH.Text);
                frmThemKhachHang_Load(sender, e);
            }
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            
            GridViewKH.DataSource = khachHang.showKH();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtMaSoThue.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbKhac.Checked = false;
            cbbLoaiKH.Text = "";
        }
    }
}
