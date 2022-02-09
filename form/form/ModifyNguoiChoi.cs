using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pikachu
{
    class ModifyNguoiChoi
    {
        SqlDataAdapter dataAdapter;//truy xuat du lieu vao bang
        SqlCommand sqlCommand;//truy van va cap nhat CSDL

        public ModifyNguoiChoi()
        {
        }
        public DataTable getAllNguoiChoi()
        {
            DataTable _dt = new DataTable();
            string query = "select * from THONGTINCANHAN";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(_dt);
                sqlConnection.Close();
            }
            return _dt;
        }

        public bool insert(NguoiChoi nguoiChoi)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "insert into THONGTINCANHAN values (@TENDANGNHAP,@GIOITINH,@TUOI,@TENNGUOICHOI,@EMAIL,@DIEMCAONHAT)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                //@ID sinh tự động
                sqlCommand.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = nguoiChoi.user;
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = nguoiChoi.sex;
                sqlCommand.Parameters.Add("@TUOI", SqlDbType.Int).Value = nguoiChoi.age;
                sqlCommand.Parameters.Add("@TENNGUOICHOI", SqlDbType.NVarChar).Value = nguoiChoi.name;
                sqlCommand.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = nguoiChoi.email;
                sqlCommand.Parameters.Add("@DIEMCAONHAT", SqlDbType.Int).Value = nguoiChoi.record;
                sqlCommand.ExecuteNonQuery();//thuc thi lenh truy van
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

        public bool update(NguoiChoi nguoiChoi)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "update THONGTINCANHAN set GIOITINH = @GIOITINH, TUOI = @TUOI, TENNGUOICHOI = @TENNGUOICHOI, EMAIL = @EMAIL";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                //@ID không được sửa
                //sqlCommand.Parameters.Add("@TENDANGNHAP", SqlDbType.NVarChar).Value = nguoiChoi.user;//@TENDANGNHAP không được sửa
                sqlCommand.Parameters.Add("@GIOITINH", SqlDbType.NVarChar).Value = nguoiChoi.sex;
                sqlCommand.Parameters.Add("@TUOI", SqlDbType.Int).Value = nguoiChoi.age;
                sqlCommand.Parameters.Add("@TENNGUOICHOI", SqlDbType.NVarChar).Value = nguoiChoi.name;
                sqlCommand.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = nguoiChoi.email;
                //sqlCommand.Parameters.Add("@DIEMCAONHAT", SqlDbType.Int).Value = nguoiChoi.record;//@DIEMCAONHAT không được sửa
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
