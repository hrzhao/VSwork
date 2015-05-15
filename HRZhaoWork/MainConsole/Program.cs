using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MainConsole.com;
using log4net.Config;

namespace MainConsole
{
    class Program
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            //log4net.ILog logger = 
            //XmlConfigurator.Configure(new System.IO.FileInfo(args[0]));
            log.Info("Program Start!1");
            log.Debug("Program Start!2");
            log.Error("Program Start!3");

            new Bar().DoIt();

            //Console.WriteLine("helloWorld");
            ConsoleKeyInfo keyInfo;
            while(true)
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Q)
                {
                    log.Info("q=>break");
                    break;
                }
            }
        }
    }
}
