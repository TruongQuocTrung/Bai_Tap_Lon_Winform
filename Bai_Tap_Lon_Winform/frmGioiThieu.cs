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
    public partial class frmGioiThieu : Form
    {
        public frmGioiThieu()
        {
            InitializeComponent();
        }

       
       
        private void frmGioiThieu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            TitleTransition.ShowSync(lblTitle);
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NameTransition.ShowSync(lblName);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SloganTransition.ShowSync(lblSlogan);
            SloganTransition.ShowSync(lblWeb);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            DiaChiTransition.ShowSync(panelDiaChi);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            LienHeTransition.ShowSync(panelLienHe);
        }
    }

       
    
}
