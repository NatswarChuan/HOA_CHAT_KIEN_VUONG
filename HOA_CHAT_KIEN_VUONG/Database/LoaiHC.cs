using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for LoaiHC
/// </summary>

namespace HOA_CHAT_KIEN_VUONG
{
    public class LoaiHC
    {
        public static DataTable LoaiHang_Select()
        {
            OleDbCommand cmd = new OleDbCommand("LoaiHang_Select");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }
    }
}
