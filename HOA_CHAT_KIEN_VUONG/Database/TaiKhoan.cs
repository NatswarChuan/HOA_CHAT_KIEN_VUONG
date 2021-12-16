using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for HoaChat
/// </summary>

namespace HOA_CHAT_KIEN_VUONG
{
    public class TaiKhoan
    {

        public static DataTable DangNhap(string matk,string mk)
        {
            OleDbCommand cmd = new OleDbCommand("[TaiKhoan_Login]");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            cmd.Parameters.AddWithValue("@MATKHAU", mk);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static int DangKy(string matk, string mk, string quyen, string anh,string hoten, string sdt)
        {
            OleDbCommand cmd = new OleDbCommand("[TaiKhoan_Register]");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            cmd.Parameters.AddWithValue("@MATKHAU", mk);
            cmd.Parameters.AddWithValue("@MAQUYEN", quyen);
            cmd.Parameters.AddWithValue("@HINHANH", anh);
            cmd.Parameters.AddWithValue("@HOTEN", hoten);
            cmd.Parameters.AddWithValue("@SODIENTHOAI", sdt);
            int result = SQL_Database.ExecuteNoneQuery(cmd);
            return result;
        }

        public static DataTable LayThongTin(string matk)
        {
            OleDbCommand cmd = new OleDbCommand("[TaiKhoan_Get]");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static DataTable SuaThongTin(string matk,  string anh, string hoten, string sdt)
        {
            OleDbCommand cmd = new OleDbCommand("[TaiKhoam_Update]");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            cmd.Parameters.AddWithValue("@HINHANH", anh);
            cmd.Parameters.AddWithValue("@HOTEN", hoten);
            cmd.Parameters.AddWithValue("@SODIENTHOAI", sdt);
            return SQL_Database.GetData(cmd);
        }

        public static int DoiMatKhau(string matk, string mk)
        {
            OleDbCommand cmd = new OleDbCommand("[TaiKhoam_Change]");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            cmd.Parameters.AddWithValue("@MATKHAU", mk);
            int result = SQL_Database.ExecuteNoneQuery(cmd);
            return result;
        }

        public static DataTable KiemTraTaiKhoan(string matk)
        {
            OleDbCommand cmd = new OleDbCommand("[TaiKhoam_Check]");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            return SQL_Database.GetData(cmd);
        }
    }
}
