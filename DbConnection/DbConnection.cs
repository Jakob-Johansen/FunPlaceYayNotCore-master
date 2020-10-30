using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        //public TimeSpan Timeout { get; private set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Du mangler at skrive din sql connection string.");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
