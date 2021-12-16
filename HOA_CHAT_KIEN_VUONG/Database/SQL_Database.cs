using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SQL_Database
/// </summary>

namespace HOA_CHAT_KIEN_VUONG
{
    public class SQL_Database
    {
        public SQL_Database()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        //lấy chuỗi kết nối
        private static string _connectionString = string.Empty;
        public static string ConnectionString
        {
            get
            {
                if (_connectionString.Equals(""))
                {
                    _connectionString = "Provider=SQLOLEDB;Data Source=LAPTOP-PNDDKCNP\\SQLEXPRESS;database=DB_HOA_CHAT_KIEN_VUONG;integrated security=sspi;uid=sa;pwd=2991999;charset=utf8";
                }
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        // mở chuỗi kết nối
        public static OleDbConnection GetConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            return conn;
        }

        //thực hiện truy vấn ko cần trả về kết quả (delete,update,insert)
        public static int ExecuteNoneQuery(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
                return 0;
            }
            else
            {
                OleDbConnection conn = GetConnection();
                cmd.Connection = conn;
                return cmd.ExecuteNonQuery();
            }
        }

        //phương thức lấy dữ liệu trả về dataTable
        public static DataTable GetData(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            else
            {
                using (OleDbConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }

        //phương thức lấy dữ liệu trả về tất cả các dataTable
        public static DataSet GetData_OverDataset(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            else
            {
                using (OleDbConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }
    }
}
