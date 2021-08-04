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
    public partial class frmLogin : Form
    {
        DAOLogin dao = new DAOLogin();
        public static int dem =0;
        public frmLogin()
        {
            InitializeComponent();
        }
        public void DangNhap()
        {
            String TenDN = txtTenDN.Text;
            String MatKhau = txtMatKhau.Text;
            if(TenDN.Trim().Length >0 && MatKhau.Trim().Length > 0)
            {
                String MaNV = dao.getLogin(TenDN,MatKhau);
                if(MaNV != null)
                {
                    this.Hide();
                    new Form1(TenDN,MatKhau,MaNV).Visible = true;
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại tên đăng nhập hoặc mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại tên đăng nhập hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtTenDN.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
        }

        
    }
}
