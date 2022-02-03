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
    public partial class fHeThong : Form
    {
        public fHeThong()
        {
            InitializeComponent();
        }

        private void btnHeThong_DoiMk_Click(object sender, EventArgs e)
        {
            this.pnlDisplayHeThong.Controls.Clear();
            fDoiMK f = new fDoiMK();
            f.TopLevel = false;
            this.pnlDisplayHeThong.Controls.Add(f);
            f.Show();
        }

        private void btnHeThong_CapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnHeThong_CaiDat_Click(object sender, EventArgs e)
        {
            this.pnlDisplayHeThong.Controls.Clear();
            fCaiDat f = new fCaiDat();
            f.TopLevel = false;
            this.pnlDisplayHeThong.Controls.Add(f);
            f.Show();
        }
    }
}
