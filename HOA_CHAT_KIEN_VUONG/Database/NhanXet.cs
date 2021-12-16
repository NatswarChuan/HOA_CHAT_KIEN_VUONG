using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for NhanXet
/// </summary>

namespace HOA_CHAT_KIEN_VUONG
{
    public class NhanXet
    {
        public static DataTable Nhanxet_Select_MaSP(string mahc)
        {

            OleDbCommand cmd = new OleDbCommand("Nhanxet_Select_MaSP");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MASP", mahc);
            SQL_Database.ExecuteNoneQuery(cmd);
            return SQL_Database.GetData(cmd);
        }
    }
}
