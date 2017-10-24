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
    class SanPhamMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        // con = new SqlConnection();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM SanPham";
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

        public bool AddData(SanPhamObj spObj)
        {
            cmd.CommandText = "INSERT into SanPham values ('" + spObj.Ma + "',N'" + spObj.Ten + "',N'" + spObj.Donvi + "','" + spObj.Dongia + "')";
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

        public bool UpdData(SanPhamObj spObj)
        {
            cmd.CommandText = "UPDATE SanPham set TenSP='" + spObj.Ten + "',Donvitinh='" + spObj.Donvi + "',Dongia='" + spObj.Dongia + "' Where MaSP ='" + spObj.Ma + "' ";
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
            cmd.CommandText = "DELETE SanPham WHERE MaSP ='" + ma + "' ";
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
