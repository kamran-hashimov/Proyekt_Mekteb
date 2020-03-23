using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mekteb
{
    class Sql_connection
    {
        public SqlConnection Connect()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FKU6315\\SQL;Initial Catalog=Mekteb;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
