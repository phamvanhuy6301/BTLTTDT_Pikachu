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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDanhMuc frm2 = new fDanhMuc();
            frm2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDanhMuc frm2 = new fDanhMuc();
            frm2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHeThong f = new fHeThong();
            f.Show();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            this.Hide();
            fHeThong f = new fHeThong();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            fThongKe f = new fThongKe();
            f.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            fThongKe f = new fThongKe();
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap f = new fDangNhap();
            f.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Close();
            fPlay f = new fPlay();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            fPlay f = new fPlay();
            f.Show();
        }
    }
}
