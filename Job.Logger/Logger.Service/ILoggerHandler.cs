using System;
using Job.Logger.Service.Enums;

namespace Job.Logger.Service
{
    public interface ILoggerHandler
    {

        void Initialize(LoggerProviderType type);
        void WriteMessage(string message);
        void WriteWarning(string warning);
        void WriteError(string error);

    }
}
