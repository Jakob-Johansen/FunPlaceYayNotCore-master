using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void OpenConnection()
        {
            Console.WriteLine("SqlConnection to: " + ConnectionString + " Opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SqlConnection to: " + ConnectionString + " Closed");
        }
    }
}
