using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for PhieuXuat
/// </summary>

namespace HOA_CHAT_KIEN_VUONG
{
    public class PhieuXuat
    {
        public static void PHIEUXUAT_INSERT(string mapx, DateTime ngayxuat,string manv)
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUXUAT_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUXUAT", mapx);
            cmd.Parameters.AddWithValue("@NGAYXUAT", ngayxuat);
            cmd.Parameters.AddWithValue("@MANHANVIEN", manv);

            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static void CHITIETPHIEUXUAT_INSERT(string mapx, string mahh, string ten,int sl,int gia)
        {
            OleDbCommand cmd = new OleDbCommand("CHITIETPHIEUXUAT_INSERT");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUXUAT", mapx);
            cmd.Parameters.AddWithValue("@MAHANGHOA", mahh);
            cmd.Parameters.AddWithValue("@TENHANG", ten);
            cmd.Parameters.AddWithValue("@SOLUONG", sl);
            cmd.Parameters.AddWithValue("@DONGIA", gia);
            cmd.Parameters.AddWithValue("@TONGTIEN", (sl*gia));

            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static void PHIEUXUAT_UPDATESL(string mapx)
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUXUAT_UPDATESL");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUXUAT", mapx);

            SQL_Database.ExecuteNoneQuery(cmd);
        }

        public static DataTable PHIEUXUAT_SELECT()
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUXUAT_SELECT");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }

        public static DataTable PHIEUXUAT_SELECTALL(string mapx)
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUXUAT_SELECTALL");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUXUAT", mapx);

            return SQL_Database.GetData(cmd);
        }
    }
}