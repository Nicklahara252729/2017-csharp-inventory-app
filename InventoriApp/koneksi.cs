using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoriApp
{
    class koneksi
    {
        public static string ConnString = string.Format("Data source=XE;User Id=dbinventori;Password=123;");
        public static OracleConnection GetOracleConnection()
        {
            return new OracleConnection(ConnString);
        }
    }
}
