using System;
using System.Collections.Generic;
using System.Data;
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
            string query = "select * from TAIKHOAN where TENDANGNHAP = '" + TenDangNhap + "' AND MATKHAU = '" + MatKhau + "'";
            DataTable r = DAO.DataProvide.Instance.LayDuLieu(query);
            return r.Rows.Count > 0;
        }


    }
}
