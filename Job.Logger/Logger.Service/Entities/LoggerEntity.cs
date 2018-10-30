using System;
using Job.Logger.Service.Enums;

namespace Job.Logger.Service.Entities
{
    public class LoggerEntity
    {
        public string text { get; set; }

        public LoggerType type { get; set; }

        public string getMessage
        {
            get
            {
                return String.Format("{0} ({1})", type, text);
            }
        }


        public LoggerEntity(LoggerType type, string text)
        {
            this.text = text;
            this.type = type;
        }
    }
}
