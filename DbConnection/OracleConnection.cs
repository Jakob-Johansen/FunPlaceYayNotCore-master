using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void OpenConnection()
        {
            Console.WriteLine("OracleConnection to: " + ConnectionString + " Opened");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("OracleConnection to: " + ConnectionString + " Closed");
        }
    }
}
