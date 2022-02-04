using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu.DAO
{
    public class TaiKhoan
    {
        private static TaiKhoan instance;
        public static TaiKhoan Instance
        {
            get { if (instance == null) instance = new TaiKhoan(); return TaiKhoan.instance; }
            private set { TaiKhoan.instance = value; }
        }
        public TaiKhoan()
        {

        }
        public bool DangNhap(string TenDangNhap, string MatKhau)
        {
            //string query = "SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = "TEST" AND MATKHAU = "1"";
            return false;
        }


    }
}
