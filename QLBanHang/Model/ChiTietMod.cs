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
    class ChiTietMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        // con = new SqlConnection();

        public DataTable GetData(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"SELECT ct.MaHD , sp.TenSP, ct.Soluong ,sp.Dongia, ct.Giamgia FROM CTHD ct, SanPham sp WHERE sp.MaSP = ct.MaSP and MaHD = '" + ma + "'";
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

        public bool AddData(ChiTietObj ctObj)
        {
            cmd.CommandText = "INSERT INTO CTHD VALUES ('" + ctObj.Mahd + "','" + ctObj.Masp + "','" + ctObj.Sl+ "','"+ ctObj.Gg+"')";
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
            cmd.CommandText = "DELETE CTHD WHERE MaHD ='" + ma + "' ";
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
