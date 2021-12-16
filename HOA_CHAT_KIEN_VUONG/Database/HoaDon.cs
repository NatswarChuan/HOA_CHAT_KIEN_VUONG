using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for HoaDon
/// </summary>

namespace HOA_CHAT_KIEN_VUONG
{
    public class HoaDon
    {
        public static void HOADON_INSERT(string taikhoan,string mahd,string sdt,string tenkh,string gt,DateTime ngaysinh,string diachi,string email,DateTime ngaytao,int tongtien,int thanhtien,string thanhtoan, string ghichu,string trangthai)
        {
            OleDbCommand cmd = new OleDbCommand("HOADON_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TAIKHOAN", taikhoan);
            cmd.Parameters.AddWithValue("@MAHOADON", mahd);
            cmd.Parameters.AddWithValue("@SODIENTHOAI", sdt);
            cmd.Parameters.AddWithValue("@TENKHACHHANG", tenkh);
            cmd.Parameters.AddWithValue("@GIOITINH", gt);
            cmd.Parameters.AddWithValue("@NGAYSINH", ngaysinh);
            cmd.Parameters.AddWithValue("@DIACHI", diachi);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@MANHANVIEN", "");
            cmd.Parameters.AddWithValue("@NGAYTAO", ngaytao);
            cmd.Parameters.AddWithValue("@TONGTIEN", tongtien);
            cmd.Parameters.AddWithValue("@THANHTIEN", thanhtien);
            cmd.Parameters.AddWithValue("@THANHTOAN", thanhtoan);
            cmd.Parameters.AddWithValue("@GHICHU", ghichu);
            cmd.Parameters.AddWithValue("@TRANGTHAI", trangthai);
            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static void CTHD_INSERT(string mahd, string mahh, string ten, int soluong, int dongia)
        {
            OleDbCommand cmd = new OleDbCommand("CTHD_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHOADON", mahd);
            cmd.Parameters.AddWithValue("@MAHANGHOA", mahh);
            cmd.Parameters.AddWithValue("@TENHANG", ten);
            cmd.Parameters.AddWithValue("@SOLUONG", soluong);
            cmd.Parameters.AddWithValue("@DONGIA", dongia);
            
            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static void PHIEUHUY_INSERT(string maph, DateTime ngayhuy, string lydo, string manv, string ghichu)
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUHUY_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUHUY", maph);
            cmd.Parameters.AddWithValue("@NGAYHUY", ngayhuy);
            cmd.Parameters.AddWithValue("@LYDOHUY", lydo);
            cmd.Parameters.AddWithValue("@MANHANVIEN", manv);
            cmd.Parameters.AddWithValue("@GHICHU", ghichu);

            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static DataTable PHIEUHUY_SELECT(string maph)
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUHUY_SELECT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPH", maph);

            return SQL_Database.GetData(cmd);
        }

        public static DataTable HOADON_SELECT()
        {
            OleDbCommand cmd = new OleDbCommand("HOADON_SELECT");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }

        public static DataTable HOADON_SEARCH(string sdt)
        {
            
            OleDbCommand cmd = new OleDbCommand("HOADON_SEARCH");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", sdt);

            return SQL_Database.GetData(cmd);
        }

        public static DataTable HOADON_SEARCH_TT(string matk,string tt)
        {

            OleDbCommand cmd = new OleDbCommand("HOADON_SEARCH_TT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MATK", matk);
            cmd.Parameters.AddWithValue("@TRANGTHAI", tt);

            return SQL_Database.GetData(cmd);
        }

        public static DataTable HOADON_SEARCH_TT1(string tt)
        {

            OleDbCommand cmd = new OleDbCommand("HOADON_SEARCH_TT1");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TRANGTHAI", tt);

            return SQL_Database.GetData(cmd);
        }
        public static DataTable HOADON_TT(string tt)
        {

            OleDbCommand cmd = new OleDbCommand("HOADON_TT");
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@TRANGTHAI", tt);

            return SQL_Database.GetData(cmd);
        }

        public static DataTable HOADON_SEARCH_MAHD(string mahd)
        {

            OleDbCommand cmd = new OleDbCommand("HOADON_SEARCH_MAHD");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHD", mahd);

            return SQL_Database.GetData(cmd);
        }

        public static DataTable CTHD_SEARCH_MAHD(string mahd)
        {

            OleDbCommand cmd = new OleDbCommand("CTHD_SEARCH_MAHD");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHD", mahd);

            return SQL_Database.GetData(cmd);
        }

        public static void HOADON_UPDATE_TT(string mahd,string trangthai,string manv)
        {
            OleDbCommand cmd = new OleDbCommand("HOADON_UPDATE_TT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHD", mahd);
            cmd.Parameters.AddWithValue("@TRANGTHAI", trangthai);
            cmd.Parameters.AddWithValue("@MANHANVIEN", manv);

            SQL_Database.ExecuteNoneQuery(cmd);

        }

        public static void HOADON_UPDATE_TT1(string mahd, string trangthai)
        {
            OleDbCommand cmd = new OleDbCommand("HOADON_UPDATE_TT1");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHD", mahd);
            cmd.Parameters.AddWithValue("@TRANGTHAI", trangthai);

            SQL_Database.ExecuteNoneQuery(cmd);

        }

    }
}