using System;
using System.Collections.Generic;
using Job.Logger.Service.Enums;
using Job.Logger.Service.Entities;
using Job.Logger.Service.Providers;

namespace Job.Logger.Service
{
    public class LoggerHandler : ILoggerHandler
    {
        private List<ILoggerProvider> providers;

        public void Initialize(LoggerProviderType type)
        {
            this.providers = new List<ILoggerProvider>();
            switch (type)
            {
                case LoggerProviderType.Console: this.providers.Add(new LoggerConsoleProvider()); break;
                case LoggerProviderType.File: this.providers.Add(new LoggerFileProvider()); break;
                case LoggerProviderType.Database: this.providers.Add(new LoggerDatabaseProvider()); break;
                case LoggerProviderType.All: 
                    this.providers.Add(new LoggerConsoleProvider());
                    this.providers.Add(new LoggerFileProvider());
                    this.providers.Add(new LoggerDatabaseProvider());
                    break;
                default:
                    this.providers.Add(new LoggerConsoleProvider()); break;
            }
        }


        public void WriteMessage(string message)
        {
            foreach (var provider in this.providers)
            {
                provider.WriteMessage(new LoggerEntity(LoggerType.Message, message));
            }
        }

        public void WriteWarning(string warning)
        {
            foreach (var provider in this.providers)
            {
                provider.WriteMessage(new LoggerEntity(LoggerType.Warning, warning));
            }
        }

        public void WriteError(string error)
        {
            foreach (var provider in this.providers)
            {
                provider.WriteMessage(new LoggerEntity(LoggerType.Error, error));
            }
        }
    }
}
