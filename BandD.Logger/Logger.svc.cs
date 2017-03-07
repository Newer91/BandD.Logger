using BandD.Logger.Class;
using BandD.Logger.Service;
using System;
using static BandD.Logger.ApplicationLogger.ApplicationLogger;

namespace BandD.Logger
{
    public class Logger : ILogger
    {
        public void SaveErrorToDataBase(Guid applicationId, Guid clientId, string exeptionMessage, string methodNames)
        {
            string aplication = ConfigurationService.WhatAplication(applicationId);
            string client = ConfigurationService.WhatClient(clientId);

            LogHelp log = new LogHelp() { AplicationName = aplication, ClientName = client, ExeptionMessage = exeptionMessage , MethodName = methodNames };

            if (aplication == "BandD.Servis")
                new BandDServisApplication().SaveError(log);
        }
    }
}
