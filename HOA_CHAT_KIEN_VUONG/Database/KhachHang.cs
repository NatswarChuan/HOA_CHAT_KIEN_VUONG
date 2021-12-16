using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for KhachHang
/// </summary>
namespace HOA_CHAT_KIEN_VUONG
{
    public class KhachHang
    {
        public static void KhachHang_Insert(string sdt, string tenkh, string gt, DateTime ngaysinh, string dc, string mail, string pass)
        {
            OleDbCommand cmd = new OleDbCommand("KHACHHANG_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SODT", sdt);
            cmd.Parameters.AddWithValue("@TENKH", tenkh);
            cmd.Parameters.AddWithValue("@GT", gt);
            cmd.Parameters.AddWithValue("@NGAYSINH", ngaysinh);
            cmd.Parameters.AddWithValue("@DC", dc);
            cmd.Parameters.AddWithValue("@MAIL", mail);
            SQL_Database.ExecuteNoneQuery(cmd);

            OleDbCommand cmd1 = new OleDbCommand("TaiKhoan_Insert");
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@MATK", sdt);
            cmd1.Parameters.AddWithValue("@MATKHAU", pass);
            cmd1.Parameters.AddWithValue("@MAQUYEN", "KH");

            SQL_Database.ExecuteNoneQuery(cmd1);

        }

        public static DataTable KhachHang_Select_All(string matk)
        {
            OleDbCommand cmd = new OleDbCommand("KhachHang_Select_All");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SDT", matk);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static DataTable TaiKhoanKH_Select()
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoanKH_Select");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }
    }
}
