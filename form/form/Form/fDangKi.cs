﻿using System;
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
    public partial class fDangKi : Form
    {
        public fDangKi()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDangKi_GioiTinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDangKi_MK2_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDangNhap f = new fDangNhap();
            f.Show();
            MessageBox.Show("Đăng ký tài khoản thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap f = new fDangNhap();
            f.Show();
        }
    }
}
