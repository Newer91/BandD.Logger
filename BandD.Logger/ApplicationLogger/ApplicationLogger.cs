using BandD.Logger.Class;
using BandD.Logger.Domain;
using System;

namespace BandD.Logger.ApplicationLogger
{
    public class ApplicationLogger
    {
        public class BandDServisApplication
        {
            internal void SaveError(LogHelp log)
            {
                using (var ctx = new LoggerContext())
                {
                    ctx.BandDServisLogger.Add(PrepereItemToAdd(log));
                    ctx.SaveChanges();
                }
            }

            private BandDServisLogger PrepereItemToAdd(LogHelp log)
            {
                BandDServisLogger item = new BandDServisLogger()
                {
                    Date = DateTime.Now,
                    ServisLoggerId = Guid.NewGuid(),

                    MethodsName = log.MethodName,
                    ErrorMessage = log.ExeptionMessage,
                    Client = log.ClientName
                };

                return item;
            }
        }
    }
}