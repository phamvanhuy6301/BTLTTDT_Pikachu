using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pikachu
{
    public partial class fDSNguoiChoi : Form
    {
        public fDSNguoiChoi()
        {
            InitializeComponent();
            LoadDSNguoiChoi();
        }
        void LoadDSNguoiChoi()
        {
            string query = "select * from TAIKHOAN";

            dtgrvDsNguoiChoi.DataSource = DAO.DataProvide.Instance.LayDuLieu(query);
        }

        private void dtgrvDsNguoiChoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
