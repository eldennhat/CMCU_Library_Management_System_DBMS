using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Database
{
    public static class Db
    {
        public static SqlConnection Open()
        {
            if (string.IsNullOrWhiteSpace(AppSession.ConnectionString))
                throw new InvalidOperationException("Chưa thiết lập chuỗi kết nối. Vào màn hình Kết nối trước.");

            var conn = new SqlConnection(AppSession.ConnectionString);
            conn.Open();
            return conn;
        }

        public static DataTable Query(string sql, Action<SqlParameterCollection>? bind = null)
        {
            using var conn = Open();
            using var cmd = new SqlCommand(sql, conn);
            bind?.Invoke(cmd.Parameters);
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int Execute(string sql, Action<SqlParameterCollection>? bind = null)
        {
            using var conn = Open();
            using var cmd = new SqlCommand(sql, conn);
            bind?.Invoke(cmd.Parameters);
            return cmd.ExecuteNonQuery();
        }
    }
}
