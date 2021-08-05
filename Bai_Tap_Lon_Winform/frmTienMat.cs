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
    public partial class frmTienMat : Form
    {
        public frmTienMat()
        {
            InitializeComponent();
        }
        static float tongTien =0;
        public delegate void GETDATATINHTIEN(string data);
        public GETDATATINHTIEN tinhtien;
        private void frmTienMat_Load(object sender, EventArgs e)
        {

        }

        private void btn500k_Click(object sender, EventArgs e)
        {
            tongTien += 500000;
            txtTienMat.Text = tongTien.ToString();
        }

        private void btn200k_Click(object sender, EventArgs e)
        {
            tongTien += 200000;
            txtTienMat.Text = tongTien.ToString();
        }

        private void btn100k_Click(object sender, EventArgs e)
        {
            tongTien += 100000;
            txtTienMat.Text = tongTien.ToString();
        }

        private void btn50k_Click(object sender, EventArgs e)
        {
            tongTien += 50000;
            txtTienMat.Text = tongTien.ToString();
        }

        private void btn20k_Click(object sender, EventArgs e)
        {
            tongTien += 20000;
            txtTienMat.Text = tongTien.ToString();
        }

        private void btn10k_Click(object sender, EventArgs e)
        {
            tongTien += 10000;
            txtTienMat.Text = tongTien.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tongTien = 0;
            txtTienMat.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtTienMat.Text.Trim().Length > 0)
            {
                tinhtien(txtTienMat.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chưa nhập số tiền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ phương thức thanh toán bằng tiền mặt?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                try
                {
                    txtTienMat.Text = "";
                    tinhtien(txtTienMat.Text);
                    tongTien = 0;
                    this.Hide();
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
        }
    }
}
