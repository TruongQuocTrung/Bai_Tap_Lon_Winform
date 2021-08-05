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
    public partial class frmThemTheLoai : Form
    {
        public frmThemTheLoai()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Clear();
            txtTenTheLoai.Clear();
        }
        TheLoaiProcessing theLoai = new TheLoaiProcessing();
        private void btnThem_Click(object sender, EventArgs e)
        {
            theLoai.addTheLoai(txtMaTheLoai.Text, txtTenTheLoai.Text);
            frmThemTheLoai_Load(sender, e);
        }

        private void frmThemTheLoai_Load(object sender, EventArgs e)
        {
            GridViewTheLoai.DataSource = theLoai.loadDL();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            theLoai.editTheLoai( txtMaTheLoai.Text, txtTenTheLoai.Text);
            frmThemTheLoai_Load(sender, e);
        }

        private void GridViewTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = GridViewTheLoai.SelectedCells[0].RowIndex;
            txtMaTheLoai.Text = GridViewTheLoai.Rows[index].Cells[0].Value.ToString();
            txtTenTheLoai.Text = GridViewTheLoai.Rows[index].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            theLoai.xoaTheLoai(txtMaTheLoai.Text);
            frmThemTheLoai_Load(sender, e);
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            txtTim.ForeColor = Color.Black;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                GridViewTheLoai.DataSource = theLoai.timTheLoai(txtTim.Text);
                GridViewTheLoai.ClearSelection();
        }
    }
}
