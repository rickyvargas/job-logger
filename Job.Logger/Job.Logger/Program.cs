using System;
using Job.Logger.Service;
using Job.Logger.Service.Enums;

namespace Job.Logger.console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ILoggerHandler log = new LoggerHandler();
            log.Initialize(LoggerProviderType.Console );
            //log.Initialize(LoggerProviderType.Database);
            //log.Initialize(LoggerProviderType.File);
            //log.Initialize(LoggerProviderType.All);

            log.WriteMessage("Message sent");
            log.WriteWarning("Warning found");
            log.WriteError("Error ocurred");
            Console.ReadKey();
        }
    }
}
