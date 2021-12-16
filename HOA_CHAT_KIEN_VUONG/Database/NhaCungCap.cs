using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for NhaCungCap
/// </summary>
 
namespace HOA_CHAT_KIEN_VUONG
{
    public class NhaCungCap
    {
        public static DataTable NhaCC_Select()
        {
            OleDbCommand cmd = new OleDbCommand("NhaCC_Select");
            cmd.CommandType = CommandType.StoredProcedure;

            return SQL_Database.GetData(cmd);
        }
    }
}
