using System;
using Job.Logger.Service.Entities;
using Job.Logger.Service.Enums;
using NUnit.Framework;

namespace Job.Logger.UnitTest
{
    public class LoggerTest
    {
        [Test()]
        public void testGetMessage()
        {
            var message = "test message";
            var result = string.Format("{0} ({1})", LoggerType.Warning, message);
            var loggerEntity = new LoggerEntity(LoggerType.Warning, message);
            Assert.AreEqual(result, loggerEntity.getMessage);
        }       
    }
}
