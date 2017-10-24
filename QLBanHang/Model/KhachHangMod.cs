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
    class KhachHangMod
    {

        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        // con = new SqlConnection();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT MaKH,TenKH,DiaChi,DienThoai,Fax FROM KhachHang";
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

        public bool AddData(KhachHangObj khObj)
        {
            cmd.CommandText = "INSERT into KhachHang values ('" + khObj.Ma + "',N'" + khObj.Ten + "',N'" + khObj.DiaChi + "','" + khObj.DienThoai + "',N'" + khObj.Fax + "')";
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

        public bool UpdData(KhachHangObj khObj)
        {
            cmd.CommandText = "UPDATE KhachHang set TenKH='" + khObj.Ten + "',DiaChi='" + khObj.DiaChi + "',DienThoai='" + khObj.DienThoai + "',Fax='" + khObj.Fax + "'Where MaKH ='" + khObj.Ma + "' ";
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
            cmd.CommandText = "DELETE KhachHang WHERE MaKH ='" + ma + "' ";
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
