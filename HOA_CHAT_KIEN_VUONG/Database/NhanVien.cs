using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for NhanVien
/// </summary>
namespace HOA_CHAT_KIEN_VUONG
{
    public class NhanVien
    {
        //Lấy danh sách thông tin cơ bản toàn bộ tài khoản nhân viên
        public static DataTable TaiKhoan_Select()
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoan_Select");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }

        public static void TAIKHOAN_DELETE(string matk)
        {
            OleDbCommand cmd = new OleDbCommand("TAIKHOAN_DELETE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);

            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static void NHANVIEN_DELETE(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("NHANVIEN_DELETE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MANV", manv);

            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static DataTable TaiKhoan_Select_Quyen()
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoan_Select_Quyen");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }

        //Lấy toàn thông tin tài khoản 1 nhân viên
        public static DataTable TaiKhoan_Select_All(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoan_Select_All");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MANV", manv);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static void NHANVIEN_INSERT(string manv, string hoten, string gt, DateTime ns, string anh, string dc, string sdt,string mail)
        {
            OleDbCommand cmd = new OleDbCommand("NHANVIEN_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MANHANVIEN", manv);
            cmd.Parameters.AddWithValue("@HOTEN", hoten);
            cmd.Parameters.AddWithValue("@GIOITINH", gt);
            cmd.Parameters.AddWithValue("@NGAYSINH", ns);
            cmd.Parameters.AddWithValue("@ANH", anh);
            cmd.Parameters.AddWithValue("@DIACHI", dc);
            cmd.Parameters.AddWithValue("@DIENTHOAI", sdt);
            cmd.Parameters.AddWithValue("@EMAIL", mail);

            SQL_Database.ExecuteNoneQuery(cmd);

        }

        public static void TaiKhoan_Insert(string matk, string pass, string quyen)
        {
            OleDbCommand cmd = new OleDbCommand("TaiKhoan_Insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            cmd.Parameters.AddWithValue("@MATKHAU", pass);
            cmd.Parameters.AddWithValue("@MAQUYEN", quyen);

            SQL_Database.ExecuteNoneQuery(cmd);

        }

    }
}