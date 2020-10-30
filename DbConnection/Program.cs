using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("G54dR55sd7Es4fFe589");
            var sqlCommand = new DbCommand("GetALL", sqlConnection);

            var oracleConnection = new OracleConnection("H4Im243i0S4Ke4o3");
            var oracleCommand = new DbCommand("GetByID", oracleConnection);

            sqlCommand.Execute();
            Console.WriteLine("");
            oracleCommand.Execute();
        }
    }
}
