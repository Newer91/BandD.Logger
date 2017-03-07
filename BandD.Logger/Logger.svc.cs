using BandD.Logger.Class;
using BandD.Logger.Service;
using System;
using static BandD.Logger.ApplicationLogger.ApplicationLogger;

namespace BandD.Logger
{
    public class Logger : ILogger
    {
        public void SaveErrorToDataBase(Guid applicationId, Guid clientId, Exception exeption)
        {
            string aplication = ConfigurationService.WhatAplication(applicationId);
            string client = ConfigurationService.WhatClient(clientId);

            LogHelp log = new LogHelp() { AplicationName = aplication, ClientName = client, Exeption = exeption, MethodName = exeption.TargetSite.Name };

            if (aplication == "BandD.Servis")
                new BandDServisApplication().SaveError(log);


            //new MailService().SendEmail(log);
        }
    }
}
