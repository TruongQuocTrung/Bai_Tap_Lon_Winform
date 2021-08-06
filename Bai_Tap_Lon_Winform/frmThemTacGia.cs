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
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            txtTim.ForeColor = Color.Black;
        }
        TacGiaProcessing tacGia = new TacGiaProcessing();
        private void frmThemTacGia_Load(object sender, EventArgs e)
        {
            GridViewTacGia.DataSource = tacGia.showTG();
        }

        private void GridViewTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = GridViewTacGia.SelectedCells[0].RowIndex;
            txtMaTG.Text = GridViewTacGia.Rows[index].Cells[0].Value.ToString();
            txtTenTG.Text = GridViewTacGia.Rows[index].Cells[1].Value.ToString();
            txtLienHe.Text = GridViewTacGia.Rows[index].Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text.Trim() == "" || txtTenTG.Text.Trim() == "" || txtLienHe.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy đủ Thông Tin !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                tacGia.addTacGia(txtMaTG.Text, txtTenTG.Text, txtLienHe.Text);
                frmThemTacGia_Load(sender, e);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtLienHe.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text.Trim() == "" || txtTenTG.Text.Trim() == "" || txtLienHe.Text.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy đủ Thông Tin !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                tacGia.editTacGia(txtMaTG.Text, txtTenTG.Text, txtLienHe.Text);
                frmThemTacGia_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            tacGia.xoaTacGia(txtMaTG.Text);
            frmThemTacGia_Load(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text.Trim().Length > 0)
            {
                GridViewTacGia.DataSource = tacGia.timTheLoai(txtTim.Text);
                GridViewTacGia.ClearSelection();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã tác giả", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
