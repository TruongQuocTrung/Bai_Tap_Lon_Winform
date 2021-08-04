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
        DataProcessing data = new DataProcessing();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("Username") || txtPassword.Text.Trim().Equals("Password")
                || txtUsername.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                data.getLogin(txtUsername.Text.ToString(), txtPassword.Text.ToString(),this);
            }
        }

      
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        
    }
}
