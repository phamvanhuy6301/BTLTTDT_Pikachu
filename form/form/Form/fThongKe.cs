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
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void btnThanhTichCaNhan_Click(object sender, EventArgs e)
        {
            this.pnlDisplayThongKe.Controls.Clear();
            fThanhTichCaNhan f = new fThanhTichCaNhan();
            f.TopLevel = false;
            this.pnlDisplayThongKe.Controls.Add(f);
            f.Show();
        }
    }
}
