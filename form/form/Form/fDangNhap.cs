using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f = new fMain();
            f.Show();
        }
    }
}
