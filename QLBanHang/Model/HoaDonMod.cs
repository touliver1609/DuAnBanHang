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
    class HoaDonMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        // con = new SqlConnection();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = @"SELECT hd.MaHD, hd.NgayLapHD, kh.TenKH, nv.Ten FROM HoaDon hd,KhachHang kh, Nhanvien nv WHERE hd.MaKH = kh.MaKH and hd.MaNV = nv.MaNV";
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

        public bool AddData(HoaDonObj hdObj)
        {
            cmd.CommandText = "INSERT INTO HoaDon VALUE ('"+ hdObj.Mahd +"', CONVERT(date,'" + hdObj.Ngaylap + "',103),'" + hdObj.Manv +"','" + hdObj.Makh + "')";
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
            cmd.CommandText = "DELETE HoaDon WHERE MaHD ='" + ma + "' ";
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
