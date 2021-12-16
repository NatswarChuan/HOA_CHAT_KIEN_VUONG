using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PhieuNhap
/// </summary>
namespace HOA_CHAT_KIEN_VUONG
{
    public class PhieuNhap
    {
        public static DataTable PHIEUNHAP_SELECT()
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUNHAP_SELECT");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }

        public static DataTable PHIEUNHAP_SELECT_ALL(string mapn)
        {
            OleDbCommand cmd = new OleDbCommand("PHIEUNHAP_SELECT_ALL");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAPHIEUNHAP", mapn);

            return SQL_Database.GetData(cmd);
        }

    }
}