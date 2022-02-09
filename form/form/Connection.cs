using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pikachu
{
    class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-PN54ICF\SQLEXPRESS;Initial Catalog=GAMEPIKACHU;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
