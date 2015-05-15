using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace MainConsole.com
{
    public class Bar
    {
        private static readonly ILog log = LogManager.GetLogger("testApp.Logging");

        public void DoIt()
        {
            log.Debug("Did it again!");
        }

    }
}
