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
              || txtDiaChi.Text.Trim() == "" || txtSDT.Text.Trim() == ""||cbbLoaiKH.Text.Trim()=="")
            {
                MessageBox.Show("Vui Lòng Điền Đầy đủ Thông Tin !","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "" || txtHoTen.Text.Trim() == ""
              || (rdbNam.Checked == false && rdbNu.Checked == false && rdbKhac.Checked == false)
              || txtDiaChi.Text.Trim() == "" || txtSDT.Text.Trim() == "" || cbbLoaiKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy đủ Thông Tin !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string gt = "";

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
                khachHang.editKH(txtMaKH.Text, txtHoTen.Text, gt, txtMaSoThue.Text, txtDiaChi.Text, txtSDT.Text, cbbLoaiKH.Text);
                frmThemKhachHang_Load(sender, e);
            }
        }

        private void GridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = GridViewKH.SelectedCells[0].RowIndex;
            txtMaKH.Text = GridViewKH.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = GridViewKH.Rows[index].Cells[1].Value.ToString();
            string gt= GridViewKH.Rows[index].Cells[2].Value.ToString();
            if (gt == "M")
                rdbNam.Checked = true;
            else if (gt == "F")
                rdbNu.Checked = true;
            else rdbKhac.Checked = true;
            txtMaSoThue.Text = GridViewKH.Rows[index].Cells[3].Value.ToString();
            txtDiaChi.Text = GridViewKH.Rows[index].Cells[4].Value.ToString();
            txtSDT.Text = GridViewKH.Rows[index].Cells[5].Value.ToString();
            cbbLoaiKH.Text = GridViewKH.Rows[index].Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            khachHang.xoaKH(txtMaKH.Text);
            frmThemKhachHang_Load(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            GridViewKH.DataSource= khachHang.timKH(txtTim.Text);
            GridViewKH.ClearSelection();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            txtTim.ForeColor = Color.Black;
        }
    }
}
