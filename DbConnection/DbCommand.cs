using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(string instruction, DbConnection dbConnection)
        {
            if (String.IsNullOrWhiteSpace(instruction) || dbConnection == null || dbConnection.ConnectionString.Length == 0)
                throw new InvalidOperationException("Du mangler at skrive en instruktion ellers er din connection strin null eller tom.");

            _instruction = instruction;
            _dbConnection = dbConnection;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
        }
    }
}
