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
    public partial class fDanhMuc : Form
    {
        public fDanhMuc()
        {
            InitializeComponent();
        }

        private void btnDsLevel_Click(object sender, EventArgs e)
        {
            this.pnlDisplayDanhMuc.Controls.Clear();
            fDsLevel f = new fDsLevel();
            f.TopLevel = false;
            this.pnlDisplayDanhMuc.Controls.Add(f);
            f.Show();
        }
    }
}
