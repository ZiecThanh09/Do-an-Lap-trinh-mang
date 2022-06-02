using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DangNhap
{
    class Connection
    {
        private static string stringConnection = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTaiKhoan;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
