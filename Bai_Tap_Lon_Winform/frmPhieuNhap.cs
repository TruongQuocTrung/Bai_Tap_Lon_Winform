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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyPhieuNhap_Click(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Clear();
            txtMaNXB.Clear();
        }
        int check = 0;
        private void btnHuyCTPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Clear();
            txtMaSach.Clear();
            txtSoLuongNhap.Clear();
            txtGiaNhap.Clear();
        }
        PhieuNhapProcessing pn = new PhieuNhapProcessing();
        private void btnXemDSPN_Click(object sender, EventArgs e)
        {
            GridViewPhieuNhap.DataSource = pn.showPhieuNhap();
            GridViewPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            check = 0;
        }

        private void btnXemDSCTPN_Click(object sender, EventArgs e)
        {
            GridViewPhieuNhap.DataSource = pn.showCTPhieuNhap();
            GridViewPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            check = 1;
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            pn.addPhieuNhap(txtMaPhieuNhap.Text, dtpNgayNhap.Text, txtMaNXB.Text);
            btnXemDSPN_Click(sender, e);
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            pn.addCTPhieuNhap(txtMaPN.Text, txtMaSach.Text,double.Parse( txtSoLuongNhap.Text),double.Parse(txtGiaNhap.Text));
            btnXemDSCTPN_Click(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                pn.capNhatPN(dtpNgayNhap.Text, txtMaNXB.Text, txtMaPhieuNhap.Text);
                btnXemDSPN_Click(sender, e);
            }
            else
            {
                pn.capNhatCTPN(txtMaSach.Text, double.Parse(txtSoLuongNhap.Text), double.Parse(txtGiaNhap.Text), txtMaPN.Text);
                btnXemDSCTPN_Click(sender, e);
            }
            }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(check==0)
            {
                pn.xoaPhieuNhap(txtMaPhieuNhap.Text);
                txtMaNXB.Clear();
                txtMaPhieuNhap.Clear();
                btnXemDSPN_Click(sender, e);
            }
            else
            {
                pn.xoaCTPN(txtMaPN.Text);
                txtMaPN.Clear();
                txtMaSach.Clear();
                txtSoLuongNhap.Clear();
                txtGiaNhap.Clear();
                btnXemDSCTPN_Click(sender, e);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(check==0)
            {
               
                GridViewPhieuNhap.DataSource = pn.timPhieuNhap(txtTim.Text);
                GridViewPhieuNhap.ClearSelection();
                GridViewPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            }
            else
            {
                GridViewPhieuNhap.DataSource = pn.timCTPN(txtTim.Text);
                GridViewPhieuNhap.ClearSelection();
                GridViewPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void GridViewPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (check == 0)
            {
               
                txtMaPhieuNhap.Text = GridViewPhieuNhap.Rows[index].Cells[0].Value.ToString();
                dtpNgayNhap.Text= GridViewPhieuNhap.Rows[index].Cells[1].Value.ToString();
                txtMaNXB.Text = GridViewPhieuNhap.Rows[index].Cells[2].Value.ToString();

            }
            else if (check == 1)
            {
               
                txtMaPN.Text = GridViewPhieuNhap.Rows[index].Cells[0].Value.ToString();
                txtMaSach.Text = GridViewPhieuNhap.Rows[index].Cells[1].Value.ToString();
                txtSoLuongNhap.Text = GridViewPhieuNhap.Rows[index].Cells[2].Value.ToString();
                txtGiaNhap.Text = GridViewPhieuNhap.Rows[index].Cells[3].Value.ToString();

            }
        }

        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            txtMaPN.Text = txtMaPhieuNhap.Text;
        }
    }
}
