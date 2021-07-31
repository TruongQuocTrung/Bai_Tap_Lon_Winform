using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai_Tap_Lon_Winform
{
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            lblTitleThem.Visible = true;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            lblTitleThem.Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông báo", "Bạn chắc chắn muốn thêm", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            lblTitleSave.Visible = true;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            lblTitleSave.Visible = false;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            lblTitleXoa.Visible = true;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            lblTitleXoa.Visible = false;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            lblTitleClear.Visible = true;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            lblTitleClear.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TestConnect t = new TestConnect();
        private void frmThemSach_Load(object sender, EventArgs e)
        {
            SqlConnection connection=  t.getConnect();
            string sql = "SELECT * FROM Sach";
            connection.Open();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);
            adapter.Fill(table);
            dgvQLSach.DataSource = table;
        }
    }
}
