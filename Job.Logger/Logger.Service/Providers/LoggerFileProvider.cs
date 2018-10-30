using System;
using System.Configuration;
using System.IO;
using Job.Logger.Service.Entities;

namespace Job.Logger.Service.Providers
{
    public class LoggerFileProvider: ILoggerProvider
    {
        readonly string path;

        public LoggerFileProvider()
        {
            this.path = ConfigurationManager.AppSettings["LoggerFilePath"];
            if (this.path == null)
                this.path = string.Format("log-{0}.log",DateTime.Now.ToString(("MM-dd-yyyy")));
        }

        public void WriteMessage(LoggerEntity loggerEntity)
        {
            using (StreamWriter fileWriter = File.AppendText(this.path))
            {
                fileWriter.WriteLine(loggerEntity.getMessage);
            }
        }
    }
}
