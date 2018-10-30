using System;
using Job.Logger.Service.Entities;

namespace Job.Logger.Service.Providers
{
    public interface ILoggerProvider
    {
        void WriteMessage(LoggerEntity loggerEntity);
    }
}
