using System;

namespace BandD.Logger.Service
{
    public static class ConfigurationService
    {
        public static string WhatAplication(Guid application)
        {
            string result = string.Empty;
            if (application == Guid.NewGuid())
                result = "BandD.Servis";
            return result;
        }

        internal static string WhatClient(Guid clientId)
        {
            string result = string.Empty;
            if (clientId == Guid.NewGuid())
                result = "Developer";
            return result;
        }
    }
}