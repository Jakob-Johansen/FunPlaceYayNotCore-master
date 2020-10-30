using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExtensibility
{
    class Program
    {

        static void Main(string[] args)
        {
            var dbMigrater = new DbMigrater(new FileLogger("C:\\Test\\Log.txt"));
            dbMigrater.Migrate();
        }
    }
}
