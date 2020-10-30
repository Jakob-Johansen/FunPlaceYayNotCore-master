using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndExtensibility
{
    public class DbMigrater
    {
        private readonly ILogger _logger;

        public DbMigrater(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration startet at " + DateTime.Now);
            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
