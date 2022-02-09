using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pikachu
{
    class ModifyTaiKhoan
    {
        SqlCommand sqlCommand;

        public ModifyTaiKhoan()
        {
        }
        public bool insert(TaiKhoan taiKhoan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into TAIKHOAN values (@TENDANGNHAP,@MATKHAU,@TENNGUOICHOI)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = taiKhoan.user;
                sqlCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = taiKhoan.password;
                sqlCommand.Parameters.Add("@TENNGUOICHOI", SqlDbType.NVarChar).Value = taiKhoan.name;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool update(TaiKhoan taiKhoan)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "select TAIKHOAN set TENNGUOICHOI =  @TENNGUOICHOI";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlCommand.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = taiKhoan.user;
                //sqlCommand.Parameters.Add("@MATKHAU", SqlDbType.NVarChar).Value = taiKhoan.password;
                sqlCommand.Parameters.Add("@TENNGUOICHOI", SqlDbType.NVarChar).Value = taiKhoan.name;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
