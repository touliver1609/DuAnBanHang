using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using QLBanHang.Object;

namespace QLBanHang.Model
{
    class NhanVienMod
    {


        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        // con = new SqlConnection();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM Nhanvien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();// đóng phiên làm việc
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "INSERT into Nhanvien values ('"+ nvObj.Ma+ "',N'" + nvObj.Ho + "',N'" + nvObj.Ten + "',N'" + nvObj.DiaChi + "','" + nvObj.DienThoai + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();// đóng phiên làm việc
                con.CloseConn();
            }

            return false;
        }

        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = "UPDATE Nhanvien set HoNV='" + nvObj.Ho + "',Ten='" + nvObj.Ten + "',Diachi='" + nvObj.DiaChi + "',Dienthoai='" + nvObj.DienThoai +"'Where MaNV ='"+nvObj.Ma+ "' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();// đóng phiên làm việc
                con.CloseConn();
            }

            return false;
        }

        public bool DelData(String ma)
        {
            cmd.CommandText = "DELETE NhanVien WHERE MaNV ='"+ma+"' ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();// đóng phiên làm việc
                con.CloseConn();
            }

            return false;
        }
    }
}
