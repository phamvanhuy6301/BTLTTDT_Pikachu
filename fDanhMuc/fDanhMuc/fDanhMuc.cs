using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fDanhMuc
{
    public partial class fDanhMuc : Form
    {
        public fDanhMuc()
        {
            InitializeComponent();
        }

        private void btnDsLevel_Click(object sender, EventArgs e)
        {
            this.pnlDisplayDsLevel.Controls.Clear();
            fDsLevel dslv = new fDsLevel();
            dslv.TopLevel = false;
            this.pnlDisplayDsLevel.Controls.Add(dslv);
            dslv.Show();
        }
    }
}
