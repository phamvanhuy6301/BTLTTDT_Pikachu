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

        private void DsPhienChoi_Click(object sender, EventArgs e)
        {
            this.pnlDisplayDanhMuc.Controls.Clear();
            fDSPhienChoi f = new fDSPhienChoi();
            f.TopLevel = false;
            this.pnlDisplayDanhMuc.Controls.Add(f);
            f.Show();
        }

        private void btnDsPokemon_Click(object sender, EventArgs e)
        {
            this.pnlDisplayDanhMuc.Controls.Clear();
            fDSPokemon f = new fDSPokemon();
            f.TopLevel = false;
            this.pnlDisplayDanhMuc.Controls.Add(f);
            f.Show();
        }

        private void btnDsNguoiChoi_Click(object sender, EventArgs e)
        {
            this.pnlDisplayDanhMuc.Controls.Clear();
            fDSNguoiChoi f = new fDSNguoiChoi();
            f.TopLevel = false;
            this.pnlDisplayDanhMuc.Controls.Add(f);
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain f = new fMain();
            f.Show();
        }
    }
}
