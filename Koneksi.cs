using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApllikasiKoneksi
{
    internal class Koneksi
    {
        static string connString = "Data Source=DESKTOP-GVK4VLH\\SQLEXPRESS;Initial Catalog=TokoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}
