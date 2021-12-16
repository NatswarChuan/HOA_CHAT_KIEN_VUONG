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
    public class HoaChat
    {
        public static void SanPham_Insert(string mahh, string tenhh, string mancc,string xuatsu, string qc, string maloai, int tinhtrang, string mota, DateTime ngaysx, DateTime hansd, string image)
        {
            OleDbCommand cmd = new OleDbCommand("SanPham_Insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHANGHOA", mahh);
            cmd.Parameters.AddWithValue("@TENHANGHOA", tenhh);
            cmd.Parameters.AddWithValue("@MANHACUNGCAP", mancc);
            cmd.Parameters.AddWithValue("@QUYCACH", qc);
            cmd.Parameters.AddWithValue("@MALOAI", maloai);
            cmd.Parameters.AddWithValue("@TINHTRANG", tinhtrang);
            cmd.Parameters.AddWithValue("@MOTA", mota);
            cmd.Parameters.AddWithValue("@NGAYSANXUAT", ngaysx);
            cmd.Parameters.AddWithValue("@HANSUDUNG", hansd);
            cmd.Parameters.AddWithValue("@IMGAGESPATH", image);
            SQL_Database.ExecuteNoneQuery(cmd);

        }

        public static void SanPham_Update(string mahh, string tenhh, string mancc, string xuatsu, string qc, string maloai, string mota, DateTime ngaysx, DateTime hansd, string image,string xuatxu)
        {
            OleDbCommand cmd = new OleDbCommand("SanPham_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHANGHOA", mahh);
            cmd.Parameters.AddWithValue("@TENHANGHOA", tenhh);
            cmd.Parameters.AddWithValue("@MANHACUNGCAP", mancc);
            cmd.Parameters.AddWithValue("@XUATSU", xuatxu);
            cmd.Parameters.AddWithValue("@QUYCACH", qc);
            cmd.Parameters.AddWithValue("@MALOAI", maloai);
            
            cmd.Parameters.AddWithValue("@MOTA", mota);
            cmd.Parameters.AddWithValue("@NGAYSANXUAT", ngaysx);
            cmd.Parameters.AddWithValue("@HANSUDUNG", hansd);
            cmd.Parameters.AddWithValue("@IMGAGESPATH", image);
            SQL_Database.ExecuteNoneQuery(cmd);

        }

        public static void SANPHAM_UPDATE_SL(string mahh, int sl)
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_UPDATE_SL");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHH", mahh);
            cmd.Parameters.AddWithValue("@SL", sl);
            
            SQL_Database.ExecuteNoneQuery(cmd);

        }

        public static void SanPham_Delete(string mahh)
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_DELETE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHH", mahh);
            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static void CAPNHATGIA_DELETE(string mahh)
        {
            OleDbCommand cmd = new OleDbCommand("CAPNHATGIA_DELETE");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHH", mahh);
            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static DataTable SanPham_Select()
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_SELECT");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }

        public static DataTable SANPHAM_SELECT_TENSP()
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_SELECT_TENSP");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }

        public static DataTable SANPHAM_SELECT_MALINHVUC(string malv)
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_SELECT_MALINHVUC");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALINHVUC", malv);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static DataTable SANPHAM_SELECT_MALOAI(string maloai)
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_SELECT_MALOAI");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOAI", maloai);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static DataTable SANPHAM_SELECT_GIA(int min,int max)
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_SELECT_GIA");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MIN", min);
            cmd.Parameters.AddWithValue("@MAX", max);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static DataTable SanPham_Select_Masp(string maloai)
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_SELECT_MASP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHH", maloai);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static DataTable SanPham_SelectFull(string mahc)
        {
            OleDbCommand cmd = new OleDbCommand("SanPham_SelectFull");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHH", mahc);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }

        public static DataTable SanPham_KTra(string mahc)
        {
            OleDbCommand cmd = new OleDbCommand("SanPham_KTra");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAHH", mahc);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }
        public static DataTable SANPHAM_SELECT_LOAI(string MALOAI)
        {
            OleDbCommand cmd = new OleDbCommand("SANPHAM_SELECT_LOAI");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOAI", MALOAI);
            return SQL_Database.GetData(cmd);
        }
    }
}
