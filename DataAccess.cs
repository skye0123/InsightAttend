using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace InsightAttend
{
    public static class DataAccess
    {
        public static string ConnectionString = 
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InsightAttend.accdb;Persist Security Info=False;";

        public static DataTable Query(string sql)
        {
            var dt = new DataTable();
            using (var conn = new OleDbConnection(ConnectionString))
            using (var cmd = new OleDbCommand(sql, conn))
            using (var da = new OleDbDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(dt);
            }
            return dt;
        }

        public static int Execute(string sql)
        {
            using (var conn = new OleDbConnection(ConnectionString))
            using (var cmd = new OleDbCommand(sql, conn))
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
