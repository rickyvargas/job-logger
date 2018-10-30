using System;
using Job.Logger.Service.Entities;
using Job.Logger.Service.Enums;

namespace Job.Logger.Service.Providers
{
    public class LoggerConsoleProvider: ILoggerProvider
    {

        public void WriteMessage(LoggerEntity loggerEntity)
        {
            switch (loggerEntity.type)
            {
                case LoggerType.Message: Console.ForegroundColor = ConsoleColor.White; break;
                case LoggerType.Warning: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case LoggerType.Error: Console.ForegroundColor = ConsoleColor.Red; break;
            }
            Console.WriteLine(loggerEntity.getMessage);
        }
    }
}
