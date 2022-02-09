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
        }


        ModifyTaiKhoan modifyTK;
        ModifyNguoiChoi modify;
        TaiKhoan taiKhoan;
        NguoiChoi nguoiChoi;


        private void fDSNguoiChoi_Load(object sender, EventArgs e)
        {
            modify = new ModifyNguoiChoi();
            try
            {
                dgvDSNguoiChoi.DataSource = modify.getAllNguoiChoi();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Hệ thống gặp sự cố", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void btnThem_Click(object sender, EventArgs e)
        {
            string User = this.txtUser.Text;
            string Sex = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            int Age = Convert.ToInt32(System.Math.Truncate(this.numericUpDown1.Value));

            string Name = this.txtName.Text;
            string Email = this.txtEmail.Text;
            int Record = int.Parse(this.txtRecord.Text);
            nguoiChoi = new NguoiChoi(User, Sex, Age, Name, Email, Record);

            //string User = this.txtUser.Text;
            string Password = this.txtPassword.Text;
            //string Name = this.txtName.Text;
            taiKhoan = new TaiKhoan(User, Password, Name);

            modifyTK = new ModifyTaiKhoan();
            modify = new ModifyNguoiChoi();

            if (modifyTK.insert(taiKhoan) && modify.insert(nguoiChoi))
            {
                dgvDSNguoiChoi.DataSource = modify.getAllNguoiChoi();
                MessageBox.Show("Thêm người chơi thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không thêm vào được, tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //string User = this.txtUser.Text;
            string Sex = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            int Age = Convert.ToInt32(System.Math.Truncate(this.numericUpDown1.Value));

            string Name = this.txtName.Text;
            string Email = this.txtEmail.Text;
            //int Record = int.Parse(this.txtRecord.Text);
            nguoiChoi = new NguoiChoi(Sex, Age, Name, Email);

            //string User = this.txtUser.Text;
            //string Password = this.txtPassword.Text;
            //string Name = this.txtName.Text;
            taiKhoan = new TaiKhoan(Name);

            modifyTK = new ModifyTaiKhoan();
            modify = new ModifyNguoiChoi();

            if (modifyTK.update(taiKhoan) && modify.update(nguoiChoi))
            {
                dgvDSNguoiChoi.DataSource = modify.getAllNguoiChoi();
                MessageBox.Show("Sửa thông tin người chơi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Tên đăng nhập, mật khẩu và điểm cao nhất không thể thay đổi", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Lỗi: " + "Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}