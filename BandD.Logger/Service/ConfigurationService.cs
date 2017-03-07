using System;

namespace BandD.Logger.Service
{
    public static class ConfigurationService
    {
        public static string WhatAplication(Guid application)
        {
            string result = string.Empty;
            if (application == new Guid("C80D9061-FD9F-4007-9E05-04B59396CE89"))
                result = "BandD.Servis";
            return result;
        }

        internal static string WhatClient(Guid clientId)
        {
            string result = string.Empty;
            if (clientId == new Guid("9B82C798-371D-4A93-BD72-ED4FE52B9DB9"))
                result = "Developer";
            return result;
        }
    }
}