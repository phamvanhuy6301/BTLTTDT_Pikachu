using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
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
    }
}
